using CarAuctionEntities.Entities;

namespace CarAuctionDomain.Entities
{
    public class AuctionItemAdditionalProperties : BaseEntity
    {
        public string? AdditionalProperties { get; set; }

        public Guid AuctionItemId { get; set; }
        public AuctionItem AuctionItem { get; set; } = null!;
    }
}
