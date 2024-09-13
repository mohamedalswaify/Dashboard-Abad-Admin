using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8480), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8271), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8280), "c5a87709-decc-41d7-a0f9-605a553774f6" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8298), "7a681952-0e70-4803-8568-998299c7b195" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8300), "63b5451c-3f8f-41ec-ac8f-0980a0c54139" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8303), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8303), "8a9ed5af-4788-420b-bb0a-ee902d04c8bc" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8306), "65d31d49-cdb4-4463-848a-dc7bf8cd4d9b" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8360), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8362) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
