using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class updateTabby32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfCourse = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCodes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9591), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9456), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9462), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9464), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9467), new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9293), "cb519da1-9f88-43b8-8620-12dceb9bf2af" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9302), "43173b8f-f39b-4c68-9846-7233c7e950a7" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9306), "47695720-acab-4879-aca6-37464fccf26e" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9319), "a2e69679-89f4-42af-8991-22030866d11b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9322), "6c60defc-3239-40dc-9aba-6bfec7fe7fa0" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9432), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9434), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 2, 44, 38, 793, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 8, 22, 5, 44, 38, 793, DateTimeKind.Local).AddTicks(9435) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountCodes");

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
        }
    }
}
