using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addNulltoStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayTabsCallbackModel_Students_StudentId",
                table: "PayTabsCallbackModel");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "PayTabsCallbackModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8979), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9025), new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9029), new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9031), new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8933), "7258a697-b087-4262-9680-aae005c4e8ab" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8940), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8941), "48cde7dc-bc27-4f14-9cdc-716b640a8175" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8943), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8943), "7389e505-725c-4957-8cee-aa8cf46d13c4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8946), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8946), "46d6b36a-0a9e-41d6-ba4c-0c52fb865738" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8948), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(8948), "a9621042-3323-4ac5-964e-b8cb804ef456" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9005), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9007), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9009), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 54, 50, 726, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 9, 8, 15, 54, 50, 726, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.AddForeignKey(
                name: "FK_PayTabsCallbackModel_Students_StudentId",
                table: "PayTabsCallbackModel",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayTabsCallbackModel_Students_StudentId",
                table: "PayTabsCallbackModel");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "PayTabsCallbackModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7780), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7272), "06e8286b-139a-4bd6-bf0c-11ab6479ab18" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7299), "11575eee-1aef-44df-97cb-687b5dc3b30f" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7310), "b1614dac-daed-498d-8669-46c8b0c21390" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7335), "9eb3f2ca-0de3-4a65-b1a6-309f6a40dd04" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7343), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7344), "1bb284ac-2ac7-4dd2-8bff-b3b5f502fc7e" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7565), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.AddForeignKey(
                name: "FK_PayTabsCallbackModel_Students_StudentId",
                table: "PayTabsCallbackModel",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
