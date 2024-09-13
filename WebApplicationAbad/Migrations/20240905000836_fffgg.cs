using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class fffgg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleViewCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleViewCounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7780), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7272), "06e8286b-139a-4bd6-bf0c-11ab6479ab18" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7299), "11575eee-1aef-44df-97cb-687b5dc3b30f" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7310), "b1614dac-daed-498d-8669-46c8b0c21390" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7335), "9eb3f2ca-0de3-4a65-b1a6-309f6a40dd04" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7343), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7344), "1bb284ac-2ac7-4dd2-8bff-b3b5f502fc7e" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7547), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 8, 31, 830, DateTimeKind.Utc).AddTicks(7565), new DateTime(2024, 9, 5, 3, 8, 31, 830, DateTimeKind.Local).AddTicks(7563) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleViewCounts");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6938), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7116), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7002), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6842), "a40b0138-6bbc-4f59-b069-fa1597f2a96c" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6850), "6584cc5c-ba38-47c3-831c-43a34150028b" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6853), "70515b10-7069-4aed-96a0-6da43ea37877" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6869), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6870), "972b6c8c-acbd-4c40-bfc6-af73dc35dd52" });

            migrationBuilder.UpdateData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastUpdateDate", "TokenNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6893), "daa7c775-fe4d-4eb3-93e7-75467d589db5" });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 8, 31, 23, 58, 28, 425, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 9, 1, 2, 58, 28, 425, DateTimeKind.Local).AddTicks(6979) });
        }
    }
}
