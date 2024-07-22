using CarAuctionApplication.Models.Main.Dtos.AuctionItem;
using CarAuctionEntities.Constants.Enums;

namespace CarAuctionApplication.Models.Main.Dtos.Auction
{
    public class AuctionForUpdatingDtoSeller
    {
        public uint ReservePrice { get; set; } = 0;        
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; }

        public AuctionItemForUpdatingDto AuctionItem { get; set; } = null!;
    }
}
