using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class dhfhd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequiredCourse_CoursesScheduless_CoursesSchedulessId",
                table: "RequiredCourse");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "TrainerData");

            migrationBuilder.DropColumn(
                name: "PriceNoM",
                table: "CoursesData");

            migrationBuilder.RenameColumn(
                name: "CoursesSchedulessId",
                table: "RequiredCourse",
                newName: "CoursesDataId");

            migrationBuilder.RenameIndex(
                name: "IX_RequiredCourse_CoursesSchedulessId",
                table: "RequiredCourse",
                newName: "IX_RequiredCourse_CoursesDataId");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Countries",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "PayTabsCallbackModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coursesScheduleId",
                table: "PayTabsCallbackModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ButtonInvoice",
                table: "EmployeePremotion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MessageReapet",
                table: "EmployeePremotion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "UserCode",
                table: "CoursesScheduless",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "detailsTime",
                table: "CoursesScheduless",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserCode",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DetailsAr",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CoursesData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileOutline",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestImage",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TestVaild",
                table: "CoursesData",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddForeignKey(
                name: "FK_RequiredCourse_CoursesData_CoursesDataId",
                table: "RequiredCourse",
                column: "CoursesDataId",
                principalTable: "CoursesData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequiredCourse_CoursesData_CoursesDataId",
                table: "RequiredCourse");

            migrationBuilder.DropColumn(
                name: "Countries",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "PayTabsCallbackModel");

            migrationBuilder.DropColumn(
                name: "coursesScheduleId",
                table: "PayTabsCallbackModel");

            migrationBuilder.DropColumn(
                name: "ButtonInvoice",
                table: "EmployeePremotion");

            migrationBuilder.DropColumn(
                name: "MessageReapet",
                table: "EmployeePremotion");

            migrationBuilder.DropColumn(
                name: "detailsTime",
                table: "CoursesScheduless");

            migrationBuilder.DropColumn(
                name: "FileOutline",
                table: "CoursesData");

            migrationBuilder.DropColumn(
                name: "TestImage",
                table: "CoursesData");

            migrationBuilder.DropColumn(
                name: "TestVaild",
                table: "CoursesData");

            migrationBuilder.RenameColumn(
                name: "CoursesDataId",
                table: "RequiredCourse",
                newName: "CoursesSchedulessId");

            migrationBuilder.RenameIndex(
                name: "IX_RequiredCourse_CoursesDataId",
                table: "RequiredCourse",
                newName: "IX_RequiredCourse_CoursesSchedulessId");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "TrainerData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserCode",
                table: "CoursesScheduless",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserCode",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DetailsAr",
                table: "CoursesData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CoursesData",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceNoM",
                table: "CoursesData",
                type: "decimal(18,2)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_RequiredCourse_CoursesScheduless_CoursesSchedulessId",
                table: "RequiredCourse",
                column: "CoursesSchedulessId",
                principalTable: "CoursesScheduless",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
