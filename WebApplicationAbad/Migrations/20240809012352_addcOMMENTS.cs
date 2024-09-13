using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addcOMMENTS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studentjob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evaluation = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9944), "72f1990d-c7da-4473-a353-3d22ad5b8eec" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9954), new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9955), "7b6104d2-d8c1-4037-b596-8ce204de3481" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9959), "8f9a3efc-b410-4207-9e59-8b129e24aac8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9963), new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9963), "5d55aad8-3933-4c28-94d0-29ba03195617" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 8, 9, 4, 23, 51, 633, DateTimeKind.Local).AddTicks(9968), "f9f43cc0-19af-4b46-9a2a-f64918d5a620" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(58), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 8, 9, 4, 23, 51, 634, DateTimeKind.Local).AddTicks(66) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7867), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7871), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7615), "f9c37531-bbbe-483f-894d-13ffc288ba5a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7624), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7625), "b737f66e-39b4-47fa-b756-9e92722e5f57" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7630), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7630), "8efd4b8e-3982-4a0a-9d0b-a8c3b074d5c1" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7634), "fce03255-cc2f-4bc8-8805-98f5051930f9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7638), "b51548eb-96b9-4fbd-9aaf-682d4ef216d7" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 8, 9, 2, 18, 57, 64, DateTimeKind.Local).AddTicks(7718) });
        }
    }
}
