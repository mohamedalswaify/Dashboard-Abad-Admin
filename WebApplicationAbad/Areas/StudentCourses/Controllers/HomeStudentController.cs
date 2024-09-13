using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Data;

namespace WebApplicationAbad.Areas.StudentCourses.Controllers
{
    [Area("StudentCourses")]
    public class HomeStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeStudentController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString =Convert.ToInt32( Request.Cookies["StudentId"]);

            int studentId;

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(studentIdString) || !int.TryParse(studentIdString, out studentId))
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString==null )
            {
                // إحالة المستخدم إلى صفحة تسجيل الدخول
                return RedirectToAction("Index", "Sign_in_Student");
            }

            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.StudentId = studentIdString;

            var onlineCoursesCount = _context.CoursesReserveds
                     .Count(b => b.StudentId == studentIdString
                      && b.CoursesScheduless.CoursesIsonlineId == 2
                      && b.CoursesScheduless.BranchId == 2
                      && b.IsCompany == false
                    );

            var offlineCoursesCount = _context.CoursesReserveds
                .Count(b => b.StudentId == studentIdString
                    && b.CoursesScheduless.CoursesIsonlineId == 1
                    && b.CoursesScheduless.BranchId == 2
                    && b.IsCompany == false
                );

            ViewBag.OnlineCoursesCount = onlineCoursesCount;
            ViewBag.OfflineCoursesCount = offlineCoursesCount;

            return View();
        }


    }
}
