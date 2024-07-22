﻿// <auto-generated />
using System;
using CarAuctionInfrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarAuctionInfrastructure.Migrations
{
    [DbContext(typeof(CarAuctionDbContext))]
    [Migration("20240722163126_CascadeFix2")]
    partial class CascadeFix2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarAuctionDomain.Entities.AuctionItemAdditionalProperties", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AuctionItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AuctionItemId")
                        .IsUnique();

                    b.ToTable("AuctionItemAdditionalProperties");
                });

            modelBuilder.Entity("CarAuctionDomain.Entities.AuctionItemImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuctionItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("AuctionItemId");

                    b.ToTable("AuctionItemImages");
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.Auction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AuctionEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CurrentHighBid")
                        .HasColumnType("bigint");

                    b.Property<long>("ReservePrice")
                        .HasColumnType("bigint");

                    b.Property<string>("SellerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("SoldAmount")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("WinnerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Auctions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                            AuctionEnd = new DateTime(2024, 8, 21, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9430),
                            CreatedAt = new DateTime(2024, 7, 22, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9413),
                            CurrentHighBid = 8000L,
                            ReservePrice = 9500L,
                            SellerId = "87073272-5331-449A-B99A-32F71D0DD7DC",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                            AuctionEnd = new DateTime(2024, 7, 23, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9447),
                            CreatedAt = new DateTime(2024, 7, 7, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9443),
                            CurrentHighBid = 32500L,
                            ReservePrice = 30000L,
                            SellerId = "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                            SoldAmount = 32500L,
                            Status = 2,
                            UpdatedAt = new DateTime(2024, 7, 22, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9444),
                            WinnerId = "D29F8763-846A-43B6-B6AE-3142395D355A"
                        });
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.AuctionItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Cylinders")
                        .HasColumnType("tinyint");

                    b.Property<int>("Drive")
                        .HasColumnType("int");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<string>("MainImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notes")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Odometer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<string>("VinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wheel")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId")
                        .IsUnique();

                    b.ToTable("AuctionItems", t =>
                        {
                            t.HasCheckConstraint("CK_AuctionItem_Year_NotFuture", "[Year] <= YEAR(GETDATE()) + 1");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("050e9044-8bf3-4999-b2f6-cf5c5065bb96"),
                            AuctionId = new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                            Color = "White",
                            Cylinders = (byte)4,
                            Drive = 1,
                            EngineType = "1.8",
                            FuelType = 4,
                            Make = "Lexus",
                            Model = "CT200 F Sport",
                            Notes = " ",
                            Odometer = "145600 k",
                            Transmission = 3,
                            VinCode = " ",
                            Wheel = 2,
                            Year = 2015
                        },
                        new
                        {
                            Id = new Guid("22fee0f9-1fee-4d5e-ab00-322c5f9f7058"),
                            AuctionId = new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                            Color = "Purple",
                            Cylinders = (byte)6,
                            Drive = 2,
                            EngineType = "3.0",
                            FuelType = 1,
                            Make = "Toyota",
                            Model = "Supra",
                            Notes = " ",
                            Odometer = "345980 k",
                            Transmission = 1,
                            VinCode = " ",
                            Wheel = 2,
                            Year = 1997
                        });
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7d345a9b-9a19-4b6c-90e2-dd41a1046744",
                            DisplayName = "MAINADMIN",
                            Email = "MAINADMIN@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "MAINADMIN",
                            LastName = "MAINADMIN",
                            LockoutEnabled = true,
                            NormalizedEmail = "MAINADMIN@GMAIL.COM",
                            NormalizedUserName = "MAINADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEO3Slw5JyJgyHHfmk7/Fjwh7RUoUshS8PqgP/pNgB1Oe5vUIfPNzl0akJjT1gdCjIw==",
                            PhoneNumber = "555337681",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72381cec-4240-4e2a-847f-8c9ed7482a57",
                            TwoFactorEnabled = false,
                            UserName = "MAINADMIN"
                        },
                        new
                        {
                            Id = "53701346-B101-491E-8D0E-9FBD75B388AE",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de4d6f5e-fb79-4f14-b1c5-94d9c80c7e01",
                            DisplayName = "Admin",
                            Email = "Admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEG3JdjeRBdc1Nljy3bZpswE8KB0gzNJJZv3UyJpnLGHNt2yFEOg9jNgYw0e0qRYTOg==",
                            PhoneNumber = "525531620",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea4e337e-476a-49e2-bc29-62b6eac44542",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "D29F8763-846A-43B6-B6AE-3142395D355A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "23fef181-4064-4caa-bb93-f237c1d72959",
                            DisplayName = "Gio",
                            Email = "gio@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Giorgi",
                            LastName = "Giorgadze",
                            LockoutEnabled = true,
                            NormalizedEmail = "GIO@GMAIL.COM",
                            NormalizedUserName = "GIOGIO",
                            PasswordHash = "AQAAAAIAAYagAAAAEE+vdChew8MkAh+Nk/vTM/NHwuNvlWS9c+By89vjSlh0OiUNcmC2YU5BCgCoFt+OWA==",
                            PhoneNumber = "507731029",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0257fdf5-0be8-4366-9a99-15146808f203",
                            TwoFactorEnabled = false,
                            UserName = "giogio"
                        },
                        new
                        {
                            Id = "87073272-5331-449A-B99A-32F71D0DD7DC",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7cd83438-5d03-403c-9df3-9fa157c40d32",
                            DisplayName = "Beqa",
                            Email = "beqa@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Beqa",
                            LastName = "Beqauri",
                            LockoutEnabled = true,
                            NormalizedEmail = "BEQA@GMAIL.COM",
                            NormalizedUserName = "BEQABEQA",
                            PasswordHash = "AQAAAAIAAYagAAAAEOOzPewUjF+GvWRLZxUn/1yhL7EwWsHlkbTBRvxlA6Pk67gOeWiM7XALfArdgu1j9Q==",
                            PhoneNumber = "521112550",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "df6217dd-d601-4e1f-8785-c7985e6b7b53",
                            TwoFactorEnabled = false,
                            UserName = "beqabeqa"
                        },
                        new
                        {
                            Id = "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb800004-b97d-4174-83aa-85d06a33eccc",
                            DisplayName = "Giga",
                            Email = "giga@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Giga",
                            LastName = "Gigauri",
                            LockoutEnabled = true,
                            NormalizedEmail = "GIGA@GMAIL.COM",
                            NormalizedUserName = "GIGAGIGA",
                            PasswordHash = "AQAAAAIAAYagAAAAEEfF3kRFo9+yz83tLWkRqup9l07CTJek2/jTGH0aTQxUl2M+PeGkG0zPNFsd6V/j8w==",
                            PhoneNumber = "599391269",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "50e8b545-a560-42b1-b870-8dcaf596534e",
                            TwoFactorEnabled = false,
                            UserName = "gigagiga"
                        },
                        new
                        {
                            Id = "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b596ebe0-a615-4fe6-b209-2167c0031d2c",
                            DisplayName = "Gogi",
                            Email = "gogi@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Gogi",
                            LastName = "Gogishvili",
                            LockoutEnabled = true,
                            NormalizedEmail = "GOGI@GMAIL.COM",
                            NormalizedUserName = "GOGIGOGI",
                            PasswordHash = "AQAAAAIAAYagAAAAEKgqVaxcoF5ETx2f8mNtHt5ATb1jtcT8DlOofn+nhQlACcPtFXif2dl4A4N1Eg67FA==",
                            PhoneNumber = "551252560",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9ac311c-863e-4891-a4ea-6375ac5179db",
                            TwoFactorEnabled = false,
                            UserName = "gogigogi"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "641BFCED-C522-4181-AD3A-CD86201A35F1",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "A794DC1F-5B52-428C-A09A-D5BD17000991",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "C3C7D916-DA41-445E-A535-F46F4DB3D84C",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                            RoleId = "641BFCED-C522-4181-AD3A-CD86201A35F1"
                        },
                        new
                        {
                            UserId = "53701346-B101-491E-8D0E-9FBD75B388AE",
                            RoleId = "A794DC1F-5B52-428C-A09A-D5BD17000991"
                        },
                        new
                        {
                            UserId = "D29F8763-846A-43B6-B6AE-3142395D355A",
                            RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C"
                        },
                        new
                        {
                            UserId = "87073272-5331-449A-B99A-32F71D0DD7DC",
                            RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C"
                        },
                        new
                        {
                            UserId = "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                            RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C"
                        },
                        new
                        {
                            UserId = "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                            RoleId = "C3C7D916-DA41-445E-A535-F46F4DB3D84C"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarAuctionDomain.Entities.AuctionItemAdditionalProperties", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.AuctionItem", "AuctionItem")
                        .WithOne("AdditionalProperties")
                        .HasForeignKey("CarAuctionDomain.Entities.AuctionItemAdditionalProperties", "AuctionItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuctionItem");
                });

            modelBuilder.Entity("CarAuctionDomain.Entities.AuctionItemImage", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.AuctionItem", "AuctionItem")
                        .WithMany("Images")
                        .HasForeignKey("AuctionItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AuctionItem");
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.Auction", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.Identity.ApplicationUser", "Seller")
                        .WithMany("Auctions")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarAuctionEntities.Entities.Identity.ApplicationUser", "Winner")
                        .WithMany("Winnings")
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Seller");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.AuctionItem", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.Auction", "Auction")
                        .WithOne("AuctionItem")
                        .HasForeignKey("CarAuctionEntities.Entities.AuctionItem", "AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarAuctionEntities.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarAuctionEntities.Entities.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.Auction", b =>
                {
                    b.Navigation("AuctionItem")
                        .IsRequired();
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.AuctionItem", b =>
                {
                    b.Navigation("AdditionalProperties");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("CarAuctionEntities.Entities.Identity.ApplicationUser", b =>
                {
                    b.Navigation("Auctions");

                    b.Navigation("Winnings");
                });
#pragma warning restore 612, 618
        }
    }
}
