using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class RoomController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        public RoomController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;
        }


        public IActionResult Index()
        {
            var allData=context.Rooms.Where(w=>!w.IsDelete).ToList();
            return View(allData);
        }


        public IActionResult Create(string Token)
        {

            var FindId = context.Rooms.FirstOrDefault(b=>b.Token==Token);

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
        public IActionResult Create(Room room, string Token)
        {
            string? Tokens = Request.Cookies["EmployeeId"];
            var Employee = context.Employees.FirstOrDefault(b => b.Token == Tokens);
            var FindId =context.Rooms.FirstOrDefault(b=>b.Id== room.Id);
            if (FindId == null)
            {
                room.UserCode = Employee.Email;
                room.CreatedDate = DateTime.Now;
                context.Rooms.Add(room);
                
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                FindId.RoomNameAR = room.RoomNameAR;
                FindId.RoomNameEN = room.RoomNameEN;
                FindId.IsHide = room.IsHide;
                FindId.LastUpdateUserCode = Employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                context.Rooms.Update(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Room room, string Token)
        {

            var fintID = context.Rooms.FirstOrDefault(b=>b.Token==Token);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                context.Rooms.Update(fintID);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Details (string Token)
        {
            var RoomDate = context.Rooms.FirstOrDefault(b => b.Token == Token);
            return View(RoomDate);
        }



    }
}
