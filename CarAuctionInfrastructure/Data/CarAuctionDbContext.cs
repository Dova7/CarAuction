using CarAuctionEntities.Entities;
using CarAuctionEntities.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionInfrastructure.Data
{
    public class CarAuctionDbContext : IdentityDbContext<ApplicationUser>
    {
        public CarAuctionDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<AuctionItem> AuctionItems { get; set; }
    }
}
