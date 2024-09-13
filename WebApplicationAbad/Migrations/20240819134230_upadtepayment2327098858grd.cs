using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment2327098858grd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "PayTabsCallbackModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3093), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3097), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3100), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2971), "f1c031ff-7994-4d34-b5a4-e1ca1b47f70d" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2983), "dc3b77e6-5c28-4c67-838b-6080706cd03e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2987), "69471b8b-86f8-489b-bd2f-aa24f013bdfe" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2991), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2991), "e1e2454e-bc9c-4fde-89ca-59fce7dfca3d" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2994), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2995), "c3d2c9be-6be0-40de-9621-ebb748ef79a7" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3065), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3070), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3073), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3071) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "PayTabsCallbackModel",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
    }
}
