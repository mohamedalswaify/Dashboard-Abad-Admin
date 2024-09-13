using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Macs;
using System.Data;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Transactions;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Areas.CompanyData.Models;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplicationAbad.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        [Obsolete]
        private readonly IHostingEnvironment host;

        [Obsolete]
        public HomeController(IUnitOfWork work, ApplicationDbContext context, IHostingEnvironment host)
        {
            this.work = work;
            this.context = context;
            this.host = host;
        }


        //Get Home Page

        //public IActionResult Index()
        //{
        //    return Redirect("https://abad-next.netlify.app/");
        //}



        public IActionResult Index()
        {
            var allData = context.CoursesSchedulesses.Where(b => !b.IsDelete && !b.IsHide).OrderBy(c => c.StartDate).ThenBy(c => c.StartTime).ToList();


            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;

            return View(allData);

        }

        public IActionResult FilterbyTypeCourses(int id)
        {

            if (id != 0)
            {
                var allData = context.CoursesSchedulesses.Where(b => !b.IsDelete && !b.IsHide && b.CoursesTypeCode == id).ToList();

                return View(allData);
            }
            else
                return View();

        }

        //Get Details Courses
        public IActionResult GetDetailsCourses(string? Id)
        {

            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now.AddDays(3));
            DateOnly dateCurrny = DateOnly.FromDateTime(DateTime.Now);

            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);

            if (studentIdString != null)
            {
                ViewBag.StudentId = studentIdString;
            }
            if (Id == null )
            {

                return NotFound();
            }

            var coursesSchedulesses = context.coursesSchedulesses.FirstOrDefault(a => a.TokenNumber == Id);

            var CoursenOline = context.coursesSchedulesses
            .Where(b => b.IsHide != true
                && b.IsDelete != true
                && b.CoursesIsonline.Id == 2
                && b.CoursesDataId == coursesSchedulesses.CoursesDataId
                && b.CoursesStatusId == 1)
             .AsEnumerable().Where(b => b.CalculatedEndDate >= dateCurrny).ToList();



            var CourseMantadory = context.coursesSchedulesses
            .Where(b => b.IsHide != true
                && b.IsDelete != true
                && b.CoursesIsonline.Id == 1
                && b.CoursesDataId == coursesSchedulesses.CoursesDataId
                && b.CoursesStatusId == 1)
             .AsEnumerable().Where(b => b.CalculatedEndDate >= dateCurrny).ToList();

            if (coursesSchedulesses == null)
            {
                return NotFound();
            }
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }

            ViewBag.Email = email;
            ViewBag.CoursenOline = CoursenOline;
            ViewBag.CourseMantadory = CourseMantadory;
            return View(coursesSchedulesses);

        }

        //Get Page Payment
        public IActionResult GetPayment(string? Id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
                return RedirectToAction("GetLogin");

            }

            else
            {
                ViewBag.IsAuthenticated = true;
            }
            if (Id == null )
            {

                return NotFound();
            }

            var coursesSchedulesses = context.coursesSchedulesses.FirstOrDefault(a => a.TokenNumber == Id);
            if (coursesSchedulesses == null)
            {
                return NotFound();
            }
            ViewBag.Email = email;
            ViewBag.StudntId = studentIdString;
            return View(coursesSchedulesses);

        }

        [HttpGet]
        public IActionResult AddedStudentToReseved()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }

            var StudentNow = context.ViewStudnts.Where(b => b.StudentId == studentIdString).ToList();

            foreach (var item in StudentNow)
            {
                context.Set<CoursesReserved>().Add(new CoursesReserved
                {
                    CoursesSchedulessId = item.CoursesSchedulessId,
                    StudentId = Convert.ToInt32(studentIdString),
                    PreDiscount = item.ViewsNow.PreDiscount,
                    Paidup = item.CoursesScheduless.Cost,
                    CreatedDate = DateTime.Now,
                    UserCode = studentIdString.ToString()
                });
                context.SaveChanges();
            }

            foreach (var item in StudentNow)
            {
                context.ViewStudnts.Remove(item);
            }
            ViewBag.Email = email;
            context.SaveChanges();
            return Json(true);
        }
        
        [HttpGet]
        public async Task<IActionResult> AddedStudentToResevedPayOnline()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            try
            {
                int studentId = Convert.ToInt32(Request.Cookies["StudentId"]);
                float fullAmount = 0;
                var StudentNow = context.ViewStudnts.Where(b => b.StudentId == studentIdString).ToList();
                foreach (var item in StudentNow)
                {
                    fullAmount += ((float)item.CoursesScheduless.Cost * 1.15f);
                }


                await PayWithoutSaveData(300);

                PayTabsCallbackModel result = PayTabsCallback();
                context.PayTabsCallbackModel.Add(result);
                await context.SaveChangesAsync();

                if (result.RespStatus == "A")
                {
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
                    {
                        ViewBag.IsAuthenticated = false;
                    }
                    else
                    {
                        ViewBag.IsAuthenticated = true;
                    }


                    foreach (var item in StudentNow)
                    {
                        context.Set<CoursesReserved>().Add(new CoursesReserved
                        {
                            CoursesSchedulessId = item.CoursesSchedulessId,
                            StudentId = Convert.ToInt32(studentIdString),
                            PreDiscount = item.ViewsNow.PreDiscount,
                            Paidup = item.CoursesScheduless.Cost,
                            CreatedDate = DateTime.Now,
                            UserCode = studentIdString.ToString()
                        });
                        context.SaveChanges();
                    }

                    foreach (var item in StudentNow)
                    {
                        context.ViewStudnts.Remove(item);
                    }
                    ViewBag.Email = email;
                    context.SaveChanges();
                }

                return RedirectToAction("GetHomePage");
            }
            catch (Exception)
            {
                // Log or handle the exception appropriately
                return RedirectToAction("ErrorPayment");
            }
        }


        public IActionResult GetPaymentViews(string? Id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            ViewBag.StudntId = studentIdString;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null!)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null!)
            {
                return RedirectToAction("GetLogin");

            }

            if (Id == null )
            {
                var GetView2 = context.ViewsNows.FirstOrDefault(a => a.IsOpen);
                var studntViews1 = context.ViewStudnts.Where(b => b.StudentId == studentIdString && b.ViewsNowId == GetView2.Id).ToList();
                return View(studntViews1);
            }

            var coursesSchedulesses = context.coursesSchedulesses.FirstOrDefault(a => a.TokenNumber == Id);
            var GetView = context.ViewsNows.FirstOrDefault(a => a.IsOpen);


            int StudentNow = context.ViewStudnts.Where(b => b.StudentId == studentIdString && b.CoursesSchedulessId == coursesSchedulesses.Id).Count();

            if (StudentNow == 0) {
                context.ViewStudnts.Add(new ViewStudnt
                {
                    StudentId = (int)studentIdString,
                    CoursesSchedulessId = coursesSchedulesses.Id,
                    ViewsNowId = GetView.Id

                });
                ViewBag.Email = email;
                context.SaveChanges();
            }

            var studntViews = context.ViewStudnts.Where(b => b.StudentId == studentIdString && b.ViewsNowId == GetView.Id).ToList();

            if (coursesSchedulesses == null)
            {
                return NotFound();
            }

            ViewBag.Email = email;

            ViewBag.StudentId = studentIdString;
            return View(studntViews);

        }

        public ActionResult RemoveViews(int? id)
        {

            var contextView = context.ViewStudnts.Find(id);
            context.ViewStudnts.Remove(contextView!);
            context.SaveChanges();
            return Redirect("/Home/GetPaymentViews");
        }

        public ActionResult RemoveAllViews()
        {
            int studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);

            var ViewsFast = context.ViewsNows.FirstOrDefault(m => m.IsOpen);

            var studntViews = context.ViewStudnts.Where(b => b.StudentId == studentIdString).ToList();

            foreach (var item in studntViews)
            {
                context.ViewStudnts.Remove(item);
            }
            context.SaveChanges();

            return Redirect("/Home/GetPaymentViews");
        }

        public ActionResult GetArticles()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;
            var articles = context.Article.Where(b => !b.IsDelete && !b.IsHide);
            return View(articles);
        }


        public ActionResult GetArticleType(int Id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;
            var articles = context.Article.Where(b => !b.IsDelete && !b.IsHide && b.CoursesTypeCode == Id);
            return View(articles);
        }

        public ActionResult GetReadArticle(int Id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;
            var ReadArticle = context.Article.Find(Id);
            return View(ReadArticle);
        }

        public IActionResult DownloadFile(int Id)
        {
            var sch = context.coursesSchedulesses.Find(Id);

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "CoursesDataFiles", sch.TokenNumber.ToString(), sch.TokenNumber.ToString());
            folderPath = Path.GetFullPath(folderPath);

            try
            {
                var files = Directory.GetFiles(folderPath);

                if (files != null && files.Length > 0)
                {
                    var filePath = files[0];

                    using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        if (fileStream.Length > 0)
                        {
                            var memory = new MemoryStream();

                            if (Path.GetExtension(filePath).ToLower() == ".zip")
                            {
                                // تعامل مع ملفات الـ Zip
                                using (var archive = new ZipArchive(memory, ZipArchiveMode.Create, true))
                                {
                                    var entry = archive.CreateEntry(Path.GetFileName(filePath));
                                    using (var entryStream = entry.Open())
                                    {
                                        fileStream.CopyTo(entryStream);
                                    }
                                }

                                memory.Position = 0;

                                // إضافة Header للتنزيل
                                Response.Headers.Add("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

                                return File(memory, "application/zip", Path.ChangeExtension(Path.GetFileName(filePath), "zip"));
                            }
                            else
                            {
                                // تعامل مع ملفات غير مضغوطة
                                fileStream.CopyTo(memory);
                                memory.Position = 0;

                                // إضافة Header للتنزيل
                                Response.Headers.Add("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));

                                return File(memory, "application/octet-stream", Path.GetFileName(filePath));
                            }
                        }
                        else
                        {
                            // الملف فارغ
                            return NotFound();
                        }
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة تحذير أو تسجيل للمساعدة في تحديد سبب الخطأ.
                Console.WriteLine(ex.Message);
                return BadRequest("حدث خطأ أثناء محاولة فتح الملف.");
            }
        }


        //Get request-company Page
        public IActionResult Getrequestcompany()
        {

            return View();

        }


        // Get contact Page
        public IActionResult Getcontact()
        {

            return View();

        }

        // Get Login Page
        public IActionResult GetLogin()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;
            // Check if RememberedEmail and RememberedPassword cookies exist
            string? rememberedEmail = Request.Cookies["RememberedEmail"];
            string? rememberedPassword = Request.Cookies["RememberedPassword"];

            // If both cookies exist, populate the login form fields
            if (!string.IsNullOrEmpty(rememberedEmail) && !string.IsNullOrEmpty(rememberedPassword))
            {
                // Pass the values to the view so they can be filled in the form
                ViewBag.RememberedEmail = rememberedEmail;
                ViewBag.RememberedPassword = rememberedPassword;
            }
            return View();
        }


        // Get sign Page
        public IActionResult GetSign()
        {
            return View();
        }


        //Verify your password and email to login
        [HttpPost]
        public IActionResult Login(Student model)
        {
          

            Student? student = context.Students.FirstOrDefault(s => s.Email == model.Email! && s.Password == model.Password! && s.IsBlock == false && s.IsDelete == false && s.IsLocked == false);

            if (student != null)
            {
                // Login successful, redirect to welcome page or perform other actions

                // Check if the "Remember Me" checkbox is checked
                if (ViewBag.isVal == true)
                {
                    // If checked, set cookies with the user's information
                    DateTime expiryTime2 = DateTime.Now.AddMonths(1);

                    Response.Cookies.Append("RememberedEmail", student.Email, new CookieOptions
                    {
                        Expires = expiryTime2,
                        HttpOnly = true
                    });

                    Response.Cookies.Append("RememberedPassword", student.Password, new CookieOptions
                    {
                        Expires = expiryTime2,
                        HttpOnly = true
                    });
                }


                // HttpContext.Session.SetInt32("StudentId", student.Id);
                DateTime expiryTime = DateTime.Now.AddMinutes(30); // Cookies expire after half an hour

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



                return RedirectToAction("GetHomePage");
            }

            // Invalid credentials, display error message
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return View("GetLogin", model);
        }


        //Get Home page for Dashboard Student
        public IActionResult GetHomePage()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                return RedirectToAction("GetLogin");
            }


            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.StudentId = studentIdString;

            var onlineCoursesCount = context.CoursesReserveds
                     .Count(b => b.StudentId == studentIdString
                      && b.CoursesScheduless.CoursesIsonlineId == 2
                     
                      && b.IsCompany == false
                    );

            var offlineCoursesCount = context.CoursesReserveds
                .Count(b => b.StudentId == studentIdString
                    && b.CoursesScheduless.CoursesIsonlineId == 1
                 
                    && b.IsCompany == false
             );


            var Student = context.Students.Find(studentIdString);

            var StudntOnline = context.CoursesReserveds
                .Where(a => a.StudentId == studentIdString
                 && a.CoursesScheduless.CoursesIsonlineId == 2)
                .OrderByDescending(c => c.CreatedDate).ToList();

            var StudnetMatodary = context.CoursesReserveds
              .Where(a => a.StudentId == studentIdString
               && a.CoursesScheduless.CoursesIsonlineId == 1)
              .OrderByDescending(c => c.CoursesScheduless.StartDate).ToList();


            ViewBag.Email = email;
            ViewBag.OnlineCoursesCount = onlineCoursesCount;
            ViewBag.OfflineCoursesCount = offlineCoursesCount;
            ViewBag.IsAuthenticated = true;

            ViewBag.OnlineCore = StudntOnline;
            ViewBag.MatodaryCore = StudnetMatodary;

            return View(Student);
        }



        //Get Courses offline for student
        public IActionResult offlineCourses(int id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            string? studentIdString = Request.Cookies["StudentId"];

            int studentId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(studentIdString) || !int.TryParse(studentIdString, out studentId))
            {
                // إحالة المستخدم إلى صفحة تسجيل الدخول
                return RedirectToAction("Index", "Sign_in_Student");
            }

            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.StudentId = studentId;
            ViewBag.IsAuthenticated = true;

            var student = context.CoursesReserveds
                .Where(b => b.StudentId == studentId
                && b.CoursesScheduless.CoursesIsonlineId == 1
                && b.CoursesScheduless.BranchId == 2
                && b.IsCompany == false)
                .ToList();

            var courseMantdaory = context.coursesSchedulesses.Find(id);

            return View(courseMantdaory);



        }




        //Get Courses online for student
        public IActionResult onlineCourses()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            string? studentIdString = Request.Cookies["StudentId"];



            int studentId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(studentIdString) || !int.TryParse(studentIdString, out studentId))
            {
                // إحالة المستخدم إلى صفحة تسجيل الدخول
                return RedirectToAction("Index", "Sign_in_Student");
            }

            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.StudentId = studentId;
            ViewBag.IsAuthenticated = true;

            var student = context.CoursesReserveds
                .Where(b => b.StudentId == studentId
                && b.CoursesScheduless.CoursesIsonlineId == 2
                && b.CoursesScheduless.BranchId == 2
                && b.IsCompany == false)
                .ToList();

            if (student != null)
            {
                return View(student);
            }

            // إذا لم يتم العثور على الطالب
            return RedirectToAction("GetLogin");

        }


        //عرض محاضرات الكورس
        public IActionResult GetSession(string id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            string? studentIdString = Request.Cookies["StudentId"];

            int studentId;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(studentIdString) || !int.TryParse(studentIdString, out studentId))
            {
                // إحالة المستخدم إلى صفحة تسجيل الدخول
                return RedirectToAction("Index", "Sign_in_Student");
            }

            ViewBag.Username = username;
            ViewBag.Email = email;
            ViewBag.StudentId = studentId;
            ViewBag.IsAuthenticated = true;
            if (id != null)
            {
                var sessions = context.SessionsRecords.Where(s => s.CoursesScheduless.TokenNumber == id).ToList();




                if (sessions != null)
                {
                    var sessionsRes = context.CoursesReserveds.FirstOrDefault(b => b.StudentId == studentId && b.CoursesScheduless.TokenNumber == id);
                    var session = context.SessionsRecords.Where(s => s.CoursesScheduless.TokenNumber == id).OrderByDescending(b=>b.Id).ToList();
                    if (sessionsRes.StutusPaidup == true)
                    {
                        return View(session);
                    }
                    else
                    {
                        var session2 = context.SessionsRecords
                         .Where(s => s.CoursesScheduless.TokenNumber == id).OrderByDescending(b=>b.Id).Take(1).ToList() ;

                        return View(session2);

                    }
                 
                }
            }

            return View();
        }


        // Logout for Student
        public IActionResult Logout()
        {
            // ضبط ViewBag
            ViewBag.IsAuthenticated = false;
            Response.Cookies.Delete("StudentId");
            Response.Cookies.Delete("Username");
            Response.Cookies.Delete("Email");
            Response.Cookies.Delete("RememberedEmail");
            Response.Cookies.Delete("RememberedPassword");
            return RedirectToAction("GetLogin");


        }



        //Get Page Sigun in Student
        [HttpPost]
        public IActionResult GetSign(Student student)
        {

            if (student != null)
            {
                if (!IsFieldUnique("Email", student.Email))
                {
                    ModelState.AddModelError("Email", "البريد الالكتروني موجود من قبل");
                }

                if (!IsFieldUnique("Idnumber", student.Idnumber))
                {
                    ModelState.AddModelError("Idnumber", "رقم الهوية موجود من قبل");
                }

                if (!IsFieldUnique("Phone", student.Phone))
                {
                    ModelState.AddModelError("Phone", "رقم الهاتف موجود من قبل");
                }
                student.UserCode = "0";
                if (ModelState.IsValid)
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    SendEmail(student.Email,"معهد اباد","مرحبا بكم في معهد اباد للتدريب");

                    TempData["successDat"] = "تم انشاء الحساب بنجاح";
                    return View("GetLogin");
                }
                else
                {
                    return View(student);
                }

            }
            else
            {
                return View();
            }
        }


        private bool IsFieldUnique(string fieldName, object value)
        {
            // Check if the specified field value is unique in the database
            switch (fieldName)
            {
                case "Email":
                    return !context.Students.Any(s => s.Email == (string)value);
                case "Idnumber":
                    return !context.Students.Any(s => s.Idnumber == (string)value);
                case "Phone":
                    return !context.Students.Any(s => s.Phone == (string)value);
                // Add cases for other fields as needed
                default:
                    return true; // Default to true if field name is not recognized
            }
        }


        private bool IsFieldUniqueExcludingCurrent(string fieldName, string value, int currentId)
        {
            if (fieldName == "Email")
            {
                return !context.Students.Any(x => x.Id != currentId && x.Email == value);
            }
            else if (fieldName == "Phone")
            {
                return !context.Students.Any(x => x.Id != currentId && x.Phone == value);
            }

            return true;
        }


        //Post  Request  طلب شركات   
        [HttpPost]
        public IActionResult Getrequestcompany(CompanyRequest companyRequest)
        {

            try
            {
                // Generate a unique identifier for the request (you may use other strategies)
                string requestNumber = Guid.NewGuid().ToString();

                // Set the identifier in the model
                companyRequest.RequestNumber = requestNumber;

                // Save the attached file to a folder with the request number
                string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", requestNumber);

                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                if (companyRequest.AttachedFile != null && companyRequest.AttachedFile.Length > 0)
                {
                    string fileName = Path.GetFileName(companyRequest.AttachedFile.FileName);
                    string filePath = Path.Combine(uploadFolder, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        companyRequest.AttachedFile.CopyTo(stream);
                    }
                }


                // Perform any additional processing or validation if needed
                // For example, you may want to save the request details to a database
                context.CompanyRequests.Add(companyRequest);
                context.SaveChanges();
                TempData["successDat"] = "تم ارسال الطلب بنجاح";
                ModelState.Clear();
                return View(new CompanyRequest());
            }
            catch (Exception )
            {
                // Handle exceptions, log errors, etc.
                TempData["DeleteData"] = "حدث خطأ أثناء معالجة الطلب";
                return View(companyRequest);
            }
        }



        public IActionResult CosrseRequired(string TokenNumber)
        {

            var Secc = context.CoursesData.FirstOrDefault(b => b.TokenNumber == TokenNumber);
            return View(Secc);
        }


        [HttpPost]
        public IActionResult AddCosrseRequired(RequiredCourse requiredcourse, string TokenNumber)
        {
            var code = context.coursesSchedulesses.FirstOrDefault(b => b.TokenNumber == TokenNumber);
            requiredcourse.CoursesDataId = code.Id;
            context.RequiredCourse.Add(requiredcourse);
            context.SaveChanges();
            return Redirect($"/Home/CosrseRequired?TokenNumber={TokenNumber}");
        }


        //View invoice to Student
        public IActionResult ViewInvoiceStudent(int id)
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                return RedirectToAction("GetLogin");

            }

            CoursesReserved reserved = context.CoursesReserveds.FirstOrDefault(c => c.Id == id);

            if (reserved != null)
            {
                if (reserved.StutusPaidup == true)
                {
                    ViewBag.PaidOK = true;
                }
                return View(reserved);
            }
            return NotFound();

        }


        //--------------------------------------------------------------------------------------------------------------------------------------------+


        public IActionResult ActionMand(int? Id)
        {
            int studentId = Convert.ToInt32(Request.Cookies["StudentId"]);
            var courseSchedule = context.coursesSchedulesses.Find(Id);

            CoursesReserved reservation = new CoursesReserved
            {
                CoursesSchedulessId = courseSchedule.Id,
                StudentId = studentId,
                Paidup = courseSchedule.Cost,
                StutusPaidup = false,
                CreatedDate = DateTime.Now,
                UserCode = studentId.ToString(),
            };
            work.CoursesReserved.AddNewRow(reservation);
            return RedirectToAction("GetHomePage");

        }


        public async Task<IActionResult> ConfirmCourse(int? Id)
        {
            try
            {
                int studentId = Convert.ToInt32(Request.Cookies["StudentId"]);

                var courseSchedule = await context.coursesSchedulesses
                    .Where(c => !c.IsDelete && !c.IsHide && c.Id == Id)
                    .FirstOrDefaultAsync();

                if (courseSchedule == null)
                {
                    // Handle case where courseSchedule is not found
                    return NotFound();
                }

                float fullAmount = ((float)courseSchedule.Cost * 1.15f);
                await PayWithoutSaveData(fullAmount,courseSchedule.CoursesData.HeaderAr);

                PayTabsCallbackModel result = PayTabsCallback();
                context.PayTabsCallbackModel.Add(result);
                await context.SaveChangesAsync();

                if (result.RespStatus == "A")
                {
                    CoursesReserved reservation = new CoursesReserved
                    {
                        CoursesSchedulessId = courseSchedule.Id,
                        StudentId = studentId,
                        Paidup = Convert.ToDecimal(fullAmount),
                        StutusPaidup = true,
                        Tax = (courseSchedule.Cost * Convert.ToDecimal(0.15)),
                        Payment = Convert.ToDecimal(fullAmount),
                        CreatedDate = DateTime.Now,
                        UserCode = studentId.ToString(),
                    };

                    work.CoursesReserved.AddNewRow(reservation);
                }

                return RedirectToAction("GetHomePage");
            }
            catch (Exception)
            {
                // Log or handle the exception appropriately
                return StatusCode(500, "An error occurred.");
            }
        }


        public async Task<string> PayWithoutSaveData(float Paid,string? describe="")
        {
            try
            {
                var transaction = new Areas.AdminCoursesData.Models.Transaction
                {
                    CartAmount = Paid,
                    CartCurrency = "SAR",
                    CartDescription = describe,
                    CartId = "CART#1001",
                    ProfileId = 52603,
                    ServerKey = "SMJNLZDJZK-HZWM9LBDBD-TRWL9RLR26",
                    TranClass = "ecom",
                    TranType = "sale",
                    ReturnURL = "https://localhost:7166/Home/PayTabsCallback",
                };

                string paymentUrl = "https://secure.paytabs.sa/payment/request";
                string jsonBody = JsonConvert.SerializeObject(transaction);
                var requestContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                using (var _httpClient = new HttpClient())
                {
                    _httpClient.DefaultRequestHeaders.Add("authorization", transaction.ServerKey);
                    var response = await _httpClient.PostAsync(paymentUrl, requestContent);
                    response.EnsureSuccessStatusCode();
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<PayTabsTransactionResponse>(responseContent);

                    if (result.IsSuccess)
                    {
                         Response.Redirect(result.redirect_url);
                        return "Success";
                    }
                    else
                    {
                        return "Error When Pay";
                    }
                   
                }
            }
            catch (HttpRequestException ex)
            {
                return $"HTTP Request Error: {ex.Message}";
            }
            catch (JsonException ex)
            {
                return $"JSON Deserialization Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"An unexpected error occurred: {ex.Message}";
            }
        }


        public PayTabsCallbackModel PayTabsCallback(string acquirerMessage = null!, string acquirerRRN = null!, string cartId = null!, string customerEmail = null!, string respCode = null!, string respMessage = null!, string respStatus = null!, string token = null!, string tranRef = null!)
        {
            PayTabsCallbackModel result = new PayTabsCallbackModel
            {
                AcquirerMessage = acquirerMessage,
                AcquirerRRN = acquirerRRN,
                CartId = cartId,
                CustomerEmail = customerEmail,
                RespCode = respCode,
                RespMessage = respMessage,
                RespStatus = respStatus,
                Token = token,
                TranRef = tranRef
            };

            return result;
        }
       
        
        public IActionResult EditProfile()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;
            var student = context.Students.Find(studentIdString);
            return View(student);
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProfile(Student student)
        {
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            var FindId = context.Students.Find(studentIdString);

            

            var studentnew = context.Students.Where(b => b.Email != FindId.Email || b.Phone != FindId.Phone).FirstOrDefault();
            // تحقق من وجود البريد الإلكتروني المكرر مع استثناء الحساب الحالي
            if (!IsFieldUniqueExcludingCurrent("Email", student.Email, FindId.Id))
            {
                ModelState.AddModelError("Email", "البريد الإلكتروني موجود من قبل");
            }

            // تحقق من وجود رقم الهاتف المكرر مع استثناء الحساب الحالي
            if (!IsFieldUniqueExcludingCurrent("Phone", student.Phone, FindId.Id))
            {
                ModelState.AddModelError("Phone", "رقم الهاتف موجود من قبل");
            }



            if (ModelState.IsValid)
            {
                if (student.FormFiles != null && student.FormFiles.Length > 0)
                {
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "studentImage");
                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }
                    string fileName = student.FormFiles.FileName;
                    string newFileName = student.Id.ToString();
                    string newFilePath = Path.Combine(Upload, newFileName);


                    string[] existingFiles = { newFilePath + ".jpg", newFilePath + ".png" };
                    foreach (string existingFile in existingFiles)
                    {
                        if (System.IO.File.Exists(existingFile))
                        {
                            System.IO.File.Delete(existingFile);
                        }
                    }


                    newFilePath += Path.GetExtension(fileName);
                    using (FileStream fileStream = new FileStream(newFilePath, FileMode.Create))
                    {
                        student.FormFiles.CopyTo(fileStream);
                    }
                    FindId.Image = newFileName + Path.GetExtension(fileName);

                }
                FindId.ArabicName = student.ArabicName;
         
                FindId.Email = student.Email.Trim().ToLower();
                FindId.Phone = student.Phone;
                TempData["successDat"] = "تم التعديل بنجاح";
                work.Student.UpdateRow(FindId);
                return RedirectToAction("EditProfile");
            }
            else
            {
                return View(student);
            }
        }
       
        
        
        public IActionResult EditPassword()
        {
            string? username = Request.Cookies["Username"];
            string? email = Request.Cookies["Email"];
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || studentIdString == null)
            {
                ViewBag.IsAuthenticated = false;
            }
            else
            {
                ViewBag.IsAuthenticated = true;
            }
            ViewBag.Email = email;
            var St = context.Students.Find(studentIdString);
            return View(St);
        }
       
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPassword(Student student)
        {
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            var students = context.Students.Find(studentIdString);
                students.Password = student.Password;
                work.Student.UpdateRow(students);
                TempData["successDat"] = "تم تعديل كلمة المرور بنجاح";
                return RedirectToAction("EditPassword");
        }


        [HttpGet]
        public IActionResult CheckPassword(string Pass)
        {
            int? studentIdString = Convert.ToInt32(Request.Cookies["StudentId"]);
            var student = context.Students.Find(studentIdString);
            if (student.Password == Pass) {
                return Json(true);
            }
            return Json(false);

        }
       
        
        [HttpGet]
        public IActionResult CheckEmailStudent(string Mail)
        {
            try
            {
                string Email = Mail.ToLower();
                var St = context.Students.FirstOrDefault(b => b.Email == Email);

                if (St != null && St.Email == Mail)
                {
                    string tokenLink = Url.Action("NewPasword", "Home", new { Tokens = St.Token }, protocol: HttpContext.Request.Scheme);
                    string mailBody = $"يرجى النقر على الرابط التالي لإعادة تعيين كلمة المرور: {tokenLink}";

                    SendEmail(St.Email, "إعادة تعيين كلمة المرور", mailBody);

                    return Json(true);
                }

                return Json(false);
            }
            catch (Exception)
            {

                throw;
            }
           

        }
       
        
        private void SendEmail(string toEmail, string subject, string body)
        {
            using (var mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress("Starshieldsa1992@gmail.com");
                mailMessage.To.Add(toEmail);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("Starshieldsa1992@gmail.com", "vxwmpphzuhypxdrm"),
                    EnableSsl = true,
                    UseDefaultCredentials=false
            };

                smtpClient.Send(mailMessage);
            }
        }



        public IActionResult NewPasword(string Tokens)
        {
            var St = context.Students.FirstOrDefault(v => v.Token == Tokens);
            if (St != null)
            {
                return View(St);
            }
            return RedirectToAction("GetErorrView");

        }
       
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewPassword(Student student,string Token)
        {
            var St = context.Students.FirstOrDefault(n => n.Token == Token);
            if(St != null) { 
            St.Password = student.Password;
            St.Token=Guid.NewGuid().ToString();
            work.Student.UpdateRow(St);
            }
            return RedirectToAction("GetLogin");
        }
        
        
        public IActionResult GetErorrView()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Getcontact(Complaint complaint)
        {
            context.Complaints.Add(complaint);
            context.SaveChanges();
            return View();
        }



    }
}




