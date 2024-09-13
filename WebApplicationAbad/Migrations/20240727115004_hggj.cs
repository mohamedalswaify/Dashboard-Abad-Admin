using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class hggj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1613), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1616), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1387), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1399), "6d7b6f50-7917-47b7-97f1-a9589a224690" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1407), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1408), "31f2e405-16f3-4030-b880-1eb465d8258f" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1411), "dc1bad72-0196-438b-bb3d-e18aab0eb8ae" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1414), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1414), "b3a92df9-4cbf-447e-80df-1cd5d90835be" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1417), "4e393d21-4114-464a-bb84-5d2a228f2313" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1480) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4453), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4404), "2f974fef-eb32-413f-943c-8d41a1b8af65" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4411), "30960153-67fa-4d7a-aaeb-b55faabd9938" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4413), "97fdd39e-588a-48e5-935b-4ce951c523ad" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4415), "26ce7be8-6724-4eda-8b2a-04622b379e99" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4428), "6c3ec42a-aacf-46e6-a215-bdddb5f14220" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4476) });
        }
    }
}
