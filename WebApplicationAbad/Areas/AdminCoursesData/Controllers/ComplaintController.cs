using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]

    public class ComplaintController : Controller
    {
        private readonly ApplicationDbContext context;

        public ComplaintController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.context = context;
        }


        public ActionResult Index()
        {
            var allData = context.Complaints.Where(b => b.Stutes == 0).ToList();
            return View(allData);
        }


        public IActionResult GetContent(int id)
        {
            var GetCop = context.Complaints.Find(id);
            GetCop.Stutes = 1;

            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);
            GetCop.UserEmail = employee.Email;
            GetCop.Dateupdate = DateTime.Now;
            context.Complaints.Update(GetCop);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult GetArchve(int id)
        {
            var GetCop = context.Complaints.Find(id);
            GetCop.Stutes = 2;

            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);
            GetCop.UserEmail = employee.Email;
            GetCop.Dateupdate = DateTime.Now;
            context.Complaints.Update(GetCop);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {

            var GetCop = context.Complaints.Find(id);
            GetCop.IsDelete = true;

            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);
            GetCop.UserEmail = employee.Email;
            GetCop.Dateupdate = DateTime.Now;

            context.Complaints.Update(GetCop);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult IGetNots(int id)
        {
            var GetCop = context.Complaints.Find(id);
            return Json(GetCop.Nots);
        }


    }
}
