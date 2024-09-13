using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class addSettingModel222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "evaluation",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "comment",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Studentjob",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8080), "2509d867-000c-442c-affb-51ff65490f4a" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8087), "617388f5-0f9d-4895-8f1b-898666d0e9f6" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8090), "e360d36e-d593-4746-a5eb-9c269a5a0332" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8092), "9de7642e-9131-4be0-b20e-476091d0e6ab" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8095), "48817812-fa92-4d40-a38e-d1deacee3aa0" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 8, 10, 7, 17, 19, 256, DateTimeKind.Local).AddTicks(8150) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "evaluation",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "comment",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Studentjob",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
