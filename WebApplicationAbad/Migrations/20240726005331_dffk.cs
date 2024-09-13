using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class dffk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseBaskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseBaskets_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseBaskets_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4453), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4404), "2f974fef-eb32-413f-943c-8d41a1b8af65" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4411), "30960153-67fa-4d7a-aaeb-b55faabd9938" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4413), "97fdd39e-588a-48e5-935b-4ce951c523ad" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4415), "26ce7be8-6724-4eda-8b2a-04622b379e99" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4428), "6c3ec42a-aacf-46e6-a215-bdddb5f14220" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 7, 26, 3, 53, 30, 6, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.CreateIndex(
                name: "IX_CourseBaskets_CoursesSchedulessId",
                table: "CourseBaskets",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseBaskets_StudentId",
                table: "CourseBaskets",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseBaskets");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4897), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4611), "dae25728-2636-4b51-916f-be71fbba35b4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4639), "3d101ea2-b45f-4253-8a6b-165f0e8e7b27" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4643), "8a54c8d5-228d-47d5-a3a8-271e2d31451c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4646), "2c15cbdd-a46e-48e1-9d4e-fc195256783a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4651), "7f772c52-8b53-4bca-9bea-4d9f43cc4598" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 7, 25, 0, 2, 28, 810, DateTimeKind.Local).AddTicks(4736) });
        }
    }
}
