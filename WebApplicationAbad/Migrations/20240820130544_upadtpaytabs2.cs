using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtpaytabs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1439), new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicName", "CreatedDate" },
                values: new object[] { "أونلاين", new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1387), new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1394), new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1069), "4f0e3314-cbc9-448a-87a8-8b00016e4c55" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1078), "d53d371b-00b2-46df-8407-49adebdd3d09" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1124), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1124), "fff1c686-6bb6-4383-9281-a80fe5b519a5" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1206), "4922758a-690d-4577-9988-3d6fcf5404f8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1220), "d01e60db-873d-4ba6-a017-aee253b4ddb2" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1350), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1352), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 8, 20, 16, 5, 41, 276, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.CreateIndex(
                name: "IX_PayTabsCallbackModel_StudentId",
                table: "PayTabsCallbackModel",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayTabsCallbackModel_Students_StudentId",
                table: "PayTabsCallbackModel",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayTabsCallbackModel_Students_StudentId",
                table: "PayTabsCallbackModel");

            migrationBuilder.DropIndex(
                name: "IX_PayTabsCallbackModel_StudentId",
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
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4007), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicName", "CreatedDate" },
                values: new object[] { "أون لاين", new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3889), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3766), "003d1eb6-13b0-4bb8-8b41-7b5c36ef2055" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3776), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3776), "15adb15e-f6df-4adf-8f0c-8d2191175cda" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3779), "60e1c9b1-756e-482d-9c55-9cac0f3f08a8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3788), "94ede2c2-b3fa-4a12-b978-d6d8b0efcd38" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3791), "c52a5368-f5bd-4401-9cef-77171538dc40" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3855), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3857), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3861), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3860) });
        }
    }
}
