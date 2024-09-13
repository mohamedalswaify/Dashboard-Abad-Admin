using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class hggjffd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Article",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6150), "8d4aaef5-9532-4247-acab-5ef40f51b9fb" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6168), "9625df16-812a-44cb-a03e-f6ebe882b498" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6172), "da9b69c9-64b1-4981-a0f9-ca783db04fd5" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6175), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6175), "34d7c2ed-38b9-4af5-ad36-2a8381c06211" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6178), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6178), "7193c583-dbe5-48ca-8d58-4260d181754f" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6251), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 7, 28, 4, 51, 14, 811, DateTimeKind.Local).AddTicks(6255) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Article");

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
    }
}
