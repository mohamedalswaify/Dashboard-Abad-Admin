using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment2327 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4225), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4319), new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4275), new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4158), "ed29e39c-5605-4fdc-a3d7-eada093ca61b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4172), "30abfb9c-60e2-4b9a-9de7-cfeec569fec0" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4175), "d6f21a4d-22e7-4ef8-b657-9a5fca67f255" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4177), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4177), "0f64e1a9-6ee0-4d0f-907c-1c56e3966de3" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4189), "c90a8288-2373-4af8-8ad1-532adccd94e9" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4247), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4249), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4253), new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4251) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
