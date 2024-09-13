using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addTamara : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TamaraPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkout_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkout_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamaraPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TamaraPayments_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TamaraPayments_Students_StudentId",
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
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5160), "55ff66fc-5664-4a11-93f1-c070021af022" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5174), "1e9c9f15-1c8a-4c80-bf9c-b7d880022892" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5179), "c190ead8-98e6-46ec-83ce-5f85980be130" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5184), "21d56a88-6823-4328-8f21-407d4d80c3b0" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5206), "314d965b-8f1e-4adb-8c38-9fc56ec09008" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 8, 8, 23, 59, 0, 494, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.CreateIndex(
                name: "IX_TamaraPayments_CoursesSchedulessId",
                table: "TamaraPayments",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_TamaraPayments_StudentId",
                table: "TamaraPayments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TamaraPayments");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1539), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1274), "eecc79bb-67be-4a8d-9442-c792e2038479" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1289), "fef8373a-dcb4-4c39-8912-8388efaa5bf1" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1292), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1292), "1997902c-c29b-4398-afed-7de6a242c041" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1295), "683ad10b-4192-41a4-9520-d622f80f3712" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1298), "9a2c80d7-7df4-4750-b60f-26c6959f566c" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 8, 2, 5, 8, 33, 759, DateTimeKind.Local).AddTicks(1382) });
        }
    }
}
