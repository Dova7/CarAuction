using CarAuctionEntities.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarAuctionDomain.Entities
{
    public class AuctionItemImage : BaseEntity
    {
        public string? ImageUrl { get; set; }

        public Guid AuctionItemId { get; set; }
        public AuctionItem AuctionItem { get; set; } = null!;
    }
}
