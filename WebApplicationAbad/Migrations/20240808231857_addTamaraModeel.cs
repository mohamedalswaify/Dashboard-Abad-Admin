using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addTamaraModeel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorizeOrderModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoCaptured = table.Column<bool>(type: "bit", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaptureId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizeOrderModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageReapets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageReapets", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorizeOrderModels");

            migrationBuilder.DropTable(
                name: "MessageReapets");

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
        }
    }
}
