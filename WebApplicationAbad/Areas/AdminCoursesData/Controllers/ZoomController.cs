using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Globalization;
using System.Linq;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using ZoomNet;
using ZoomNet.Models;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
	[Area("AdminCoursesData")]
	public class ZoomController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;

        public ZoomController(IUnitOfWork work, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;

        }

        public IActionResult Index()
        {
            var sessions = context.SessionsRecords.ToList();
            return View(sessions);
        }

		public async Task FilDataCoursess(int IdOnlin = 1)
		{
			var Online = context.CoursesSchedulesses.Where(b =>  !b.IsDelete && b.CoursesIsonlineId == 2 && b.CoursesStatusId == 1)
                  .OrderBy(b => b.StartDate);

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

            string clientId = "yh9Y0wDJTb29TWkDnYIlNQ";
            string clientSecret = "TwNVxoae7NstgQN5c2skSXCR3xvVzKRC";
            string accountId = "JTNn6LRRTP6cEd1CZIyJGw";

            var connectionInfo = OAuthConnectionInfo.ForServerToServer(clientId, clientSecret, accountId);
            var zoomClient = new ZoomClient(connectionInfo);

            var usersResponse = await zoomClient.Users.GetAllAsync(UserStatus.Active, recordsPerPage: 100, page: 1);

            List<SelectListItem> userListItems = new List<SelectListItem>();

            foreach (var user in usersResponse.Records)
            {
                string fullName = $"{user.FirstName} {user.LastName}";
                string email = user.Email;

                userListItems.Add(new SelectListItem
                {
                    Text = fullName,
                    Value = email
                });
            }

            // Assuming you're using ASP.NET MVC or similar, you can pass the userListItems to ViewBag
            ViewBag.users = userListItems;


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


		//Get page Insert Or Update
		[HttpGet]
		public async Task< IActionResult> Create(int id)
		{
			var FindId = work.sessionRecords.GetByID(id);

			if (FindId == null)
			{
				ViewBag.coursesStatus = "ارسال";
				ViewBag.BoolValue = true;
			await	FilDataCoursess();
			}
			else
			{


                await FilDataCoursess(FindId.sessionsDay.SessionsWeekId);
				List<SessionsDay> sessionsDays = context.SessionsDays.Where(sd => sd.SessionsWeekId == FindId.sessionsDay.SessionsWeekId).ToList();
				SelectList selectListItems = new SelectList(sessionsDays, "Id", "NameOfDay", FindId.SessionsDayId);
				ViewBag.Days = selectListItems;
				ViewBag.coursesStatus = "تعديل";
				ViewBag.BoolValue = false;
				return View(FindId);
			}

			return View();



		}




        [HttpPost]
        public async Task<IActionResult> SessionCreate(string CoursesSchedulessId, string UserEmail, string listofData,SessionsRecord sessionsRecord)
        {
            string[] dateStrings = listofData.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<DateTime> datesList = new List<DateTime>();

            int courseId = Convert.ToInt32(CoursesSchedulessId);

            foreach (var dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString.Trim(), out DateTime date))
                {
                    datesList.Add(date);
                }
                else
                {
                    // تنفيذ إجراء إذا فشل تحويل التاريخ
                    // مثلاً: رسالة خطأ أو معالجة خاصة
                }
            }

            var course = context.CoursesSchedulesses.Find(courseId);
                if (course != null)
                {
                foreach (var item in datesList)
                {
                    
                string DateNow = item.ToString("yyyy-MM-dd") + " " + course.StartTime?.ToString(@"hh\:mm");
                    var defrenceTime = Math.Abs(course.StartTime.Value.Hour - course.EndTime.Value.Hour);
                    string clientId = "yh9Y0wDJTb29TWkDnYIlNQ";
                    string clientSecret = "TwNVxoae7NstgQN5c2skSXCR3xvVzKRC";
                    string accountId = "JTNn6LRRTP6cEd1CZIyJGw";

                    var connectionInfo = OAuthConnectionInfo.ForServerToServer(clientId, clientSecret, accountId);
                    var zoomClient = new ZoomClient(connectionInfo);

                     var startDateTime = DateTime.ParseExact(DateNow, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

                   
                    var durationInMinutes = defrenceTime * 60;
                    var timeZone = TimeZones.UTC;
                    var password = "P@ssw0rd";
                    var meetingSettings = new MeetingSettings
                    {
                        HostCanSaveVideoOrder = true,
                        RequestPermissionToUnmutePartecipants = true,
                        JoinBeforeHost = true,
                        MuteUponEntry = true,
                        Watermark = true,
                        Audio = AudioType.Both,
                        AutoRecording = AutoRecordingType.OnCloud,
                        AlternativeHosts = ""
                    };

                    var result = await zoomClient.Meetings.CreateScheduledMeetingAsync(
                        UserEmail,
                        $"{course.CoursesData.HeaderEn} - {course.StartDate?.ToString("yyyy-MM-dd")}",
                        "TestAgenda",
                        startDateTime,
                        durationInMinutes,
                        timeZone,
                        password,
                        meetingSettings
                    );
                    string urlMeating = result.JoinUrl;
                    string meatingId = result.Id.ToString();


                }


            }
                else
                {
                    return RedirectToAction("Index");
                }
                return View();
            }

          
        }
    }









