using AutoMapper;
using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.Auction;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
using CarAuctionApplication.Service.Mapper;
using CarAuctionEntities.Entities;

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
        public async Task CreateAuctionAsync(AuctionForCreatingDto auctionForCreatingDto)
        {
            if (auctionForCreatingDto is null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }
            var result = _mapper.Map<Auction>(auctionForCreatingDto);
            /*var userId = _userRepository.AuthenticatedUserId();
            if (userId is null)
            {
                throw new UnauthorizedAccessException("Must be logged in to create topic");
            }*/
            result.SellerId = "1365FCBA-5EBF-45B9-B67C-11DC33B91B12";
            await _AuctionRepository.AddAsync(result);
            await _AuctionRepository.Save();
        }
        public async Task DeleteAuctionAsync(Guid auctionId)
        {
            if (auctionId == Guid.Empty)
            {
                throw new ArgumentException("Invalid argument passed");
            }
            var raw = await _AuctionRepository.GetAsync(x => x.Id == auctionId, includePropeties: "Comments,ApplicationUser");
            if (raw == null)
            {
                throw new Exception("Auction not Found");
            }
            /*var userId = _userRepository.AuthenticatedUserId();
            var userRole = _userRepository.AuthenticatedUserRole().Trim();
            if (userId is null)
            {
                throw new UnauthorizedAccessException("Must be logged in to update state of topic");
            }
            if (raw.UserId.Trim() != userId && userRole != "Admin")
            {
                throw new InvalidUserException("Can't delete different users topic");
            }*/
            else
            {
                _AuctionRepository.Remove(raw);
                await _AuctionRepository.Save();
            }
        }
        public async Task UpdateAuctionAsyncSeller(Guid auctionId, AuctionForUpdatingDtoSeller auctionForUpdatingDtoSeller)
        {
            if (auctionForUpdatingDtoSeller is null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }
            /*var authenticatedId = _userRepository.AuthenticatedUserId();
            if (authenticatedId is null)
            {
                throw new UnauthorizedAccessException("Must be logged in to update Topic");
            }*/
            var auctionFromDb = await _AuctionRepository.GetAsync(x => x.Id == auctionId);
            if (auctionFromDb is null)
            {
                throw new Exception("Auction not Found");
            }            
            /*if (auctionFromDb.UserId != authenticatedId)
            {
                throw new UnauthorizedAccessException("Can't update another users topic");
            }*/
            var updatedAuction = _mapper.Map<Auction>(auctionForUpdatingDtoSeller);
            updatedAuction.Id = auctionId;
            await _AuctionRepository.Update(updatedAuction);
            await _AuctionRepository.Save();
        }


    }
}
