using CarAuctionApplication.Models.Main.Dtos.Auction;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
using CarAuctionApplication.Models.QueryParameters;

namespace CarAuctionApplication.Contracts.IServices
{
    public interface IAuctionService
    {
        Task<List<AuctionForGettingDtoAll>> GetAllAuctionsAsync(AuctionQueryParameters queryParameters);
        //IQueryable<AuctionForGettingDtoAll> GetAllAuctionsQueryable();
        Task<AuctionForGettingDtoSingle> GetSingleAuctionAsync(Guid id);
        Task CreateAuctionAsync(AuctionForCreatingDto auctionForCreatingDto);
        Task UpdateAuctionAsyncSeller(Guid auctionId, AuctionForUpdatingDtoSeller auctionForUpdatingDtoSeller);
        Task DeleteAuctionAsync(Guid auctionId);
    }
}
