using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateTrainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "TrainerData",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "TrainerData");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5414), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5417), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5208), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5277), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5284), new DateTime(2024, 7, 15, 3, 24, 58, 983, DateTimeKind.Local).AddTicks(5283) });
        }
    }
}
