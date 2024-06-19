using Microsoft.AspNetCore.Identity;

namespace CarAuctionEntities.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ICollection<Auction>? Auctions { get; set; }
    }
}
