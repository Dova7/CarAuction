using CarAuctionApplication.Models.Main.Dtos.Auction;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;

namespace CarAuctionApplication.Contracts.IServices
{
    public interface IAuctionService
    {
        Task<List<AuctionForGettingDtoAllLive>> GetAllLiveAuctionsAsync();
        Task<AuctionForGettingDtoSingle> GetSingleAuctionAsync(Guid id);
        Task CreateAuctionAsync(AuctionForCreatingDto auctionForCreatingDto);
        Task UpdateAuctionAsyncSeller(Guid auctionId, AuctionForUpdatingDtoSeller auctionForUpdatingDtoSeller);
        Task DeleteAuctionAsync(Guid auctionId);
    }
}
