using CarAuctionEntities.Constants.Enums;

namespace CarAuctionEntities.Entities
{
    public class AuctionItem : BaseEntity
    {
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string VinCode { get; set; } = null!;
        public ushort Year { get; set; }
        public string Color { get; set; } = null!;
        public string Odometer { get; set; } = null!;
        public string EngineType { get; set; } = null!;
        public byte Cylinders { get; set; } = 0!;
        public Transmission Transmission { get; set; }
        public Drive Drive { get; set; }
        public FuelType FuelType { get; set; }
        //false = left
        public bool Wheel { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}