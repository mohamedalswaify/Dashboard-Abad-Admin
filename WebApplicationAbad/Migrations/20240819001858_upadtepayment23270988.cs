using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplicationAbad.Migrations
{
    /// <inheritdoc />
    public partial class upadtepayment23270988 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "ArabicName", "CreatedDate", "EnglishName", "FacabookUrl", "InstagramUrl", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "Location", "Phone", "Phone2", "TwitterUrl", "UserCode", "WebsiteUrl", "WhatsApp" },
                values: new object[] { 1, null, "الرياض", new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3726), "Riyadh", null, null, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3727), 1, null, null, null, null, 1, null, null });

            migrationBuilder.InsertData(
                table: "ContractStatuses",
                columns: new[] { "Code", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "مفعل", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3856), "Active", false, null, null, 111 },
                    { 2, "غير مفعل", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3859), "Not Active", false, null, null, 111 }
                });

            migrationBuilder.InsertData(
                table: "CoursesIsonlines",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "حضوري", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3809), "offline", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3809), "111", "111" },
                    { 2, "أون لاين", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3811), "online", null, null, "111" }
                });

            migrationBuilder.InsertData(
                table: "CoursesStatuses",
                columns: new[] { "Id", "ArabicName", "CreatedDate", "EnglishName", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "UserCode" },
                values: new object[,]
                {
                    { 1, "مفتوحه", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3776), "opened", false, false, new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3777), "111", "111" },
                    { 2, "مغلقه", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3779), "clossed", false, false, new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3780), "111", "111" },
                    { 3, "منتهيه", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3789), "ended", false, false, new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3789), "111", "111" },
                    { 4, "ملغاه", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3791), "cancelled", false, false, new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3791), "111", "111" }
                });

            migrationBuilder.InsertData(
                table: "CoursesTypes",
                columns: new[] { "Code", "ArabicName", "CreatedDate", "EnglishName", "Image", "IsDelete", "IsHide", "LastUpdateDate", "LastUpdateUserCode", "TokenNumber", "UserCode", "filt" },
                values: new object[,]
                {
                    { 1, "أمن المعلومات", new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3665), "Information Security", null, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3677), null, "3147ca37-5c4e-432e-95eb-2e8ad179e11c", null, 0 },
                    { 2, "إدارة أعمال", new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3686), "Business Management", null, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3686), null, "9e87980f-2492-4676-9c7b-26cd938ed495", null, 0 },
                    { 3, "برمجـــــــة", new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3689), "Programming", null, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3689), null, "b257079b-b5ba-4c92-b332-a2c268264466", null, 0 },
                    { 4, "شبكـــــات", new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3691), "Networking", null, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3691), null, "2f68c658-5f55-40e3-a395-2e7351a6ae68", null, 0 },
                    { 5, "إدارة خوادم وسـيرفرات", new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3694), "Server Management", null, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3694), null, "8724ecb0-81b3-4c4c-b811-9f3bde9f0214", null, 0 }
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
                    { 1, "كاش", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3749), "Cash", false, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3746), null, "111" },
                    { 2, "شبكه", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3751), "network", false, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3750), null, "111" },
                    { 3, "تمارا", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3753), "Tamara", false, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3752), null, "111" },
                    { 4, "تابي", new DateTime(2024, 8, 19, 0, 18, 55, 807, DateTimeKind.Utc).AddTicks(3756), "tabby", false, false, false, new DateTime(2024, 8, 19, 3, 18, 55, 807, DateTimeKind.Local).AddTicks(3755), null, "111" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
