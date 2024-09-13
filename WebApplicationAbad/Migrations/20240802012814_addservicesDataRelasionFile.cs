using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addservicesDataRelasionFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fileName",
                table: "CompanyRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6024), "4ad509c8-2b8a-496a-b32f-60c02dd074f9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6033), "3837b449-2d4b-4c27-abeb-e1576d67dbfa" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6036), "240fa024-ecba-4329-a0a8-644dac717f32" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6038), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6038), "1374aa4d-18b7-4346-b8bd-beb774cd6024" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6041), "f253dfd3-5825-4486-9ee0-c06a8a3f514b" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6097), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6101), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 8, 2, 4, 28, 13, 460, DateTimeKind.Local).AddTicks(6102) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileName",
                table: "CompanyRequests");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3082), "f97cebfd-d691-4ae3-9b38-684f381e7bea" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3090), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3091), "9f05dc1f-a2f7-403d-b97d-e691c6d462f4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3093), "2dbf2853-3d50-4254-8c79-3b34602c13f4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3096), "b2d674cc-602f-41e8-8864-85ad7a6cff40" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3098), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3099), "1004f91d-d6ec-4686-9338-95a4b0a0300d" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3168) });
        }
    }
}
