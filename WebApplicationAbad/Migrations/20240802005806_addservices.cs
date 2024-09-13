using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addservices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SerivesModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerivesModels", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1142), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1154), "1f8bc58e-eaae-469d-a3ff-c27c03600dee" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1163), "4eff47a7-f388-42d1-a237-3d5f7206448e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1166), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1166), "9f6aac7b-5717-486c-bb52-f7b3f72d63ca" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1179), "6d960c92-6c2f-47a3-a528-9fa46a262245" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1182), "4b7a36ac-2120-4bcf-bc70-7a98a4440380" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1301), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1302) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerivesModels");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6150), "8d4aaef5-9532-4247-acab-5ef40f51b9fb" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6168), "9625df16-812a-44cb-a03e-f6ebe882b498" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6172), "da9b69c9-64b1-4981-a0f9-ca783db04fd5" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6175), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6175), "34d7c2ed-38b9-4af5-ad36-2a8381c06211" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6178), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6178), "7193c583-dbe5-48ca-8d58-4260d181754f" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6251), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6255) });
        }
    }
}
