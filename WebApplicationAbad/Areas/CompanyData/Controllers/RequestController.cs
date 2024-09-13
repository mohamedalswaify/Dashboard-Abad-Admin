using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplicationAbad.Areas.CompanyData.Controllers
{
    [Area("CompanyData")]
    public class RequestController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public RequestController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;
        }


        public IActionResult DownloadPdf()
        {

            // استعراض القائمة
            var requests = context.CompanyRequests.ToList();
            return View(requests);

        }


        // to download file  pdf
        public IActionResult DownloadFile(int id)
        {
            // استعراض معلومات الطلب
            var request = context.CompanyRequests.Find(id);
            if (request == null)
            {
                return NotFound();
            }

            // استعراض ملفات الطلب في الفولدر
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", request.RequestNumber);
            var files = Directory.GetFiles(folderPath);

            // افحص الملفات وحدد ملفًا للتنزيل (في هذا المثال نقوم باختيار أول ملف)
            if (files != null && files.Length > 0)
            {
                var filePath = files[0];
                var memory = new MemoryStream();
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    stream.CopyTo(memory);
                }
                memory.Position = 0;

                // إرسال الملف إلى المتصفح
                return File(memory, "application/pdf", Path.GetFileName(filePath));
            }
            else
            {
                // يتم التعامل مع الحالة حيث لا توجد ملفات في الفولدر.
                return NotFound(); // أو أي استجابة أخرى
            }
        }


        public IActionResult Details(int id) 
        {
            var reqest =context.CompanyRequests.Find(id);
            if (reqest == null)
            {
                return NotFound();
            }
        else
            {
                return View(reqest);
            }
        
       
        
        }

    }
}
