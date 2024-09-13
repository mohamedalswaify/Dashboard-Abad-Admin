using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateTabby32t5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPayment",
                table: "CampsModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7088), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7107), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7115), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7122), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6639), "aba416d6-746d-4099-9193-434e7c207366" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6671), "407d42d0-343b-433b-b430-3f4d9a41acbe" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6686), "23362f78-6cd7-4b79-bb1c-4354fe158bb7" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6718), "11c295b3-19d0-499e-b6f3-ec958a98ebe4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6735), "242ca7cd-be27-44df-81b7-c18256c654db" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(7003) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPayment",
                table: "CampsModels");

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
    }
}
