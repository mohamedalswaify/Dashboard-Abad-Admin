using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserCode",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1824), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(2027), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1766), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 7, 16, 3, 53, 32, 337, DateTimeKind.Local).AddTicks(1862) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserCode",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
