using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addSettingModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InstagramURL",
                table: "SettingsHomes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1801), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1821), "9bc4b850-1dc9-4448-b3f6-0b907e365337" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1838), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1839), "261f9862-61f0-43bb-a3f3-bfe5e7e2aee8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1848), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1849), "4e1bcb56-c3f3-4b15-aae5-79c3f3414cbb" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1857), "d3a63677-4adc-4d9d-8cbb-0b726ffa3589" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1886), "597e5fcc-00f2-4b49-9098-9c868e8edfc4" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2026), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2047), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2052), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2058), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2055) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InstagramURL",
                table: "SettingsHomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6380), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6610), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6615), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6284), "cd059af4-3e40-4824-bb07-319b6b950d1b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6295), "161f2235-20f2-48b2-8a2a-341754e5b746" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6311), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6311), "c139b281-8025-4972-a1cf-b2258f3a7fee" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6326), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6327), "dd74825e-830f-4db0-bdc1-bb2259309ecf" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6331), "230e4a59-6c4f-439f-bb7b-7c9733ce28c9" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6424), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6425) });
        }
    }
}
