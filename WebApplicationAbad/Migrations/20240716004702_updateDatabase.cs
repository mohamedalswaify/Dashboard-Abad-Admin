using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CoursesData",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5783), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5660), new DateTime(2024, 7, 16, 3, 47, 0, 242, DateTimeKind.Local).AddTicks(5659) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CoursesData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1258), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1226), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1228), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1229), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1280), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1287), new DateTime(2024, 7, 15, 3, 27, 8, 302, DateTimeKind.Local).AddTicks(1286) });
        }
    }
}
