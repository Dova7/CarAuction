using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CascadeFixImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionItemImages_AuctionItems_AuctionItemId",
                table: "AuctionItemImages");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionItemImages_AuctionItems_AuctionItemId",
                table: "AuctionItemImages",
                column: "AuctionItemId",
                principalTable: "AuctionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionItemImages_AuctionItems_AuctionItemId",
                table: "AuctionItemImages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d345a9b-9a19-4b6c-90e2-dd41a1046744", "AQAAAAIAAYagAAAAEO3Slw5JyJgyHHfmk7/Fjwh7RUoUshS8PqgP/pNgB1Oe5vUIfPNzl0akJjT1gdCjIw==", "72381cec-4240-4e2a-847f-8c9ed7482a57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b596ebe0-a615-4fe6-b209-2167c0031d2c", "AQAAAAIAAYagAAAAEKgqVaxcoF5ETx2f8mNtHt5ATb1jtcT8DlOofn+nhQlACcPtFXif2dl4A4N1Eg67FA==", "f9ac311c-863e-4891-a4ea-6375ac5179db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb800004-b97d-4174-83aa-85d06a33eccc", "AQAAAAIAAYagAAAAEEfF3kRFo9+yz83tLWkRqup9l07CTJek2/jTGH0aTQxUl2M+PeGkG0zPNFsd6V/j8w==", "50e8b545-a560-42b1-b870-8dcaf596534e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53701346-B101-491E-8D0E-9FBD75B388AE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de4d6f5e-fb79-4f14-b1c5-94d9c80c7e01", "AQAAAAIAAYagAAAAEG3JdjeRBdc1Nljy3bZpswE8KB0gzNJJZv3UyJpnLGHNt2yFEOg9jNgYw0e0qRYTOg==", "ea4e337e-476a-49e2-bc29-62b6eac44542" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87073272-5331-449A-B99A-32F71D0DD7DC",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cd83438-5d03-403c-9df3-9fa157c40d32", "AQAAAAIAAYagAAAAEOOzPewUjF+GvWRLZxUn/1yhL7EwWsHlkbTBRvxlA6Pk67gOeWiM7XALfArdgu1j9Q==", "df6217dd-d601-4e1f-8785-c7985e6b7b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D29F8763-846A-43B6-B6AE-3142395D355A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23fef181-4064-4caa-bb93-f237c1d72959", "AQAAAAIAAYagAAAAEE+vdChew8MkAh+Nk/vTM/NHwuNvlWS9c+By89vjSlh0OiUNcmC2YU5BCgCoFt+OWA==", "0257fdf5-0be8-4366-9a99-15146808f203" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                columns: new[] { "AuctionEnd", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 7, 7, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 7, 22, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                columns: new[] { "AuctionEnd", "CreatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 7, 22, 20, 31, 25, 568, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionItemImages_AuctionItems_AuctionItemId",
                table: "AuctionItemImages",
                column: "AuctionItemId",
                principalTable: "AuctionItems",
                principalColumn: "Id");
        }
    }
}
