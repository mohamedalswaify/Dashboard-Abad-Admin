using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addSettingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SettingsHomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitlePlane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoMe1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoMe2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoMe3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhoMe4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WahtsAppNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramURL = table.Column<int>(type: "int", nullable: true),
                    SnapchatURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingsHomes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6380), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6610), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6615), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6284), "cd059af4-3e40-4824-bb07-319b6b950d1b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6295), "161f2235-20f2-48b2-8a2a-341754e5b746" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6311), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6311), "c139b281-8025-4972-a1cf-b2258f3a7fee" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6326), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6327), "dd74825e-830f-4db0-bdc1-bb2259309ecf" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6331), "230e4a59-6c4f-439f-bb7b-7c9733ce28c9" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6424), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 8, 10, 3, 54, 36, 169, DateTimeKind.Local).AddTicks(6425) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SettingsHomes");

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
    }
}
