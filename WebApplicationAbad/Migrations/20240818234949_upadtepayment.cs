using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(446), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(694), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(365), "67cc655d-0ce6-4330-ab47-efafb6f81732" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(375), "2ef26286-2604-44c3-b1b7-f4f31b24bd73" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(378), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(379), "df29feaf-e7e2-4467-a52e-0cbb02ab4111" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(388), "024938f7-4e4f-4d42-8ab5-91b5aff9c041" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(407), "74db81ed-57e0-41d7-b488-9db85b217c68" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(488), new DateTime(2024, 8, 19, 2, 49, 48, 494, DateTimeKind.Local).AddTicks(486) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partners");

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
    }
}
