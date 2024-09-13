using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class hggjff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Absractation",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "ContentSubject2",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "ContetntTitle",
                table: "Article");

            migrationBuilder.RenameColumn(
                name: "UserUpdaue",
                table: "Article",
                newName: "UserCreate");

            migrationBuilder.RenameColumn(
                name: "TitleSubject3",
                table: "Article",
                newName: "ReadTime");

            migrationBuilder.RenameColumn(
                name: "TitleHeader",
                table: "Article",
                newName: "IamgeAuthor");

            migrationBuilder.RenameColumn(
                name: "TitleContont3",
                table: "Article",
                newName: "IamgeArticle");

            migrationBuilder.RenameColumn(
                name: "TitelSubject2",
                table: "Article",
                newName: "Contetnt");

            migrationBuilder.RenameColumn(
                name: "Iamge",
                table: "Article",
                newName: "Authorjob");

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(961), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(686), "7d874549-91c3-43da-a26c-571bd7b94cf9" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(711), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(712), "fdc05151-40b7-4950-a884-5528891e3434" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(716), "68851a5d-9db7-4a97-a092-b14f7d6d6ffc" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(720), "f393f1f6-3a27-41e3-8ac3-455a59d12238" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(723), "0250035e-14f2-4995-9153-6222da76c1ce" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 7, 28, 3, 50, 9, 94, DateTimeKind.Local).AddTicks(798) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.RenameColumn(
                name: "UserCreate",
                table: "Article",
                newName: "UserUpdaue");

            migrationBuilder.RenameColumn(
                name: "ReadTime",
                table: "Article",
                newName: "TitleSubject3");

            migrationBuilder.RenameColumn(
                name: "IamgeAuthor",
                table: "Article",
                newName: "TitleHeader");

            migrationBuilder.RenameColumn(
                name: "IamgeArticle",
                table: "Article",
                newName: "TitleContont3");

            migrationBuilder.RenameColumn(
                name: "Contetnt",
                table: "Article",
                newName: "TitelSubject2");

            migrationBuilder.RenameColumn(
                name: "Authorjob",
                table: "Article",
                newName: "Iamge");

            migrationBuilder.AddColumn<string>(
                name: "Absractation",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentSubject2",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContetntTitle",
                table: "Article",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1613), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1616), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1387), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1399), "6d7b6f50-7917-47b7-97f1-a9589a224690" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1407), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1408), "31f2e405-16f3-4030-b880-1eb465d8258f" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1411), "dc1bad72-0196-438b-bb3d-e18aab0eb8ae" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1414), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1414), "b3a92df9-4cbf-447e-80df-1cd5d90835be" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1417), "4e393d21-4114-464a-bb84-5d2a228f2313" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 7, 27, 14, 50, 4, 596, DateTimeKind.Local).AddTicks(1480) });
        }
    }
}
