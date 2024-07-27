using CarAuctionApplication.Models.Main.Dtos.Bid;

namespace CarAuctionApplication.Contracts.IServices
{
    public interface IBidService
    {
        Task AddAmount(Guid auctionId,AddBidDto addBidDto);
        Task DeleteBid(Guid bidId);
    }
}
