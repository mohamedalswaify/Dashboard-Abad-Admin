using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment23270 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContractStatuses",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoursesIsonlines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoursesStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoursesTypes",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HomeScreens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SerivesModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypePaidData",
                keyColumn: "Id",
                keyValue: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "ArabicName", "CreatedDate", "EnglishName", "FacabookUrl", "InstagramUrl", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "Location", "Phone", "Phone2", "TwitterUrl", "UserCode", "WebsiteUrl", "WhatsApp" },
                values: new object[] { 1, null, "الرياض", new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4225), "Riyadh", null, null, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4225), 1, null, null, null, null, 1, null, null });

            migrationBuilder.InsertData(
                table: "ContractStatuses",
                columns: new[] { "Code", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "مفعل", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4376), "Active", false, null, null, 111 },
                    { 2, "غير مفعل", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4378), "Not Active", false, null, null, 111 }
                });

            migrationBuilder.InsertData(
                table: "CoursesIsonlines",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "حضوري", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4319), "offline", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4319), "111", "111" },
                    { 2, "أون لاين", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4322), "online", null, null, "111" }
                });

            migrationBuilder.InsertData(
                table: "CoursesStatuses",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "مفتوحه", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4270), "opened", false, false, new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4271), "111", "111" },
                    { 2, "مغلقه", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4273), "clossed", false, false, new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4273), "111", "111" },
                    { 3, "منتهيه", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4275), "ended", false, false, new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4275), "111", "111" },
                    { 4, "ملغاه", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4277), "cancelled", false, false, new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4278), "111", "111" }
                });

            migrationBuilder.InsertData(
                table: "CoursesTypes",
                columns: new[] { "Code", "ArabicName", "CreatedDate", "EnglishName", "Image", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "TokenNumber", "UserCode", "filt" },
                values: new object[,]
                {
                    { 1, "أمن المعلومات", new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4146), "Information Security", null, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4158), null, "ed29e39c-5605-4fdc-a3d7-eada093ca61b", null, 0 },
                    { 2, "إدارة أعمال", new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4171), "Business Management", null, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4172), null, "30abfb9c-60e2-4b9a-9de7-cfeec569fec0", null, 0 },
                    { 3, "برمجـــــــة", new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4174), "Programming", null, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4175), null, "d6f21a4d-22e7-4ef8-b657-9a5fca67f255", null, 0 },
                    { 4, "شبكـــــات", new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4177), "Networking", null, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4177), null, "0f64e1a9-6ee0-4d0f-907c-1c56e3966de3", null, 0 },
                    { 5, "إدارة خوادم وسـيرفرات", new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4189), "Server Management", null, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4189), null, "c90a8288-2373-4af8-8ad1-532adccd94e9", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "HomeScreens",
                columns: new[] { "Id", "Description", "Image", "IsButton", "IsShowDes", "IsShowTitel", "State", "Title" },
                values: new object[] { 1, "معهد شبكة آباد للتدريب من المعاهد الرائدة في تقديم الدورات التطويرية المتخصصة في تقنية المعلومات.", "banner.webp", true, true, true, true, "مرحبا بكم في آباد للتدريب" });

            migrationBuilder.InsertData(
                table: "SerivesModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "عرض سعر" },
                    { 2, "طلب عقد" },
                    { 4, "اعاده الاتصال" },
                    { 5, "طلب معلومات اضافية'" },
                    { 6, "مناقصة" },
                    { 7, "طلب زيارة" },
                    { 8, "اخري" }
                });

            migrationBuilder.InsertData(
                table: "TypePaidData",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "IsHide", "IsLocked", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "كاش", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4247), "Cash", false, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4243), null, "111" },
                    { 2, "شبكه", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4249), "network", false, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4248), null, "111" },
                    { 3, "تمارا", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4251), "Tamara", false, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4250), null, "111" },
                    { 4, "تابي", new DateTime(2024, 8, 19, 0, 5, 55, 257, DateTimeKind.Utc).AddTicks(4253), "tabby", false, false, false, new DateTime(2024, 8, 19, 3, 5, 55, 257, DateTimeKind.Local).AddTicks(4251), null, "111" }
                });
        }
    }
}
