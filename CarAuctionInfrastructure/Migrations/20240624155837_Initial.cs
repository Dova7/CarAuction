using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarAuctionInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservePrice = table.Column<long>(type: "bigint", nullable: false),
                    SoldAmount = table.Column<long>(type: "bigint", nullable: true),
                    CurrentHighBid = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuctionEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WinnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auctions_AspNetUsers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auctions_AspNetUsers_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuctionItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Odometer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cylinders = table.Column<byte>(type: "tinyint", nullable: false),
                    Transmission = table.Column<int>(type: "int", nullable: false),
                    Drive = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<int>(type: "int", nullable: false),
                    Wheel = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionItems", x => x.Id);
                    table.CheckConstraint("CK_AuctionItem_Year_NotFuture", "[Year] <= YEAR(GETDATE()) + 1");
                    table.ForeignKey(
                        name: "FK_AuctionItems_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuctionItemAdditionalProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdditionalProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuctionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionItemAdditionalProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionItemAdditionalProperties_AuctionItems_AuctionItemId",
                        column: x => x.AuctionItemId,
                        principalTable: "AuctionItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuctionItemImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    AuctionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionItemImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionItemImages_AuctionItems_AuctionItemId",
                        column: x => x.AuctionItemId,
                        principalTable: "AuctionItems",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "641BFCED-C522-4181-AD3A-CD86201A35F1", null, "SuperAdmin", "SUPERADMIN" },
                    { "A794DC1F-5B52-428C-A09A-D5BD17000991", null, "Admin", "ADMIN" },
                    { "C3C7D916-DA41-445E-A535-F46F4DB3D84C", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1365FCBA-5EBF-45B9-B67C-11DC33B91B12", 0, "3ef7673e-8571-4336-8c32-b2df16c1ab17", "MAINADMIN", "MAINADMIN@gmail.com", true, "MAINADMIN", "MAINADMIN", true, null, "MAINADMIN@GMAIL.COM", "MAINADMIN", "AQAAAAIAAYagAAAAEEA3ThslhyKMJgez54wmVrwL2zm3DXc/gaf+9zVORlG2JX9iJk12bQGm+av7mF90FQ==", "555337681", false, "c69a553a-7b64-4c5e-9261-344559f353d8", false, "MAINADMIN" },
                    { "1CF16252-E7F5-45DF-941A-88B7A592F9C7", 0, "f11de9ab-aff8-45c5-9ff9-0cfe65bc8a0b", "Gogi", "gogi@gmail.com", false, "Gogi", "Gogishvili", true, null, "GOGI@GMAIL.COM", "GOGIGOGI", "AQAAAAIAAYagAAAAEIWeblDZA7TwROtUBanIlJHmzdbQ+KROfa+EewqLQE9S1eDw1q6z1+dRO6fMY0HMTA==", "551252560", false, "6e431e10-2753-4983-8039-72333a9bbf0d", false, "gogigogi" },
                    { "44DC07F7-DD89-435E-8E67-AB46C799F3F2", 0, "fa83b31c-6c62-42c4-8b7d-defaa7b33f90", "Giga", "giga@gmail.com", false, "Giga", "Gigauri", true, null, "GIGA@GMAIL.COM", "GIGAGIGA", "AQAAAAIAAYagAAAAEEcL2EdSmoHsh6+59npWo8j9aSMIayaC8y5ILPrZCgQqL3uLy3ebBWvQZapaV++1Tw==", "599391269", false, "ebad01a3-aac1-4d86-aff9-22cd9d9b03f9", false, "gigagiga" },
                    { "53701346-B101-491E-8D0E-9FBD75B388AE", 0, "a223f3f7-cf24-46cf-a629-ee251b97c824", "Admin", "Admin@gmail.com", true, "Admin", "Admin", true, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELDDm1g/K1XlY8qN0lFifNA9fu6SKxyBSSeU6B2BakqiadqAil2K8v/GH6/p4R6oRQ==", "525531620", false, "79688907-d577-4b3b-af58-f7a01338fa06", false, "Admin" },
                    { "87073272-5331-449A-B99A-32F71D0DD7DC", 0, "3d0e783b-4545-4ac4-9c9b-2b6c7f4d55a7", "Beqa", "beqa@gmail.com", false, "Beqa", "Beqauri", true, null, "BEQA@GMAIL.COM", "BEQABEQA", "AQAAAAIAAYagAAAAELKiGmB0TXhOduIPit3GZfpeZD4qf6bgRoh9IP4BAPOPmkiEagBq3h2UhVjScuQCqQ==", "521112550", false, "009eefb6-5f84-489a-bf0f-ee239dd9210a", false, "beqabeqa" },
                    { "D29F8763-846A-43B6-B6AE-3142395D355A", 0, "706b11a3-d3cd-4c38-848a-d57bb2bf9cee", "Gio", "gio@gmail.com", false, "Giorgi", "Giorgadze", true, null, "GIO@GMAIL.COM", "GIOGIO", "AQAAAAIAAYagAAAAEDY9oq80inYoR2Fa3bm0qFaWnB1hiWMKLU2mt/T54RPkvDbSXHY4cfdOaWAo4lsiaA==", "507731029", false, "4bc73f88-830d-46cf-873b-89c2c799d14f", false, "giogio" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "641BFCED-C522-4181-AD3A-CD86201A35F1", "1365FCBA-5EBF-45B9-B67C-11DC33B91B12" },
                    { "C3C7D916-DA41-445E-A535-F46F4DB3D84C", "1CF16252-E7F5-45DF-941A-88B7A592F9C7" },
                    { "C3C7D916-DA41-445E-A535-F46F4DB3D84C", "44DC07F7-DD89-435E-8E67-AB46C799F3F2" },
                    { "A794DC1F-5B52-428C-A09A-D5BD17000991", "53701346-B101-491E-8D0E-9FBD75B388AE" },
                    { "C3C7D916-DA41-445E-A535-F46F4DB3D84C", "87073272-5331-449A-B99A-32F71D0DD7DC" },
                    { "C3C7D916-DA41-445E-A535-F46F4DB3D84C", "D29F8763-846A-43B6-B6AE-3142395D355A" }
                });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "Id", "AuctionEnd", "CreatedAt", "CurrentHighBid", "ReservePrice", "SellerId", "SoldAmount", "Status", "UpdatedAt", "WinnerId" },
                values: new object[,]
                {
                    { new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"), new DateTime(2024, 6, 25, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7905), new DateTime(2024, 6, 9, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7901), 32500L, 30000L, "1CF16252-E7F5-45DF-941A-88B7A592F9C7", 32500L, 2, new DateTime(2024, 6, 24, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7901), "D29F8763-846A-43B6-B6AE-3142395D355A" },
                    { new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"), new DateTime(2024, 7, 24, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 6, 24, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7875), 8000L, 9500L, "87073272-5331-449A-B99A-32F71D0DD7DC", null, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "AuctionItems",
                columns: new[] { "Id", "AuctionId", "Color", "Cylinders", "Drive", "EngineType", "FuelType", "MainImageUrl", "Make", "Model", "Notes", "Odometer", "Transmission", "VinCode", "Wheel", "Year" },
                values: new object[,]
                {
                    { new Guid("050e9044-8bf3-4999-b2f6-cf5c5065bb96"), new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"), "White", (byte)4, 1, "1.8", 4, null, "Lexus", "CT200 F Sport", " ", "145600 k", 3, " ", 2, 2015 },
                    { new Guid("22fee0f9-1fee-4d5e-ab00-322c5f9f7058"), new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"), "Purple", (byte)6, 2, "3.0", 1, null, "Toyota", "Supra", " ", "345980 k", 1, " ", 2, 1997 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionItemAdditionalProperties_AuctionItemId",
                table: "AuctionItemAdditionalProperties",
                column: "AuctionItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionItemImages_AuctionItemId",
                table: "AuctionItemImages",
                column: "AuctionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionItems_AuctionId",
                table: "AuctionItems",
                column: "AuctionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_SellerId",
                table: "Auctions",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_WinnerId",
                table: "Auctions",
                column: "WinnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuctionItemAdditionalProperties");

            migrationBuilder.DropTable(
                name: "AuctionItemImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AuctionItems");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
