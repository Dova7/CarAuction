using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CascadeFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionItemAdditionalProperties_AuctionItems_AuctionItemId",
                table: "AuctionItemAdditionalProperties");

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
                name: "FK_AuctionItemAdditionalProperties_AuctionItems_AuctionItemId",
                table: "AuctionItemAdditionalProperties",
                column: "AuctionItemId",
                principalTable: "AuctionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionItemAdditionalProperties_AuctionItems_AuctionItemId",
                table: "AuctionItemAdditionalProperties");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfcfea10-5c50-47c1-a123-a2dc5fb6735f", "AQAAAAIAAYagAAAAEBupGk2B7cJlbRxB3rdAJICOEiRAi2zr0VsdouxZy7hp3Yr68CZBe3MS6s/YKfFc1A==", "0b49cd7b-776d-43b5-bdae-579bbec8037d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb06cb0-2abd-4de9-8557-934b69df2f2e", "AQAAAAIAAYagAAAAELhzc6DaXCJ0zY1RNnh59zfuox1ZDgxCKRNwCkWuy9vLXxpK9bAO+p8qKuA90EJk0g==", "8be203a9-f4ff-45a8-81af-48875feebdd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfe72cbd-3dc8-47e3-b310-31161ac95754", "AQAAAAIAAYagAAAAENmjnzZ3z1iOpWmwHn6gFMkArWqOYZJQzZ91qXpcD8DcxdbeVBfH5HElqf0ZkFVNJg==", "c3e827b1-5b66-455b-9050-332dfbfd012f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53701346-B101-491E-8D0E-9FBD75B388AE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0266c301-2a75-4c2c-ae43-eb09d3db3710", "AQAAAAIAAYagAAAAENq1CcbN4hCBcTV6j8gGv0i4/JmgXTbu8+XM+FLGI5qk4x4YEU87CR+sSWTpXaiclA==", "d67d4ac5-67a8-43ce-ab41-f210448e648c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87073272-5331-449A-B99A-32F71D0DD7DC",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "038a5e2b-cc95-43d2-adf7-814e103925f0", "AQAAAAIAAYagAAAAEFeNc7y+TPhfUftB7lYUVVR8/NN8sGka/yxKztVYqyPkC57dGR/J7X7hFzgquGW8vA==", "6c7f2bdd-ac46-411b-8006-4d256eacf185" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D29F8763-846A-43B6-B6AE-3142395D355A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db94c0bd-871f-49ce-8185-2a2bbed177ce", "AQAAAAIAAYagAAAAEATUqhRzem/VVsw3XSfkwCvxt+Q6ZGw/vcOBRJcjcjGne7PTpqMY5WYSPtqrJjo3Gg==", "94f31cae-0825-44e4-a700-af8a3a466d02" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                columns: new[] { "AuctionEnd", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 20, 19, 15, 20, DateTimeKind.Local).AddTicks(5228), new DateTime(2024, 7, 7, 20, 19, 15, 20, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 7, 22, 20, 19, 15, 20, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                columns: new[] { "AuctionEnd", "CreatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 20, 19, 15, 20, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 7, 22, 20, 19, 15, 20, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionItemAdditionalProperties_AuctionItems_AuctionItemId",
                table: "AuctionItemAdditionalProperties",
                column: "AuctionItemId",
                principalTable: "AuctionItems",
                principalColumn: "Id");
        }
    }
}
