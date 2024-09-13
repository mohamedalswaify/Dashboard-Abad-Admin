using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;

namespace WebApplicationMasartk.Areas.StudentCourses.Controllers
{
    [Area("StudentCourses")]
    public class Sign_in_StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Sign_in_StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(Student model)
        {
            Student student = _context.Students.FirstOrDefault(s => s.Email == model.Email! && s.Password == model.Password! && s.IsBlock==false && s.IsDelete==false &&s.IsLocked==false);

            if (student != null)
            {
                // Login successful, redirect to welcome page or perform other actions

                // HttpContext.Session.SetInt32("StudentId", student.Id);
                DateTime expiryTime = DateTime.Now.AddMinutes(30); // انتهاء صلاحية الكوكيز بعد نصف ساعة

                Response.Cookies.Append("StudentId", student.Id.ToString(), new CookieOptions
                {
                    Expires = expiryTime,
                    HttpOnly = true
                });

                Response.Cookies.Append("Username", student.UserCode!, new CookieOptions
                {
                    Expires = expiryTime,
                    HttpOnly = true
                });

                Response.Cookies.Append("Email", student.Email!, new CookieOptions
                {
                    Expires = expiryTime,
                    HttpOnly = true
                });



                return RedirectToAction("Index", "HomeStudent");
            }

            // Invalid credentials, display error message
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return View("Index",model);
        }


        public IActionResult ForgotPassword()
        {
            return View();
        }

    }
}
