using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateTabby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabbyPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkout_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amountRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amountResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabbyPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabbyPayments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabbyPaymentCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TabbyPaymentId = table.Column<int>(type: "int", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    CostWithTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabbyPaymentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabbyPaymentCourses_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabbyPaymentCourses_TabbyPayments_TabbyPaymentId",
                        column: x => x.TabbyPaymentId,
                        principalTable: "TabbyPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4224), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4385), new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4335), new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4344), new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4161), "7fd5729c-ff63-4623-8610-14e146a40d78" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4169), "f44ea592-1c60-443b-9c85-8309a1bc9dfb" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4172), "0843d23b-516d-49c0-95cd-c77123a2da5f" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4179), "bc37790d-ec80-4837-8979-5fe18c181186" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4181), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4182), "d99b1ab7-ac20-43ea-8e81-fcc0af5094ea" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 7, 47, 964, DateTimeKind.Utc).AddTicks(4305), new DateTime(2024, 8, 21, 17, 7, 47, 964, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.CreateIndex(
                name: "IX_TabbyPaymentCourses_CoursesSchedulessId",
                table: "TabbyPaymentCourses",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_TabbyPaymentCourses_TabbyPaymentId",
                table: "TabbyPaymentCourses",
                column: "TabbyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_TabbyPayments_StudentId",
                table: "TabbyPayments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabbyPaymentCourses");

            migrationBuilder.DropTable(
                name: "TabbyPayments");

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
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 5, 41, 276, DateTimeKind.Utc).AddTicks(1443));

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
        }
    }
}
