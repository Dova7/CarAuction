using CarAuctionApplication.Models.Main.Dtos.AuctionItemAdditionalProperties;
using CarAuctionApplication.Models.Main.Dtos.AuctionItemImage;
using CarAuctionDomain.Constants.Enums;
using CarAuctionEntities.Constants.Enums;

namespace CarAuctionApplication.Models.Main.Dtos.AuctionItem
{
    public class AuctionItemForUpdatingDto
    {
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string? VinCode { get; set; }
        public ushort Year { get; set; }
        public string Color { get; set; } = null!;
        public string Odometer { get; set; } = null!;
        public string EngineType { get; set; } = null!;
        public byte Cylinders { get; set; } = 0!;
        public Transmission Transmission { get; set; }
        public Drive Drive { get; set; }
        public FuelType FuelType { get; set; }
        public Wheel Wheel { get; set; }
        public string? Notes { get; set; }
        public string? MainImageUrl { get; set; }

        public AuctionItemPropertiesForUpdatingDto? AdditionalProperties { get; set; }
        public ICollection<AuctionItemImageForUpdatingDto>? Images { get; set; }
    }
}
