using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishName",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1539), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1274), "eecc79bb-67be-4a8d-9442-c792e2038479" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1289), "fef8373a-dcb4-4c39-8912-8388efaa5bf1" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1292), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1292), "1997902c-c29b-4398-afed-7de6a242c041" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1295), "683ad10b-4192-41a4-9520-d622f80f3712" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1298), "9a2c80d7-7df4-4750-b60f-26c6959f566c" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1382) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnglishName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
