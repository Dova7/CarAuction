﻿using AutoMapper;
using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.Bid;
using CarAuctionApplication.Service.Mapper;
using CarAuctionDomain.Constants.Enums.Bidding;
using CarAuctionDomain.Entities.Bidding;
using CarAuctionEntities.Constants.Enums;

namespace CarAuctionApplication.Service.Implementations
{
    public class BidService : IBidService
    {
        private readonly IBidRepository _bidRepository;
        private readonly IAuctionRepository _auctionRepository;
        private readonly IMapper _mapper;
        public BidService(MappingProfile mappingProfile, IAuctionRepository auctionRepository, IBidRepository bidRepository)
        {
            _auctionRepository = auctionRepository;
            _bidRepository = bidRepository;
            _mapper = mappingProfile.InitializeBid();
        }
        public async Task AddAmount(Guid auctionId, AddBidDto addBidDto)
        {
            if (addBidDto is null || auctionId == Guid.Empty)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }            
            var bid = _mapper.Map<Bid>(addBidDto);
            var auction = await _auctionRepository.GetAsync(x => x.Id == auctionId);
            if (auction is null)
            {
                throw new ArgumentException("Auction Not Found");
            }
            if (bid.BidAmount < auction.ReservePrice)
            {
                bid.Status = BidStatus.BelowReserve;
            }
            else if (auction.Status != Status.Live)
            {
                bid.Status = BidStatus.AuctionClosed;
            }
            else if (bid.BidAmount < auction.CurrentHighBid)
            {
                bid.Status = BidStatus.InvalidBid;
            }
            else
            {
                bid.Status = BidStatus.BidPlaced;  
                auction.CurrentHighBid = bid.BidAmount;
            }
            await _auctionRepository.Update(auction);
            await _auctionRepository.Save();

            await _bidRepository.AddAsync(bid);
            await _bidRepository.Save();
        }

        public async Task DeleteBid(Guid bidId)
        {
            if (bidId == Guid.Empty)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }
            var bid = await _bidRepository.GetAsync(x => x.Id == bidId);
            if (bid is null)
            {
                throw new Exception("Bid not found");
            }
            _bidRepository.Remove(bid);
            await _bidRepository.Save();
        }
    }
}