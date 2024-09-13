
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Data;

namespace WebApplicationAbad.Areas.CampsCourses.Controllers
{
    [Area("CampsCourses")]
    public class CampController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // الحصول على قائمة المعسكرات
            var camps = await _context.CampsModels.OrderByDescending(c => c.Id).ToListAsync();

            // استعلام عدد الزوار (بافتراض أنك تخزن عدد الزوار في جدول Visitors)
            var visitor = await _context.VisitorCounts.FirstOrDefaultAsync();

            // تخزين عدد الزوار في ViewBag
            ViewBag.VisitorCount = visitor?.Count ?? 0;

            // استعلام عدد الزوار (بافتراض أنك تخزن عدد الزوار في جدول article)
            var article = await _context.ArticleViewCounts.FirstOrDefaultAsync();

            // تخزين عدد الزوار في ViewBag  article
            ViewBag.ArticleViewCounts = article?.Count ?? 0;


            // تمرير المعسكرات إلى الـ View
            return View(camps);
        }


        public IActionResult ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var camps = _context.CampsModels.OrderByDescending(c => c.Id).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Camps");

                // Set headers
                worksheet.Cells[1, 1].Value = "Serial";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "Email";
                worksheet.Cells[1, 4].Value = "Education";
                worksheet.Cells[1, 5].Value = "Phone Number";
                worksheet.Cells[1, 6].Value = "Type Course";
                worksheet.Cells[1, 7].Value = "Created Date";
                worksheet.Cells[1, 8].Value = "Time";
                worksheet.Cells[1, 9].Value = "IsPayment";

                // Fill data
                for (int i = 0; i < camps.Count; i++)
                {
                    var camp = camps[i];
                    worksheet.Cells[i + 2, 1].Value = i + 1; // Serial Number
                    worksheet.Cells[i + 2, 2].Value = camp.Name;
                    worksheet.Cells[i + 2, 3].Value = camp.Email;
                    worksheet.Cells[i + 2, 4].Value = camp.Education;
                    worksheet.Cells[i + 2, 5].Value = camp.PhoneNumber;
                    worksheet.Cells[i + 2, 6].Value = camp.TypeCourse;
                    worksheet.Cells[i + 2, 7].Value = camp.CreatedCode.ToString("yyyy-MM-dd");
                    worksheet.Cells[i + 2, 8].Value = camp.CreatedCode.ToString("HH:mm");
                    worksheet.Cells[i + 2, 9].Value = camp.IsPayment? "Pay" : "غير دافع";
                }

                // Convert to a byte array and return as a file
                var stream = new MemoryStream(package.GetAsByteArray());
                var fileName = "CampsData.xlsx";
                var mimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                return File(stream, mimeType, fileName);
            }
        }



        [HttpPost]
        public IActionResult UpdatePaymentStatus(int id, bool isPayment)
        {
            var item = _context.CampsModels.FirstOrDefault(c => c.Id == id);

            if (item == null)
            {
                return NotFound(); // أو يمكنك إرجاع رسالة خطأ حسب الحاجة
            }

            item.IsPayment = isPayment;
            _context.SaveChanges();

            return RedirectToAction("Index"); // إعادة التوجيه إلى الصفحة الرئيسية أو إلى صفحة أخرى حسب الحاجة
        }
    }
}
