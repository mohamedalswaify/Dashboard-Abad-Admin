using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class VisitorCounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitorCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorCounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 730, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 8, 16, 17, 3, 44, 730, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 730, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 8, 16, 17, 3, 44, 730, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9345), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9367), "eb609d4e-773d-498f-b76b-d46b72c4061c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9389), "1ca0df16-7bb8-4c8d-af1b-ee2dea560c58" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9396), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9397), "a13bbe2d-5dc6-45e9-814a-4a33fb3286d9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9418), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9419), "0a762fb6-e7d8-4628-8a7f-726c1b1cf4c5" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9426), "303f1651-dd5a-4890-88c1-936b187dce22" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9624), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9629), new DateTime(2024, 8, 16, 17, 3, 44, 729, DateTimeKind.Local).AddTicks(9627) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitorCounts");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9241), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9013), "965c2777-0ca0-4463-8fca-7a131ec67209" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9022), "4785f4c0-764c-4dd5-a9f2-423384d05ad2" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9025), "f5be1fae-8e3d-4699-b284-4d7b60e2ea6b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9028), "ae549841-36d1-482b-951d-fbff8a4b0557" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9032), "810250c7-21c2-4295-8f2a-7426b7b82217" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9094) });
        }
    }
}
