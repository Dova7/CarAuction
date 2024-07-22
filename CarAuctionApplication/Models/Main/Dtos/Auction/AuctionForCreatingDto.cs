using CarAuctionApplication.Models.Main.Dtos.AuctionItem;

namespace CarAuctionApplication.Models.Main.Dtos.Auction
{
    public class AuctionForCreatingDto
    {
        public uint ReservePrice { get; set; } = 0;
        public DateTime AuctionEnd { get; set; }

        public AuctionItemForCreatingDto AuctionItem { get; set; } = null!;

    }
}
