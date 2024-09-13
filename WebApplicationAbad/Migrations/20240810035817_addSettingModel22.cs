using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addSettingModel22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrivacyModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermsofService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivacyPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntellectualPropertyPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainServicesAgreement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionsPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyModels", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9053), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(8997), "015d2430-f272-4b4c-a170-eb64b2bf89a1" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9005), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9005), "f81ecfbd-fa3e-4734-9f37-9415cc8953e8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9008), "89dddef4-4f23-4973-94a9-ae664eeb67ee" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9019), "e0b59b3b-a3fa-43f5-aa31-d95ca6033019" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9022), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9022), "7ddd6ac1-d2bc-41c4-9dba-43afe57b9f1f" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9075), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9079), new DateTime(2024, 8, 10, 6, 58, 14, 852, DateTimeKind.Local).AddTicks(9078) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivacyModels");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1801), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1821), "9bc4b850-1dc9-4448-b3f6-0b907e365337" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1838), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1839), "261f9862-61f0-43bb-a3f3-bfe5e7e2aee8" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1848), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1849), "4e1bcb56-c3f3-4b15-aae5-79c3f3414cbb" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1857), "d3a63677-4adc-4d9d-8cbb-0b726ffa3589" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(1886), "597e5fcc-00f2-4b49-9098-9c868e8edfc4" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2026), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2047), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2052), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2058), new DateTime(2024, 8, 10, 4, 2, 5, 507, DateTimeKind.Local).AddTicks(2055) });
        }
    }
}
