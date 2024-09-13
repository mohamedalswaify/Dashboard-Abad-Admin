using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class djdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampsModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedCode = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampsModels", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9241), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9013), "965c2777-0ca0-4463-8fca-7a131ec67209" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9022), "4785f4c0-764c-4dd5-a9f2-423384d05ad2" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9025), "f5be1fae-8e3d-4699-b284-4d7b60e2ea6b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9028), "ae549841-36d1-482b-951d-fbff8a4b0557" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9032), "810250c7-21c2-4295-8f2a-7426b7b82217" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 8, 10, 21, 18, 59, 459, DateTimeKind.Local).AddTicks(9094) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampsModels");

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
    }
}
