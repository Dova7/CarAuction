using CarAuctionEntities.Constants.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CarAuctionEntities.Entities.Identity;

namespace CarAuctionEntities.Entities
{
    public class Auction : BaseEntity
    {
        public uint ReservePrice { get; set; } = 0;        
        public uint? SoldAmount { get; set; }
        public uint? CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; }

        [Required]
        [ForeignKey(nameof(AuctionItem))]
        public Guid AuctionItemId { get; set; }
        public AuctionItem AuctionItem { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string SellerId { get; set; } = null!;
        public ApplicationUser Seller { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string? WinnerId { get; set; }
        public ApplicationUser? Winner { get; set; }
    }
}
