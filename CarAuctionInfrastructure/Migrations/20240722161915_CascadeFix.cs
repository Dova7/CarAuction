using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAuctionInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CascadeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1365FCBA-5EBF-45B9-B67C-11DC33B91B12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ef7673e-8571-4336-8c32-b2df16c1ab17", "AQAAAAIAAYagAAAAEEA3ThslhyKMJgez54wmVrwL2zm3DXc/gaf+9zVORlG2JX9iJk12bQGm+av7mF90FQ==", "c69a553a-7b64-4c5e-9261-344559f353d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1CF16252-E7F5-45DF-941A-88B7A592F9C7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f11de9ab-aff8-45c5-9ff9-0cfe65bc8a0b", "AQAAAAIAAYagAAAAEIWeblDZA7TwROtUBanIlJHmzdbQ+KROfa+EewqLQE9S1eDw1q6z1+dRO6fMY0HMTA==", "6e431e10-2753-4983-8039-72333a9bbf0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44DC07F7-DD89-435E-8E67-AB46C799F3F2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa83b31c-6c62-42c4-8b7d-defaa7b33f90", "AQAAAAIAAYagAAAAEEcL2EdSmoHsh6+59npWo8j9aSMIayaC8y5ILPrZCgQqL3uLy3ebBWvQZapaV++1Tw==", "ebad01a3-aac1-4d86-aff9-22cd9d9b03f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53701346-B101-491E-8D0E-9FBD75B388AE",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a223f3f7-cf24-46cf-a629-ee251b97c824", "AQAAAAIAAYagAAAAELDDm1g/K1XlY8qN0lFifNA9fu6SKxyBSSeU6B2BakqiadqAil2K8v/GH6/p4R6oRQ==", "79688907-d577-4b3b-af58-f7a01338fa06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87073272-5331-449A-B99A-32F71D0DD7DC",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d0e783b-4545-4ac4-9c9b-2b6c7f4d55a7", "AQAAAAIAAYagAAAAELKiGmB0TXhOduIPit3GZfpeZD4qf6bgRoh9IP4BAPOPmkiEagBq3h2UhVjScuQCqQ==", "009eefb6-5f84-489a-bf0f-ee239dd9210a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D29F8763-846A-43B6-B6AE-3142395D355A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706b11a3-d3cd-4c38-848a-d57bb2bf9cee", "AQAAAAIAAYagAAAAEDY9oq80inYoR2Fa3bm0qFaWnB1hiWMKLU2mt/T54RPkvDbSXHY4cfdOaWAo4lsiaA==", "4bc73f88-830d-46cf-873b-89c2c799d14f" });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("851b5cb4-99be-4e77-bfa6-8769d43c0f31"),
                columns: new[] { "AuctionEnd", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7905), new DateTime(2024, 6, 9, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7901), new DateTime(2024, 6, 24, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: new Guid("c21feb91-5cbb-4f8a-884a-0597444e7bb2"),
                columns: new[] { "AuctionEnd", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 24, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 6, 24, 19, 58, 36, 881, DateTimeKind.Local).AddTicks(7875) });
        }
    }
}
