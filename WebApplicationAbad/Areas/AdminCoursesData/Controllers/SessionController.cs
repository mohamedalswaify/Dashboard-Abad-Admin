using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class SessionController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public SessionController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;

        }


        public IActionResult GetListOfSession()
        {
            var sessionss = context.coursesSchedulesses.Where(b => b.CoursesIsonlineId == 2 && !b.IsDelete).ToList();
            return View(sessionss);
        }


        public void FilDataCoursess(int IdOnlin = 1)
        {
            var Online = context.CoursesSchedulesses.Where(b => !b.IsHide && !b.IsDelete && b.CoursesIsonlineId == 2);

            var onlineList = Online.Select(b => new
            {
                Id = b.Id,
                DisplayText = $"{b.StartDate:yyyy-MM-dd} - {b.CoursesData.HeaderAr}"
            }).ToList();

            // Create a SelectList using the list of anonymous objects
            SelectList select = new SelectList(onlineList, "Id", "DisplayText");

            ViewBag.FilDataCourses = select;


            List<SessionsWeek> SessionsWeek = context.SessionsWeeks.ToList();
            SelectList selectListItems = new SelectList(SessionsWeek, "Id", "Name", IdOnlin);
            ViewBag.Weeks = selectListItems;
        }



        [HttpGet]
        public IActionResult GetFilteredCoursesData(int weekId)
        {
            var filteredCoursesData = context.SessionsDays.Where(cd => cd.SessionsWeekId == weekId).ToList();
            var jsonData = filteredCoursesData.Select(item => new
            {
                value = item.Id,
                text = item.NameOfDay
            });

            return Json(jsonData);
        }


        public async Task<IActionResult> GetSessionCreate(int seccId, int DayId, string titleSition, bool isReplce)
        {
            string? EmployeeId = Request.Cookies["EmployeeId"];

            Employee? employee = await context.Employees
                .FirstOrDefaultAsync(b => b.Token == EmployeeId);

            // Create a new session record
            SessionsRecord sessionsRecord = new SessionsRecord
            {
                CoursesSchedulessId = seccId,
                SessionsDayId = DayId,
                Title = Uri.UnescapeDataString(titleSition), // فك ترميز العنوان,
                UserEmail = employee.Email,
                IsReplcesing = isReplce
            };

            // Add the new session record asynchronously
            work.sessionRecords.AddNewRow(sessionsRecord);

            return Ok();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SessionCreate(SessionsRecord sessionsRecord, int id)
        {
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);
            var FindId = work.sessionRecords.GetByID(id);
            FindId.SessionsDayId = sessionsRecord.SessionsDayId;
            FindId.Title = sessionsRecord.Title;
            FindId.UserCode = employee.Email;
            FindId.CreatedDate = DateTime.Now;
            work.sessionRecords.UpdateRow(FindId);
            ViewBag.coursesStatus = "Edit";
            ViewBag.BoolValue = false;
            TempData["successDat"] = "تم  التعديل بنجاح";
            return Redirect($"/AdminCoursesData/Session/DetalisSession/{FindId.CoursesSchedulessId}");
        }



        //Get page Insert Or Update
        public IActionResult Index(int id)
        {
            var FindId = work.sessionRecords.GetByID(id);
            FilDataCoursess(FindId.sessionsDay.SessionsWeekId);
            List<SessionsDay> sessionsDays = context.SessionsDays.Where(sd => sd.SessionsWeekId == FindId.sessionsDay.SessionsWeekId).ToList();
            SelectList selectListItems = new SelectList(sessionsDays, "Id", "NameOfDay", FindId.SessionsDayId);
            ViewBag.Days = selectListItems;
            return View(FindId);
        }


        public IActionResult DetalisSession(int id)
        {
            var CourseData = context.coursesSchedulesses.FirstOrDefault(b => b.Id == id);
            var FindId = work.sessionRecords.GetByID(id);

            if (FindId == null)
            {
                ViewBag.BoolValue = true;
                FilDataCoursess();
            }
            else
            {


                FilDataCoursess(FindId.sessionsDay.SessionsWeekId);
                List<SessionsDay> sessionsDays = context.SessionsDays.Where(sd => sd.SessionsWeekId == FindId.sessionsDay.SessionsWeekId).ToList();
                SelectList selectListItems = new SelectList(sessionsDays, "Id", "NameOfDay", FindId.SessionsDayId);
                ViewBag.Days = selectListItems;

                ViewBag.BoolValue = false;
            }
            return View(CourseData);


        }


        public IActionResult DeleteRow(int id)
        {
            try
            {
                var DeleteSession = context.SessionsRecords.FirstOrDefault(b => b.Id == id);
                context.SessionsRecords.Remove(DeleteSession);
                context.SaveChanges();
                return Ok(new { success = true });
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}

