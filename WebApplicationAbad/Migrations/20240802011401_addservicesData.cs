using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addservicesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "SerivesModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "عرض سعر" },
                    { 2, "طلب عقد" },
                    { 4, "اعاده الاتصال" },
                    { 5, "طلب معلومات اضافية'" },
                    { 6, "مناقصة" },
                    { 7, "طلب زيارة" },
                    { 8, "اخري" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1264), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1142), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1154), "1f8bc58e-eaae-469d-a3ff-c27c03600dee" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1163), "4eff47a7-f388-42d1-a237-3d5f7206448e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1166), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1166), "9f6aac7b-5717-486c-bb52-f7b3f72d63ca" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1179), "6d960c92-6c2f-47a3-a528-9fa46a262245" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1182), "4b7a36ac-2120-4bcf-bc70-7a98a4440380" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1301), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 8, 2, 3, 58, 4, 162, DateTimeKind.Local).AddTicks(1302) });
        }
    }
}
