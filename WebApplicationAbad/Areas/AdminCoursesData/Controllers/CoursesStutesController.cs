using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class CoursesStutesController : Controller
    {

        protected readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public CoursesStutesController(IUnitOfWork work,ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;
        }

        
        public IActionResult GetCoursesStutesIndex()
        {
                var GetAllData = context.CoursesStatuses.Where(b => !b.IsDelete).ToList();
                return View(GetAllData);

        }


        public IActionResult GetCoursesStutesCretae(int id)
        {
            var FindId = work.CoursesStatus.GetByID(id);
            
            if (FindId == null) { 
                ViewBag.coursesStatus = "Submit";
                ViewBag.BoolValue = true;
            }
            else { 
                ViewBag.coursesStatus = "Edit";
                ViewBag.BoolValue = false;
                return View(FindId);

            }

            return View();
        }
      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesStutesCretae(CoursesStatus coursesStatus,int id)
        {
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            var FindId = work.CoursesStatus.GetByID(id);

            if (FindId == null)
            {
                coursesStatus.UserCode = employee.Email;
                coursesStatus.CreatedDate = DateTime.Now;
                work.CoursesStatus.AddNewRow(coursesStatus);
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                FindId.ArabicName = coursesStatus.ArabicName;
                FindId.EnglishName = coursesStatus.EnglishName;
                FindId.IsHide = coursesStatus.IsHide;
                FindId.LastUpdateUserCode = employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                work.CoursesStatus.UpdateRow(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
            }
            return RedirectToAction("GetCoursesStutesIndex");
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesStutesIndex(CoursesStatus coursesStatus, int id)
        {
            var fintID = work.CoursesStatus.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (fintID != null)
            {
                fintID.IsDelete = true;
                fintID.LastUpdateUserCode = employee.Email;
                fintID.LastUpdateDate= DateTime.Now;
                work.CoursesStatus.UpdateRow(fintID);
            }
            return Redirect("GetCoursesStutesIndex");
        }
    }
}
