using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class defre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4033), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3953), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3964), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3966), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3968), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3809), "c85f0352-3ff3-490d-8e34-389d9b1eb650" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3818), "b49de428-50b5-4c4c-bd51-4a81be1f2657" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3835), "70b35808-66b0-44b9-9c6f-4957e27a9ff5" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3847), "8d4dc911-fea0-422b-bb29-c9fb739f03cd" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3851), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3851), "eae47bea-ea0b-4297-a5c6-aa9d6c6b5509" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3928), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3930), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3932), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3935), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3933) });
        }
    }
}
