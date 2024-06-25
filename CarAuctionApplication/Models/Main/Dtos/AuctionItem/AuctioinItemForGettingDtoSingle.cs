using CarAuctionApplication.Models.Main.Dtos.CarAuctionItemAdditionalProperties;
using CarAuctionApplication.Models.Main.Dtos.CarAuctionItemImage;
using CarAuctionDomain.Constants.Enums;
using CarAuctionEntities.Constants.Enums;

namespace CarAuctionApplication.Models.Main.Dtos.CarAuctionItem
{
    public class AuctioinItemForGettingDtoSingle
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

        public virtual ICollection<AuctionItemImageForGettingDtoSingle>? Images { get; set; }
        public AuctionAddPropertiesForGettingDtoSingle? AdditionalProperties { get; set; }
    }
}
