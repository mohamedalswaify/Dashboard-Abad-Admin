using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]

    public class RequiredCourseController : Controller
    {
        protected readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public RequiredCourseController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;
        }

        public IActionResult RequiredCourseIndex()
        {
            var Reqiured = context.RequiredCourse.OrderByDescending(b => b.DateNw).ToList();
            return View(Reqiured);
        }

        public IActionResult GetRequiredCourseDetils(int id)
        {
            var CouresRe = context.RequiredCourse.Find(id);
            return View(CouresRe);
        }
    }
}
