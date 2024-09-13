using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment2327098858gr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "PayTabsCallbackModel",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "PayTabsCallbackModel",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2685), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2762), new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2733), new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2736), new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2738), new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2611), "f7562d51-bf9a-42e1-9421-7a0c4cef2da9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2621), "a9ec9964-7a08-492d-96b1-2bb09417d05a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2630), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2631), "d798b985-98e0-4bd9-a90a-ac75bb71f853" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2634), "0bd8172d-419f-4b88-a727-499b5c9e068c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2652), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2653), "441eeddd-28df-428d-ad6a-f8a4ca6a91ba" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 30, 28, 63, DateTimeKind.Utc).AddTicks(2714), new DateTime(2024, 8, 19, 16, 30, 28, 63, DateTimeKind.Local).AddTicks(2713) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "PayTabsCallbackModel");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "PayTabsCallbackModel");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3664), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3643), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3545), "31aee176-b111-4f7b-b41f-da5259e87e45" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3553), "6f9764e7-88d3-4f0d-bd51-fad454780b5a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3555), "c90360d8-5f6f-4424-9251-42d645bcf8d6" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3558), "ef39ca10-238f-4b29-b75a-6c7e067849b9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3560), "1c5c4fe3-fe81-4c73-8a34-6c870f376570" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3616), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3621) });
        }
    }
}
