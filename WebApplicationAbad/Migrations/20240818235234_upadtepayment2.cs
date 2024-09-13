using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1151), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(922), "255b8d0d-4ed2-43a1-a97f-a570bae478d4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(931), "96b23c3b-c0eb-4623-8c7f-a8817369cc08" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(933), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(933), "0fc29aa8-cd42-40b5-b296-1405e38696a2" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(936), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(936), "79695a20-6242-4f37-8455-bcc4541eb710" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(940), "02e6b417-982e-4c2c-abc7-eddaf6cd05a1" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 8, 19, 2, 52, 33, 831, DateTimeKind.Local).AddTicks(1006) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(446), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(694), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(365), "67cc655d-0ce6-4330-ab47-efafb6f81732" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(375), "2ef26286-2604-44c3-b1b7-f4f31b24bd73" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(378), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(379), "df29feaf-e7e2-4467-a52e-0cbb02ab4111" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(388), "024938f7-4e4f-4d42-8ab5-91b5aff9c041" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(407), "74db81ed-57e0-41d7-b488-9db85b217c68" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(488), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(486) });
        }
    }
}
