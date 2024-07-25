using CarAuctionDomain.Entities;
using CarAuctionDomain.Entities.Bidding;
using CarAuctionEntities.Entities;
using CarAuctionEntities.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionInfrastructure.Data
{
    public class CarAuctionDbContext : IdentityDbContext<ApplicationUser>
    {
        public CarAuctionDbContext(DbContextOptions<CarAuctionDbContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AuctionConstraints();
            modelBuilder.AuctionItemConstraints();
            modelBuilder.ApplicationUserConstraints();
            modelBuilder.AuctionItemImageConstraints();
            modelBuilder.AuctionItemAdditionalPropertiesConstraints();
            modelBuilder.BidConstraints();

            modelBuilder.SeedRoles();
            modelBuilder.SeedUsers();
            modelBuilder.SeedUserRoles();

            modelBuilder.SeedAuction();
            modelBuilder.SeedAuctionItem();
        }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<AuctionItem> AuctionItems { get; set; }
        public DbSet<AuctionItemImage> AuctionItemImages { get; set; }
        public DbSet<AuctionItemAdditionalProperties> AuctionItemAdditionalProperties { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}
