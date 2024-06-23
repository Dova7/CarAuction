using CarAuctionEntities.Constants.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CarAuctionDomain.Entities;
using CarAuctionDomain.Constants.Enums;

namespace CarAuctionEntities.Entities
{
    public class AuctionItem : BaseEntity
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

        public Guid AuctionId { get; set; }
        public Auction Auction { get; set; } = null!;

        public virtual ICollection<AuctionItemImage>? Images { get; set; }

        public AuctionItemAdditionalProperties? AdditionalProperties { get; set; }
    }
}