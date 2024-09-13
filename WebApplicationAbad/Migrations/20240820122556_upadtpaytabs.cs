using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtpaytabs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TamaraPayments_CoursesScheduless_CoursesSchedulessId",
                table: "TamaraPayments");

            migrationBuilder.DropColumn(
                name: "coursesScheduleId",
                table: "PayTabsCallbackModel");

            migrationBuilder.AlterColumn<int>(
                name: "CoursesSchedulessId",
                table: "TamaraPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmountwithTaxAferDiscount",
                table: "TamaraPayments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "discountAmount",
                table: "TamaraPayments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "PaytabsPaymentCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayTabsCallbackModelId = table.Column<int>(type: "int", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    CostWithTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaytabsPaymentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaytabsPaymentCourses_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaytabsPaymentCourses_PayTabsCallbackModel_PayTabsCallbackModelId",
                        column: x => x.PayTabsCallbackModelId,
                        principalTable: "PayTabsCallbackModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TamaraPaymentCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TamaraPaymentId = table.Column<int>(type: "int", nullable: false),
                    CoursesSchedulessId = table.Column<int>(type: "int", nullable: false),
                    CostWithTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DISCOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TamaraPaymentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TamaraPaymentCourses_CoursesScheduless_CoursesSchedulessId",
                        column: x => x.CoursesSchedulessId,
                        principalTable: "CoursesScheduless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TamaraPaymentCourses_TamaraPayments_TamaraPaymentId",
                        column: x => x.TamaraPaymentId,
                        principalTable: "TamaraPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4007), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3889), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3766), "003d1eb6-13b0-4bb8-8b41-7b5c36ef2055" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3776), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3776), "15adb15e-f6df-4adf-8f0c-8d2191175cda" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3779), "60e1c9b1-756e-482d-9c55-9cac0f3f08a8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3788), "94ede2c2-b3fa-4a12-b978-d6d8b0efcd38" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3791), "c52a5368-f5bd-4401-9cef-77171538dc40" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3855), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3857), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 25, 54, 622, DateTimeKind.Utc).AddTicks(3861), new DateTime(2024, 8, 20, 15, 25, 54, 622, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.CreateIndex(
                name: "IX_PaytabsPaymentCourses_CoursesSchedulessId",
                table: "PaytabsPaymentCourses",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_PaytabsPaymentCourses_PayTabsCallbackModelId",
                table: "PaytabsPaymentCourses",
                column: "PayTabsCallbackModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TamaraPaymentCourses_CoursesSchedulessId",
                table: "TamaraPaymentCourses",
                column: "CoursesSchedulessId");

            migrationBuilder.CreateIndex(
                name: "IX_TamaraPaymentCourses_TamaraPaymentId",
                table: "TamaraPaymentCourses",
                column: "TamaraPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TamaraPayments_CoursesScheduless_CoursesSchedulessId",
                table: "TamaraPayments",
                column: "CoursesSchedulessId",
                principalTable: "CoursesScheduless",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TamaraPayments_CoursesScheduless_CoursesSchedulessId",
                table: "TamaraPayments");

            migrationBuilder.DropTable(
                name: "PaytabsPaymentCourses");

            migrationBuilder.DropTable(
                name: "TamaraPaymentCourses");

            migrationBuilder.DropColumn(
                name: "TotalAmountwithTaxAferDiscount",
                table: "TamaraPayments");

            migrationBuilder.DropColumn(
                name: "discountAmount",
                table: "TamaraPayments");

            migrationBuilder.AlterColumn<int>(
                name: "CoursesSchedulessId",
                table: "TamaraPayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "coursesScheduleId",
                table: "PayTabsCallbackModel",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3093), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3097), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3100), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2971), "f1c031ff-7994-4d34-b5a4-e1ca1b47f70d" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2983), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2983), "dc3b77e6-5c28-4c67-838b-6080706cd03e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2987), "69471b8b-86f8-489b-bd2f-aa24f013bdfe" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2991), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2991), "e1e2454e-bc9c-4fde-89ca-59fce7dfca3d" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2994), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(2995), "c3d2c9be-6be0-40de-9621-ebb748ef79a7" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3065), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3070), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 19, 13, 42, 28, 800, DateTimeKind.Utc).AddTicks(3073), new DateTime(2024, 8, 19, 16, 42, 28, 800, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.AddForeignKey(
                name: "FK_TamaraPayments_CoursesScheduless_CoursesSchedulessId",
                table: "TamaraPayments",
                column: "CoursesSchedulessId",
                principalTable: "CoursesScheduless",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
