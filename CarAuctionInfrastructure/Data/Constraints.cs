using CarAuctionDomain.Entities;
using CarAuctionEntities.Entities;
using CarAuctionEntities.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionInfrastructure.Data
{
    public static class Constraints
    {
        public static void AuctionConstraints(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auction>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
                e.Property(x => x.AuctionEnd).IsRequired();
                //e.Property(x => x.AuctionItem).IsRequired();
                e.Property(x => x.SellerId).IsRequired();
            });
            modelBuilder.Entity<Auction>()
                .HasOne(x => x.AuctionItem)
                .WithOne(x => x.Auction)
                .HasForeignKey<AuctionItem>(x=> x.AuctionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Auction>()
                .HasOne(x => x.Seller)
                .WithMany(x => x.Auctions)
                .HasForeignKey(x => x.SellerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Auction>()
                .HasOne(x => x.Winner)
                .WithMany(x => x.Winnings)
                .HasForeignKey(x => x.WinnerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
        public static void AuctionItemConstraints(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionItem>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
                e.Property(x => x.Make).IsRequired().HasMaxLength(50);
                e.Property(x => x.Model).IsRequired().HasMaxLength(50);
                e.Property(x => x.Year).IsRequired();
                e.Property(x => x.Color).IsRequired();
                e.Property(x => x.Odometer).IsRequired();
                e.Property(x => x.Cylinders).IsRequired();
                e.Property(x => x.EngineType).IsRequired();
                e.Property(x => x.Transmission).IsRequired();
                e.Property(x => x.Drive).IsRequired();
                e.Property(x => x.FuelType).IsRequired();
                e.Property(x => x.Wheel).IsRequired();
                e.Property(x => x.Notes).HasMaxLength(1000);
            });
            modelBuilder.Entity<AuctionItem>()
                .ToTable(t => t.HasCheckConstraint("CK_AuctionItem_Year_NotFuture", "[Year] <= YEAR(GETDATE()) + 1"));

            modelBuilder.Entity<AuctionItem>()
                .HasOne(x => x.Auction)
                .WithOne(x => x.AuctionItem)
                .HasForeignKey<AuctionItem>(x => x.AuctionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AuctionItem>()
                .HasMany(x => x.Images)
                .WithOne(x => x.AuctionItem)
                .HasForeignKey(x => x.AuctionItemId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AuctionItem>()
                .HasOne(x => x.AdditionalProperties)
                .WithOne(x => x.AuctionItem)
                .HasForeignKey<AuctionItemAdditionalProperties>(x => x.AuctionItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public static void AuctionItemImageConstraints(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionItemImage>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
                e.Property(x => x.ImageUrl).HasMaxLength(2048);
            });
            modelBuilder.Entity<AuctionItemImage>()
                .HasOne(x => x.AuctionItem)
                .WithMany(x => x.Images)
                .HasForeignKey(x => x.AuctionItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public static void AuctionItemAdditionalPropertiesConstraints(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionItemAdditionalProperties>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<AuctionItemAdditionalProperties>()
                .HasOne(x => x.AuctionItem)
                .WithOne(x => x.AdditionalProperties)
                .HasForeignKey<AuctionItemAdditionalProperties>(x => x.AuctionItemId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public static void ApplicationUserConstraints(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ApplicationUser>().HasMany(x => x.Auctions).WithOne(x => x.Seller).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ApplicationUser>().HasMany(x => x.Winnings).WithOne(x => x.Winner).OnDelete(DeleteBehavior.NoAction);
        }
    }
}