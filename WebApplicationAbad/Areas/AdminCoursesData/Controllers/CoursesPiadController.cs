using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class CoursesPiadController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public CoursesPiadController(IUnitOfWork work ,ApplicationDbContext context) {
            this.work = work;
            this.context = context;
        }

        public IActionResult GetCoursesPaidIndex()
        {
                var allData = context.TypePaidData.Where(b => !b.IsDelete).ToList();
                return View(allData);
        }

        public IActionResult GetCoursesPaidCreate(int id)
        {
            var FindId = work.TypePaid.GetByID(id);

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
        public IActionResult GetCoursesPaidCreate(TypePaid typePaid,int id)
        {
            var FindId = work.TypePaid.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (FindId == null)
            {
                typePaid.UserCode = employee.Email;
                typePaid.CreatedDate = DateTime.Now;
                work.TypePaid.AddNewRow(typePaid);
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                FindId.ArabicName = typePaid.ArabicName;
                FindId.EnglishName = typePaid.EnglishName;
                FindId.IsHide = typePaid.IsHide;
                FindId.IsLocked=typePaid.IsLocked;
                FindId.LastUpdateUserCode = employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                work.TypePaid.UpdateRow(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
            }
            return RedirectToAction("GetCoursesPaidIndex");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesPaidIndex(TypePaid coursesStatus, int id)
        {
            var fintID = work.TypePaid.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (fintID != null)
            {
                fintID.IsDelete = true;
                fintID.LastUpdateUserCode = employee.Email;
                fintID.LastUpdateDate = DateTime.Now;
                work.TypePaid.UpdateRow(fintID);
            }
            return Redirect("GetCoursesPaidIndex");

        }

    }
}
