namespace CarAuctionApplication.Models.Main.Dtos.CarAuction
{
    public class AuctionForGettingDtoAllLive
    {
        public Guid Id { get; set; }
        public uint ReservePrice { get; set; } = 0!;
        public uint? CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime AuctionEnd { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public ushort Year { get; set; }
        public string? MainImageUrl { get; set; }
    }
}
