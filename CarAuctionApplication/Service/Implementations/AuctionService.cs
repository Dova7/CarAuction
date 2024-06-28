using AutoMapper;
using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
using CarAuctionApplication.Service.Mapper;

namespace CarAuctionApplication.Service.Implementations
{
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository _AuctionRepository;
        private readonly IMapper _mapper;
        public AuctionService(MappingProfile mappingProfile,IAuctionRepository auctionRepository)
        {
            _AuctionRepository = auctionRepository;
            _mapper = mappingProfile.InitilizeAuction();
        }
        public async Task<List<AuctionForGettingDtoAllLive>> GetAllLiveAuctionsAsync()
        {
            var raw = await _AuctionRepository.GetAllAsync(includePropeties: "AuctionItem");
            if (raw.Count == 0)
            {
                throw new Exception("Auctions not Found");
            }
            var filteredRaw = raw.Where(t => t.Status == CarAuctionEntities.Constants.Enums.Status.Live).ToList();
            if (filteredRaw.Count == 0)
            {
                throw new Exception("No Live Auctions found");
            }
            var Auctions = _mapper.Map<List<AuctionForGettingDtoAllLive>>(filteredRaw);
            return Auctions;

        }

        public async Task<AuctionForGettingDtoSingle> GetSingleAuctionAsync(Guid id)
        {
            var raw = await _AuctionRepository.GetAsync(x => x.Id == id, includePropeties: "AuctionItem,AuctionItem.Images,AuctionItem.AdditionalProperties");
            if (raw is null)
            {
                throw new Exception("Auction not Found");
            }            
            var Auction = _mapper.Map<AuctionForGettingDtoSingle>(raw);
            return Auction;
        }
    }
}
