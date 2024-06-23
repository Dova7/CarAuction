using CarAuctionDomain.Constants.Enums;
using CarAuctionEntities.Constants.Enums;
using CarAuctionEntities.Entities;
using CarAuctionEntities.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionInfrastructure.Data
{
    public static class DataSeeder
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "641BFCED-C522-4181-AD3A-CD86201A35F1", Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                new IdentityRole { Id = "A794DC1F-5B52-428C-A09A-D5BD17000991", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "C3C7D916-DA41-445E-A535-F46F4DB3D84C", Name = "User", NormalizedName = "USER" }
            );
        }
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            PasswordHasher<ApplicationUser> hasher = new();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser()
                {
                    Id = "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                    FirstName = "MAINADMIN",
                    LastName = "MAINADMIN",
                    DisplayName = "MAINADMIN",
                    Email = "MAINADMIN@gmail.com",
                    UserName = "MAINADMIN",
                    NormalizedEmail = "MAINADMIN@GMAIL.COM",
                    NormalizedUserName = "MAINADMIN",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "MainAdmin123!"),
                    PhoneNumber = "555337681",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                },
                new ApplicationUser()
                {
                    Id = "53701346-B101-491E-8D0E-9FBD75B388AE",
                    FirstName = "Admin",
                    LastName = "Admin",
                    DisplayName = "Admin",
                    Email = "Admin@gmail.com",
                    UserName = "Admin",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    NormalizedUserName = "ADMIN",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null!, "Admin123!"),
                    PhoneNumber = "525531620",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                },
                new ApplicationUser()
                {
                    Id = "D29F8763-846A-43B6-B6AE-3142395D355A",
                    FirstName = "Giorgi",
                    LastName = "Giorgadze",
                    DisplayName = "Gio",
                    Email = "gio@gmail.com",
                    UserName = "giogio",
                    NormalizedEmail = "GIO@GMAIL.COM",
                    NormalizedUserName = "GIOGIO",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null!, "Gio123!"),
                    PhoneNumber = "507731029",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                },
                new ApplicationUser()
                {
                    Id = "87073272-5331-449A-B99A-32F71D0DD7DC",
                    FirstName = "Beqa",
                    LastName = "Beqauri",
                    DisplayName = "Beqa",
                    Email = "beqa@gmail.com",
                    UserName = "beqabeqa",
                    NormalizedEmail = "BEQA@GMAIL.COM",
                    NormalizedUserName = "BEQABEQA",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null!, "Beqa123!"),
                    PhoneNumber = "521112550",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                },
                new ApplicationUser()
                {
                    Id = "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                    FirstName = "Giga",
                    LastName = "Gigauri",
                    DisplayName = "Giga",
                    Email = "giga@gmail.com",
                    UserName = "gigagiga",
                    NormalizedEmail = "GIGA@GMAIL.COM",
                    NormalizedUserName = "GIGAGIGA",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null!, "Giga123!"),
                    PhoneNumber = "599391269",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                },
                new ApplicationUser()
                {
                    Id = "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                    FirstName = "Gogi",
                    LastName = "Gogishvili",
                    DisplayName = "Gogi",
                    Email = "gogi@gmail.com",
                    UserName = "gogigogi",
                    NormalizedEmail = "GOGI@GMAIL.COM",
                    NormalizedUserName = "GOGIGOGI",
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null!, "Gogi123!"),
                    PhoneNumber = "551252560",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                }
            );
        }
        public static void SeedUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "641BFCED-C522-4181-AD3A-CD86201A35F1", UserId = "1365FCBA-5EBF-45B9-B67C-11DC33B91B12" },
                new IdentityUserRole<string> { RoleId = "A794DC1F-5B52-428C-A09A-D5BD17000991", UserId = "53701346-B101-491E-8D0E-9FBD75B388AE" },
                new IdentityUserRole<string> { RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C", UserId = "D29F8763-846A-43B6-B6AE-3142395D355A" },
                new IdentityUserRole<string> { RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C", UserId = "87073272-5331-449A-B99A-32F71D0DD7DC" },
                new IdentityUserRole<string> { RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C", UserId = "44DC07F7-DD89-435E-8E67-AB46C799F3F2" },
                new IdentityUserRole<string> { RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C", UserId = "1CF16252-E7F5-45DF-941A-88B7A592F9C7" }

            );
        }
        public static void SeedAuctionItem(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuctionItem>().HasData(
                new AuctionItem()
                { 
                    Id = new Guid("050E9044-8BF3-4999-B2F6-CF5C5065BB96"),
                    Make = "Lexus",
                    Model = "CT200 F Sport",    
                    VinCode = " ",
                    Year = 2015,
                    Color = "White",
                    Odometer = "145600 k",
                    EngineType = "1.8",
                    Cylinders = 4,
                    Transmission = Transmission.Tiptronic,
                    Drive = Drive.FrontWheelDrive,
                    FuelType = FuelType.Hybrid,
                    Wheel = Wheel.Right,
                    Notes = " ",
                    AuctionId = new Guid("C21FEB91-5CBB-4F8A-884A-0597444E7BB2")
                },
                new AuctionItem()
                {
                    Id = new Guid("22FEE0F9-1FEE-4D5E-AB00-322C5F9F7058"),
                    Make = "Toyota",
                    Model = "Supra",
                    VinCode = " ",
                    Year = 1997,
                    Color = "Purple",
                    Odometer = "345980 k",
                    EngineType = "3.0",
                    Cylinders = 6,
                    Transmission = Transmission.Manual,
                    Drive = Drive.RearWheelDrive,
                    FuelType = FuelType.Petrol,
                    Wheel = Wheel.Right,
                    Notes = " ",
                    AuctionId = new Guid("851B5CB4-99BE-4E77-BFA6-8769D43C0F31")
                }
            );
        }
        public static void SeedAuction(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auction>().HasData(
                new Auction()
                {
                    Id = new Guid("C21FEB91-5CBB-4F8A-884A-0597444E7BB2"),
                    ReservePrice = 9500,
                    SoldAmount = null,
                    CurrentHighBid = 8000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    AuctionEnd = DateTime.Now.AddDays(30),
                    Status = Status.Live,
                    SellerId = "87073272-5331-449A-B99A-32F71D0DD7DC",
                    WinnerId = null,
                },
                new Auction()
                {
                    Id = new Guid("851B5CB4-99BE-4E77-BFA6-8769D43C0F31"),
                    ReservePrice = 30000,
                    SoldAmount = 32500,
                    CurrentHighBid = 32500,
                    CreatedAt = DateTime.Now.AddDays(-15),
                    UpdatedAt = DateTime.Now,
                    AuctionEnd = DateTime.Now.AddDays(1),
                    Status = Status.Finished,
                    SellerId = "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                    WinnerId = "D29F8763-846A-43B6-B6AE-3142395D355A",
                }
            );
        }
    }
}