using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment232709885 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAfterPay",
                table: "PayTabsCallbackModel",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7793), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7836), new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7839), new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7841), new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7843), new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7753), "db54f653-fb26-4082-948b-7aa88b5c66ac" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7760), "ed252fc1-5d60-48bf-8ec4-a6621e16cdbc" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7762), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7762), "504a6e56-133f-4df1-a845-dcd8bfccd374" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7765), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7765), "23d190e5-f2e0-4ef1-9f9c-7435d0b5aa0a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7768), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7768), "9dd5322c-2b2c-49d3-b471-c2b0bc7264d9" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7815), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 42, 1, 53, DateTimeKind.Utc).AddTicks(7820), new DateTime(2024, 8, 19, 3, 42, 1, 53, DateTimeKind.Local).AddTicks(7819) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAfterPay",
                table: "PayTabsCallbackModel");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3776), new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3779), new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3791), new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3665), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3677), "3147ca37-5c4e-432e-95eb-2e8ad179e11c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3686), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3686), "9e87980f-2492-4676-9c7b-26cd938ed495" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3689), "b257079b-b5ba-4c92-b332-a2c268264466" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3691), "2f68c658-5f55-40e3-a395-2e7351a6ae68" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3694), "8724ecb0-81b3-4c4c-b811-9f3bde9f0214" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3749), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3751), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3753), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3756), new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3755) });
        }
    }
}
