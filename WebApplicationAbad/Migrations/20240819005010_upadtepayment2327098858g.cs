using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment2327098858g : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nots",
                table: "PayTabsCallbackModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3664), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3643), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3545), "31aee176-b111-4f7b-b41f-da5259e87e45" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3553), "6f9764e7-88d3-4f0d-bd51-fad454780b5a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3555), "c90360d8-5f6f-4424-9251-42d645bcf8d6" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3558), "ef39ca10-238f-4b29-b75a-6c7e067849b9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3560), "1c5c4fe3-fe81-4c73-8a34-6c870f376570" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3616), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 50, 7, 415, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 8, 19, 3, 50, 7, 415, DateTimeKind.Local).AddTicks(3621) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nots",
                table: "PayTabsCallbackModel");

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
    }
}
