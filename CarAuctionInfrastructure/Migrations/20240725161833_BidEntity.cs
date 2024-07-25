using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BidEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BidTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BidAmount = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AuctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bids_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8619d0fe-e6d6-4f60-85ff-235405b356d6", "AQAAAAIAAYagAAAAEHrkkTcv9wDaC/1dbrypJYS2Bk9Xw/1WowNbWlrhA1c2dJ2qrwBhxQwBuVeQWz29eA==", "5b2e474c-3722-4416-ac68-5d7be592d9cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0b6ef7b-e804-4127-a878-892ee4882d38", "AQAAAAIAAYagAAAAEHYaomYzr4DUmb3yJqw+9vrlWuKUx3+oJeHlz37Xb1aHOdQk02iBT6B7L0vWLpOD/A==", "b689f747-5c60-4a5c-9a7f-f5ee289274d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56f43647-70ad-434c-a4a0-290442dfc2b4", "AQAAAAIAAYagAAAAEN+T3ONKIix2nRbo6MT6rQ3b+Uh8It+CmhtuHsK8qu0Vtu/KnkFh5dAmUhCH+RAYUw==", "c02edf90-4429-4ba5-919c-554366e843db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53701346-B101-491E-8D0E-9FBD75B388AE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8b25111-7616-4b66-b551-6ef0f9ca847a", "AQAAAAIAAYagAAAAEFmUxrmGV4a8uWCaL775Oi976uKcAtFH4LakOIkD65odh0cemkghyE8szF2V0PmS1g==", "60aa6386-c6d6-4720-adb7-2218b12a498c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87073272-5331-449A-B99A-32F71D0DD7DC",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eeb4ba3-9aa1-4625-882a-c55863b04216", "AQAAAAIAAYagAAAAEBUNIvdHjZGU1ztYZ/mpNTOnUgOuxSimBYrSlVNWhekELqD/v0PeJH3P0Lf2jROP4Q==", "c9556c1c-8d82-48ca-96d5-a35ea4c88a24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D29F8763-846A-43B6-B6AE-3142395D355A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ce7104d-7754-4970-873b-b0e9217c04c1", "AQAAAAIAAYagAAAAEMwbkAcDX3XX6ZacMfCU33huj0l0l5/SS3ku+ddLV+a9AbeKQhutVXWvr/2GTrG3vw==", "071ebc41-5fc9-44b4-9c18-7baf430864ed" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                columns: new[] { "AuctionEnd", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 20, 18, 32, 304, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 7, 10, 20, 18, 32, 304, DateTimeKind.Local).AddTicks(6916), new DateTime(2024, 7, 25, 20, 18, 32, 304, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                columns: new[] { "AuctionEnd", "CreatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 20, 18, 32, 304, DateTimeKind.Local).AddTicks(6900), new DateTime(2024, 7, 25, 20, 18, 32, 304, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.CreateIndex(
                name: "IX_Bids_AuctionId",
                table: "Bids",
                column: "AuctionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e1e3526-ea25-4439-8799-3e56e6d198f2", "AQAAAAIAAYagAAAAEPMznZ7ppFqdhUlrpLOsdJyuf2/VZOyaRy/CXMBZTO9yTeD8a0tu6REp80acdRLoRg==", "ffdb67ab-0725-4da7-a873-55844a98cb7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b68ddcef-d0c6-41c1-bbb7-b95331eaf116", "AQAAAAIAAYagAAAAEO2Oeirv2y/D73dKvFpO653PjFn4Ds725XGq7u399yRrZuPTUSAc6nyV8s9sKqkaPw==", "3ee3c08d-9fc0-4f6b-9a83-b5cbf3f93fab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5934995e-3b30-4ea1-8b23-672931712209", "AQAAAAIAAYagAAAAEJW0XMgDTggwC1Pwk82+dlPGea4v2qQru3tO7cXcICM/z2ca7HY+8cNEfIM6BNWTMA==", "6dab6787-125e-4ec1-8bc6-2a6b5ce2a99e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53701346-B101-491E-8D0E-9FBD75B388AE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48371137-cda2-4afe-8d61-1a487906b0f4", "AQAAAAIAAYagAAAAELco406msG9BmjN9En9oq7TFK1lzdrbrtKtCo38i6VVuWY7HAvPzLYZEdLh/ZoD2CQ==", "353deb7e-0409-4219-96b0-7d361d326256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87073272-5331-449A-B99A-32F71D0DD7DC",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ce127ba-c969-4504-80d4-7d1e4c3dddfd", "AQAAAAIAAYagAAAAELOUqYOi7AKy2y6xa/fw93NQQhrjDCW3A7Ib3cXJk9G0980jaj7AyrPt2X37nkWAeA==", "c92bb2c0-43d1-478f-8c46-93cea4b09ec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D29F8763-846A-43B6-B6AE-3142395D355A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d08d900-94b8-4824-b9db-00b173a741dc", "AQAAAAIAAYagAAAAEJ3iV6jgoHp59rOHSfFP4e9yrHtXUsWonrCQn4mc9DutwXc63yoGhdg3PktZW7kUUw==", "84209eac-19fe-458e-be58-04c9f505d469" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                columns: new[] { "AuctionEnd", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 24, 22, 53, 55, 979, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 7, 8, 22, 53, 55, 979, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 7, 23, 22, 53, 55, 979, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                columns: new[] { "AuctionEnd", "CreatedAt" },
                values: new object[] { new DateTime(2024, 8, 22, 22, 53, 55, 979, DateTimeKind.Local).AddTicks(1845), new DateTime(2024, 7, 23, 22, 53, 55, 979, DateTimeKind.Local).AddTicks(1830) });
        }
    }
}
