using CarAuctionApplication.Models.Main.Dtos.Bid;

namespace CarAuctionApplication.Contracts.IServices
{
    public interface IBidService
    {
        Task AddAmountAsync(Guid auctionId,AddBidDto addBidDto);
        Task DeleteBidAsync(Guid bidId);
    }
}
