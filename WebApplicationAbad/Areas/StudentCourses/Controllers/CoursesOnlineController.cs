using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Data;

namespace WebApplicationMasartk.Areas.StudentCourses.Controllers
{
    [Area("StudentCourses")]
    public class CoursesOnlineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesOnlineController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            string? studentIdString = Request.Cookies["StudentId"];

            int studentId;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(studentIdString) || !int.TryParse(studentIdString, out studentId))
            {
                // إحالة المستخدم إلى صفحة تسجيل الدخول
                return RedirectToAction("Index", "Sign_in_Student");
            }

            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.StudentId = studentId;

            var student = _context.CoursesReserveds
                .Where(b => b.StudentId == studentId
                && b.CoursesScheduless.CoursesIsonlineId == 2
                && b.CoursesScheduless.BranchId == 2
                && b.IsCompany == false)
                .ToList();

            if (student != null)
            {
                return View(student);
            }
            // إذا لم يتم العثور على الطالب
            return RedirectToAction("Index", "Sign_in_Student");
        }


    }
}
