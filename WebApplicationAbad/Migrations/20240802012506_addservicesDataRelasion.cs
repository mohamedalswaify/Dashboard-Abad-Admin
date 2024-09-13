using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addservicesDataRelasion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoursesName",
                table: "CompanyRequests");

            migrationBuilder.RenameColumn(
                name: "ServiceType",
                table: "CompanyRequests",
                newName: "CoursesTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "CompanyRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CoursesTypesCode",
                table: "CompanyRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerivesModelId",
                table: "CompanyRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3082), "f97cebfd-d691-4ae3-9b38-684f381e7bea" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3090), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3091), "9f05dc1f-a2f7-403d-b97d-e691c6d462f4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3093), "2dbf2853-3d50-4254-8c79-3b34602c13f4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3096), "b2d674cc-602f-41e8-8864-85ad7a6cff40" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3098), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3099), "1004f91d-d6ec-4686-9338-95a4b0a0300d" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3167), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 8, 2, 4, 25, 4, 811, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRequests_CoursesTypesCode",
                table: "CompanyRequests",
                column: "CoursesTypesCode");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRequests_SerivesModelId",
                table: "CompanyRequests",
                column: "SerivesModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyRequests_CoursesTypes_CoursesTypesCode",
                table: "CompanyRequests",
                column: "CoursesTypesCode",
                principalTable: "CoursesTypes",
                principalColumn: "Code");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyRequests_SerivesModels_SerivesModelId",
                table: "CompanyRequests",
                column: "SerivesModelId",
                principalTable: "SerivesModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRequests_CoursesTypes_CoursesTypesCode",
                table: "CompanyRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyRequests_SerivesModels_SerivesModelId",
                table: "CompanyRequests");

            migrationBuilder.DropIndex(
                name: "IX_CompanyRequests_CoursesTypesCode",
                table: "CompanyRequests");

            migrationBuilder.DropIndex(
                name: "IX_CompanyRequests_SerivesModelId",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "CoursesTypesCode",
                table: "CompanyRequests");

            migrationBuilder.DropColumn(
                name: "SerivesModelId",
                table: "CompanyRequests");

            migrationBuilder.RenameColumn(
                name: "CoursesTypeId",
                table: "CompanyRequests",
                newName: "ServiceType");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "CompanyRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoursesName",
                table: "CompanyRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8446), "cd523464-46f6-457b-bc00-a559c6467a7e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8480), "56bceae8-80ab-42dc-b617-714200a1480f" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8483), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8483), "326c9e38-9e0a-45c7-b2db-7960e738b9be" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8498), "8edd9823-23db-4b4a-8eb4-91a5393d1acd" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8501), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8501), "27ba17b9-b80e-4e20-86c5-a08c5826bafa" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 8, 2, 4, 13, 59, 893, DateTimeKind.Local).AddTicks(8570) });
        }
    }
}
