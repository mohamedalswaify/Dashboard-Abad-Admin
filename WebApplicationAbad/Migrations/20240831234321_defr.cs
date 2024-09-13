using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class defr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4033), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3953), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3964), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3966), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3968), new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3809), "c85f0352-3ff3-490d-8e34-389d9b1eb650" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3818), "b49de428-50b5-4c4c-bd51-4a81be1f2657" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3835), "70b35808-66b0-44b9-9c6f-4957e27a9ff5" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3847), "8d4dc911-fea0-422b-bb29-c9fb739f03cd" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3851), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3851), "eae47bea-ea0b-4297-a5c6-aa9d6c6b5509" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3928), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3930), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3932), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 43, 19, 354, DateTimeKind.Utc).AddTicks(3935), new DateTime(2024, 9, 1, 2, 43, 19, 354, DateTimeKind.Local).AddTicks(3933) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7226), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7088), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7107), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7115), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7122), new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6639), "aba416d6-746d-4099-9193-434e7c207366" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6671), "407d42d0-343b-433b-b430-3f4d9a41acbe" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6686), "23362f78-6cd7-4b79-bb1c-4354fe158bb7" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6718), "11c295b3-19d0-499e-b6f3-ec958a98ebe4" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6735), "242ca7cd-be27-44df-81b7-c18256c654db" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 31, 14, 367, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 8, 22, 16, 31, 14, 367, DateTimeKind.Local).AddTicks(7003) });
        }
    }
}
