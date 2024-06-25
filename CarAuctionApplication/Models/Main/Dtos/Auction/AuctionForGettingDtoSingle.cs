using CarAuctionApplication.Models.Main.Dtos.CarAuctionItem;
using CarAuctionEntities.Constants.Enums;

namespace CarAuctionApplication.Models.Main.Dtos.CarAuction
{
    public class AuctionForGettingDtoSingle
    {
        public uint ReservePrice { get; set; } = 0;
        public uint? SoldAmount { get; set; }
        public uint? CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; } = Status.Live;

        public AuctioinItemForGettingDtoSingle AuctionItem { get; set; } = null!;
    }
}
