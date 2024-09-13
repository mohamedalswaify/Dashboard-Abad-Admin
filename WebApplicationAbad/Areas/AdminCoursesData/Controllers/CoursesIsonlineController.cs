using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class CoursesIsonlineController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public CoursesIsonlineController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;
        }


        public IActionResult GetCoursesIsonlineIndex()
        {
                var allData = context.CoursesIsonlines.Where(b => !b.IsDelete).ToList();
                return View(allData);

        }


        public IActionResult GetCoursesIsonlineCreate(int id)
        {
            var FindId = work.CoursesIsonline.GetByID(id);

            if (FindId == null)
            {
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                return View(FindId);
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesIsonlineCreate(CoursesIsonline coursesIsonline,int id)
        {

            var FindId = work.CoursesIsonline.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (FindId == null)
            {
                coursesIsonline.UserCode = employee.Email;
                coursesIsonline.CreatedDate = DateTime.Now;
                work.CoursesIsonline.AddNewRow(coursesIsonline);
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                FindId.ArabicName = coursesIsonline.ArabicName;
                FindId.EnglishName = coursesIsonline.EnglishName;
                FindId.IsHide = coursesIsonline.IsHide;
                FindId.LastUpdateUserCode = employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                work.CoursesIsonline.UpdateRow(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
            }
            return RedirectToAction("GetCoursesIsonlineIndex");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesIsonlineIndex(CoursesIsonline coursesIsonline, int id)
        {

            var fintID = work.CoursesIsonline.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (fintID !=null)
            {
                fintID.IsDelete = true;
                fintID.LastUpdateUserCode = employee.Email;
                fintID.LastUpdateDate = DateTime.Now;
                work.CoursesIsonline.UpdateRow(fintID);
            }
            return Redirect("GetCoursesIsonlineIndex");
        }

    }
}
