using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment232 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9663), new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9635), new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9638), new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9641), new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9643), new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9499), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9510), "ac8141ea-e59d-4f55-bccf-b375db056330" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9518), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9518), "9844bd01-8eb5-46f0-a4da-2435bc78080b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9521), "85345cd4-298f-4449-a69d-5f93647c763d" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9554), "9e127798-01e8-48db-b779-a72acf61aad0" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9557), "ebfc947e-6cc8-4be5-9d9c-ce0a45fafc99" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9613), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9615), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 7, 527, DateTimeKind.Utc).AddTicks(9619), new DateTime(2024, 8, 19, 3, 5, 7, 527, DateTimeKind.Local).AddTicks(9618) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 8, 19, 2, 58, 47, 737, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 27, 0, 52, 18, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 27, 0, 52, 34, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 27, 0, 52, 18, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 28, 0, 20, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 27, 0, 52, 34, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 27, 0, 52, 52, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 27, 0, 54, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 8, 27, 0, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 27, 0, 55, 18, 0, DateTimeKind.Unspecified) });

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
    }
}
