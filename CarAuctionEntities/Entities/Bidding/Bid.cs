using CarAuctionDomain.Constants.Enums.Bidding;
using CarAuctionEntities.Entities;

namespace CarAuctionDomain.Entities.Bidding
{
    public class Bid : BaseEntity
    {
        public DateTime BidTime { get; set; } = DateTime.Now;
        public uint BidAmount { get; set; } = 0!;
        public BidStatus Status { get; set; }

        public Guid AuctionId { get; set; }
        public Auction Auction { get; set; } = null!;
    }
}
