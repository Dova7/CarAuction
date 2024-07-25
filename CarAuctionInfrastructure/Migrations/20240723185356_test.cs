using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caca4ca5-964c-4174-9eb5-f92422bc5e7d", "AQAAAAIAAYagAAAAEDceatcw+HZwZ0HrYe6Lsus6qjkQWSiIPwVJyEPqVsrSJ+MY4h8ZGsYZDk8lv+BYjg==", "89a7e90b-912e-4e7d-b2cc-530b80f3a69a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64cd2eb5-18a7-48e6-8cb0-6ef4b0974255", "AQAAAAIAAYagAAAAEK8EIPe75PI1AQ+Wfax7yH5dLigvM5D8lR/t/bEPSiSLpuXUTGnhwUyorewZZRVt/A==", "36c5c9e7-b957-4a07-89ce-48c191ac557f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47efd73c-2a4b-414e-8aad-e62370972e84", "AQAAAAIAAYagAAAAEOvQYXyPyCbJqd46p5doiRMoynpdYIDAg9D9UJr+K0R5HyM0QtuHJqe2EeYZ2bW/JA==", "73cccebb-8a15-402d-b87d-7d7152480212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53701346-B101-491E-8D0E-9FBD75B388AE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bdc7b3e-d166-42b3-8e07-d0dd24eea307", "AQAAAAIAAYagAAAAECzO4vShZFtoadtw6MVSBYzfFyLwChWmgLNA7CDPdjTlU1wa85wOD5w0c6a4iUP35Q==", "ef79fb09-8de2-4c29-b2c1-ef93d693b10b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87073272-5331-449A-B99A-32F71D0DD7DC",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34ae24f4-61b2-4d90-b5d3-ab10d9c6093e", "AQAAAAIAAYagAAAAEEHRAw8e50ew8d2i5DiTJ06a/Bnik7fDXQ4ui7HP6J06NbdaEp9jBjWfU2mOuGU+Ww==", "00ad6c9e-899b-4312-9ac4-3508b98341c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D29F8763-846A-43B6-B6AE-3142395D355A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9396e768-179d-41ab-af00-88fc622cad4d", "AQAAAAIAAYagAAAAEH8oxQbypxNyldfcgVSnTtAmHAT4umE9TKchuApCyj3wjxEouu082tcwUcoHOqEw8A==", "b49fb241-9cc3-4419-8b1b-e0a37633e751" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                columns: new[] { "AuctionEnd", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 20, 32, 43, 961, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 7, 7, 20, 32, 43, 961, DateTimeKind.Local).AddTicks(5931), new DateTime(2024, 7, 22, 20, 32, 43, 961, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                columns: new[] { "AuctionEnd", "CreatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 20, 32, 43, 961, DateTimeKind.Local).AddTicks(5919), new DateTime(2024, 7, 22, 20, 32, 43, 961, DateTimeKind.Local).AddTicks(5906) });
        }
    }
}
