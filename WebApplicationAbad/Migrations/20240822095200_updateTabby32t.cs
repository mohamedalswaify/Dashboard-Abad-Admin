using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateTabby32t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5773), new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5688), new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5694), new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5697), new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5519), "e39ae6f4-f314-4972-b1ed-48007951b6d9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5532), "94fcdae3-2007-498a-a272-603f24d734af" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5535), "f12ab207-fab7-4b21-9ee6-332815445a86" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5545), "72ba0a8d-bcaf-4b14-aa33-b2fa3fbad501" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5548), "3c4eeaa7-0a70-4ef6-bf43-250cbf271c42" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5653), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5656), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 9, 51, 57, 228, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 8, 22, 12, 51, 57, 228, DateTimeKind.Local).AddTicks(5659) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Partners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9456), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9462), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9464), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9467), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9293), "cb519da1-9f88-43b8-8620-12dceb9bf2af" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9302), "43173b8f-f39b-4c68-9846-7233c7e950a7" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9306), "47695720-acab-4879-aca6-37464fccf26e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9319), "a2e69679-89f4-42af-8991-22030866d11b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9322), "6c60defc-3239-40dc-9aba-6bfec7fe7fa0" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9432), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9434), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9435) });
        }
    }
}
