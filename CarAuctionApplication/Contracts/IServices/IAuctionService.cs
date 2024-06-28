using CarAuctionApplication.Models.Main.Dtos.CarAuction;

namespace CarAuctionApplication.Contracts.IServices
{
    public interface IAuctionService
    {
        Task<List<AuctionForGettingDtoAllLive>> GetAllLiveAuctionsAsync();
        Task<AuctionForGettingDtoSingle> GetSingleAuctionAsync(Guid id);
    }
}
