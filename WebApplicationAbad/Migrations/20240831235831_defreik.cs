using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class defreik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ContactUs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6938), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7116), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7002), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6842), "a40b0138-6bbc-4f59-b069-fa1597f2a96c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6850), "6584cc5c-ba38-47c3-831c-43a34150028b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6853), "70515b10-7069-4aed-96a0-6da43ea37877" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6869), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6870), "972b6c8c-acbd-4c40-bfc6-af73dc35dd52" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6893), "daa7c775-fe4d-4eb3-93e7-75467d589db5" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6979) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ContactUs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 56, 1, 811, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 56, 1, 811, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 811, DateTimeKind.Utc).AddTicks(96), new DateTime(2024, 8, 31, 23, 56, 1, 811, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 56, 1, 811, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9798), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9811), "41861fca-e547-4784-9767-f557ed129941" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9819), "facb9731-9aa2-4177-968f-ae0b1b3acafe" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9821), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9821), "f12f46fe-1a4c-406a-8373-ed83e3106343" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9844), "5de7e378-d232-4567-a13c-4bba0f604bb3" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9847), "e3ec20d3-ae94-4001-8d4f-f168e896c7ce" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9956), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9958), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 56, 1, 810, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 9, 1, 2, 56, 1, 810, DateTimeKind.Local).AddTicks(9959) });
        }
    }
}
