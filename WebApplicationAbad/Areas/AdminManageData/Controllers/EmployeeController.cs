using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NuGet.Protocol;
using System.Net.Mail;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace WebApplicationAbad.Areas.AdminManageData.Controllers
{
    [Area("AdminManageData")]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        private readonly IHostingEnvironment host;

        public EmployeeController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext context)
        {
            this.work = work;
            this.host = host;
            this.context = context;
        }

        public IActionResult GetEmployeeIndex()
        {
            var employee = context.Employees.Where(b => !b.IsDelete).ToList();
            return View(employee);
        }

        public IActionResult GetCreateEmployee(int Id)
        {
            var FindId = context.Employees.Find(Id);

            if (FindId == null)
            {
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
                return View();
            }
            else
            {
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                return View(FindId);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCreateEmployee(Employee employee, int Id)
        {
            var FindId = context.Employees.Find(Id);
            if (FindId == null)
            {


                context.Employees.Add(employee);
                context.SaveChanges();
                var lastRow = context.Employees.OrderByDescending(x => x.Id).FirstOrDefault();
                EmployeePremotion employeePremotion = new EmployeePremotion
                {
                    EmployeeId = lastRow.Id

                };
                context.EmployeePremotion.Add(employeePremotion);
                context.SaveChanges();

                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                FindId.Name = employee.Name;
                FindId.Address = employee.Address;
                FindId.Email = employee.Email;
                FindId.Phone = employee.Phone;
                FindId.Password = employee.Password;
                context.Employees.Update(FindId);
                context.SaveChanges();
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
            }
            return RedirectToAction("GetCreateEmployee");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetEmployeeIndex(int Id)
        {
            var fintID = context.Employees.Find(Id);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                context.Employees.Update(fintID);
                context.SaveChanges();
            }
            return Redirect("GetEmployeeIndex");
        }


        public IActionResult GetPremotionEmployee(int Id)
        {
            var employee = context.Employees.Find(Id);
            ViewBag.PremotionAll = context.EmployeePremotion.FirstOrDefault(b => b.EmployeeId == Id);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPremtion(EmployeePremotion employee)
        {
            if (employee.Admin)
            {
                 employee.CoursesData = true;
                 employee.CoursesScheduless = true;
                 employee.CoursesStutes = true;
                 employee.Matdetory = true;
                 employee.ViewsNow = true;
                 employee.RequiredCourse = true;
                 employee.Article = true;
                 employee.Company = true;
                 employee.Contract = true;
                 employee.CompanyRequest = true;
                 employee.Studnt = true;
                 employee.CoursesType = true;
                 employee.TypePaid = true;
                 employee.EmployeePage = true;
                 employee.HomePage = true;
                 employee.Room = true;
                 employee.Complaints = true;
				 employee.Zoom = true;
                employee.MessageReapet = true;
                employee.ButtonInvoice = true;



            }
            context.EmployeePremotion.Update(employee);
            context.SaveChanges();
            return Redirect($"GetPremotionEmployee/{employee.EmployeeId}");
        }


        public IActionResult GetLoginEmployee()
        {


            return View();
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetLoginEmployee(Employee employee)
        {
            Employee? emaployee = context.Employees.FirstOrDefault(s => s.Email == employee.Email! && s.Password == employee.Password && !s.IsDelete);
            if (emaployee != null)
            {
                DateTime expiryTime = DateTime.Now.AddHours(9);
            
                Response.Cookies.Append("EmployeeId", emaployee.Token.ToString(), new CookieOptions
                {
                    Expires = expiryTime,
                    HttpOnly = false,
				});

                ViewBag.EmployeeID = emaployee.Id;
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return View("GetLoginEmployee");
        }


        [HttpGet]
        public IActionResult CheckEmail(string email)
        {
            var findEmail = context.Employees.FirstOrDefault(b => b.Email == email);
            if (findEmail == null)
            {
                return Json(false);
            }
            return Json(true);
        }


        public IActionResult HomePageIndex()
        {
            var allData = context.HomeScreens.ToList();
            return View(allData);
        }


        public IActionResult GetHomeUpdate(int Id)
        {
            var getHome = context.HomeScreens.Find(Id);
            return View(getHome);
        }


        [HttpPost]
        public IActionResult GetHomeUpdate(HomeScreen homeScreen,int Id)
        {
            var FindId = context.HomeScreens.Find(Id);
            if (homeScreen.FormFiles != null && homeScreen.FormFiles.Length > 0)
            {

                string Upload = Path.Combine(host.WebRootPath, "Admin", "HomeScreen");
                if (!Directory.Exists(Upload))
                {
                    Directory.CreateDirectory(Upload);
                }
                string fileName = homeScreen.FormFiles.FileName;
                string newFileName = homeScreen.Id.ToString();
                string newFilePath = Path.Combine(Upload, homeScreen.FormFiles.FileName);
                using (FileStream fileStream = new FileStream(newFilePath, FileMode.Create))
                {
                    homeScreen.FormFiles.CopyTo(fileStream);
                }
                FindId.Image = fileName;
            }
            FindId.Title = homeScreen.Title;
            FindId.IsShowTitel = homeScreen.IsShowTitel;
            FindId.Description = homeScreen.Description;
            FindId.IsShowDes = homeScreen.IsShowDes;
            FindId.State = homeScreen.State;
            FindId.IsButton = homeScreen.IsButton;

            context.HomeScreens.Update(FindId);
            context.SaveChanges();

            return RedirectToAction("HomePageIndex");
        }


        [HttpGet]
        public IActionResult CheckEmailEmployee(string Mail)
        {
            try
            {
                string Email = Mail.ToLower();
                var St = context.Employees.FirstOrDefault(b => b.Email == Email);
                if (St != null && St.Email == Mail)
                {
                    string tokenLink = Url.Action("NewPasword", "Employee", new { area = "AdminManageData", Tokens = St.Token }, protocol: HttpContext.Request.Scheme);
                    string mailBody = $"يرجى النقر على الرابط التالي لإعادة تعيين كلمة المرور: {tokenLink}";

                    SendEmail(St.Email, "إعادة تعيين كلمة المرور", mailBody);

                    return Json(true);
                }

                return Json(false);
            }
            catch (Exception ex)
            {
                // Log the exception details
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"-----------------------------مشكله ارسال ايميل 1  ----------------------------------------\n");
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n {ex.InnerException}\n");
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"---------------------------------------------------------------------\n");

                return Json(false);

            }


        }


        private void SendEmail(string toEmail, string subject, string body)
        {
            try
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
                        UseDefaultCredentials = false
                    };

                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"-----------------------------مشكله ارسال ايميل 2 ----------------------------------------\n");
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n {ex.InnerException}\n");
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"---------------------------------------------------------------------\n");

      
            }
        }


        public IActionResult NewPasword(string Tokens)
        {
            var St = context.Employees.FirstOrDefault(v => v.Token == Tokens);
            if (St != null)
            {
                return View(St);
            }
            return Redirect("/Home/GetErorrView");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewPassword(Employee employee, string Token)
        {
            var St = context.Employees.FirstOrDefault(n => n.Token == Token);
            if (St != null)
            {
                St.Password = employee.Password;
                St.Token = Guid.NewGuid().ToString();
                context.Employees.Update(St);
                context.SaveChanges();
            }
            return RedirectToAction("GetLoginEmployee");
        }


    }


}
