using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class dff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TokenNumber",
                table: "CoursesTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4897), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4611), "dae25728-2636-4b51-916f-be71fbba35b4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4639), "3d101ea2-b45f-4253-8a6b-165f0e8e7b27" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4643), "8a54c8d5-228d-47d5-a3a8-271e2d31451c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4646), "2c15cbdd-a46e-48e1-9d4e-fc195256783a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4651), "7f772c52-8b53-4bca-9bea-4d9f43cc4598" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4736) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TokenNumber",
                table: "CoursesTypes");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2477), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2145), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2342), new DateTime(2024, 7, 24, 2, 25, 0, 709, DateTimeKind.Local).AddTicks(2341) });
        }
    }
}
