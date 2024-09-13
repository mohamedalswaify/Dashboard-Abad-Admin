using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class StudentsController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly IHostingEnvironment host;
        private readonly ApplicationDbContext application;

        public StudentsController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext application)
        {
            this.work = work;
            this.host = host;
            this.application = application;
        }


        public IActionResult Index()
        {
            var allData = application.Students.Where(b=>!b.IsDelete).ToList();
            return View(allData);
        }


        public IActionResult GetCreateStudent(int id)
        {
            var FindId = work.Student.GetByID(id);
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
        public IActionResult Index(Student student, int id)
        {
            var fintID = work.Student.GetByID(id);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                work.Student.UpdateRow(fintID);
            }
            return Redirect("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCreateStudent(Student student, int id)
        {
            string? Token = Request.Cookies["EmployeeId"];
            var Employee = application.Employees.FirstOrDefault(b => b.Token == Token);
            var FindId = work.Student.GetByID(id);
            var app = application.Students.OrderBy(m => m.Id).LastOrDefault();
            string file = string.Empty;
            string newfile = string.Empty;
            var apps = new Student();
            string Paths = string.Empty;
            if (FindId == null)
            {

                if (student.FormFiles != null && student.FormFiles.Length > 0)
                {
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "StudentImage");

                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }

                    file = student.FormFiles.FileName;

                    string extension = Path.GetExtension(student.FormFiles.FileName);

                    if (app != null)
                    {
                        newfile = (app.Id + 1).ToString() + extension;
                        Paths = Path.Combine(Upload, newfile);
                        student.FormFiles.CopyTo(new FileStream(Paths, FileMode.Create));
                        student.Image = newfile;
                    }
                    else
                    {
                        student.Email = student.Email.ToLower().Trim();
                        work.Student.AddNewRow(student);
                        apps = application.Students.OrderBy(m => m.Id).LastOrDefault();
                        newfile = apps.Id.ToString() + extension;
                        apps.Image = newfile;
                        Paths = Path.Combine(Upload, newfile);
                        student.FormFiles.CopyTo(new FileStream(Paths, FileMode.Create));
                        student.Image = newfile;
                        student.UserCode = Employee.Email;

                    }

                }
                if (app == null)
                {
                    student.Email = student.Email.ToLower().Trim();
                    work.Student.UpdateRow(apps);

                }
                else
                {
                    student.Email = student.Email.ToLower().Trim();
                    work.Student.AddNewRow(student);
                }
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
                return Redirect("Index");
            }

            //Update Data
            else
            {
                work.Student.UpdateRow(FindId);
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
                FindId.Idnumber = student.Idnumber;
                FindId.Email = student.Email.Trim().ToLower();
                FindId.Phone = student.Phone;
                FindId.Gender = student.Gender;
                FindId.BirthDate = student.BirthDate;
                FindId.Countries = student.Countries;
                FindId.Countries = student.Countries;
                FindId.Password = student.Password;
                FindId.EducationsType = student.EducationsType;
                FindId.City = student.City;
                FindId.Nots = student.Nots;
                FindId.IsBlock = student.IsBlock;
                FindId.IsLocked = student.IsLocked;
                FindId.LastUpdateUserCode = Employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                work.Student.UpdateRow(FindId);
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public IActionResult CheckData(string Email, string Phone, string Identfire)
        {
            var CheckDateModel = application.Students.FirstOrDefault(b => b.Email == Email || b.Phone == Phone || b.Idnumber == Identfire);
            if (CheckDateModel == null)
            {
                return Json(true);
            }
            return Json(false);
        }


        public IActionResult GetDetailsStudent(int id)
        {
            var StudentReserved =application.CoursesReserveds.Where(v=>v.StudentId==id).ToList();
            var OneStduent = application.Students.Find(id);
            ViewBag.StudentReserveds = StudentReserved;
            return View(OneStduent);
        } 


        [HttpGet]
        public ActionResult TransfarmStduent(int idResved, int NewSeccId)
        {
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = application.Employees.FirstOrDefault(b => b.Token == EmployeeId);
            try
            {
                DateTime DateNow = DateTime.Now;
                var SeIdNew = application.coursesSchedulesses.Find(NewSeccId);
                var ResvId = application.CoursesReserveds.FirstOrDefault(b => b.Id == idResved);
                var StudentId = application.Students.Find(ResvId.StudentId);


                decimal NewTax = SeIdNew.Cost * Convert.ToDecimal(1.15);
                decimal Diffrnce = ResvId.Payment - NewTax;

                if (ResvId.StutusPaidup == true)
                {
                    StudentId.Amount = ResvId.Payment;
                    application.Students.Update(StudentId);
                }
                var NewResvId = new CoursesReserved
                {
                    CoursesSchedulessId = NewSeccId,
                    Nots = $"تم نقل الطالب {ResvId.Student.ArabicName} من دورة " +
                    $"{ResvId.CoursesScheduless.CoursesData.HeaderAr} الى دورة " +
                    $"{SeIdNew.CoursesData.HeaderAr} بتاريخ " +
                    $"{DateNow} الموظف الذي قام بالنقل",
                    Payment = 0,
                    StutusPaidup = false,
                    Paidup = SeIdNew.Cost,
                    Discount = 0,
                    BalanceDue = 0,
                    StudentId = ResvId.StudentId,
                    UserCode = employee.Name,
                };

                application.Remove(ResvId);
                application.SaveChanges();

                application.Add(NewResvId);
                application.SaveChanges();


                application.MoveStudent.Add(new MoveStudent
                {
                    CoursesSchedulessId = ResvId.CoursesSchedulessId,
                    ToCourses = NewSeccId,
                    StudntId = StudentId.Id,
                    DateTraform = DateNow,
                    Nots = ResvId.Nots,
                    Amount = Diffrnce,
                    EmpId = 1
                });

                application.SaveChanges();



                return Json(true);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public IActionResult AddCourseToStduent(int SeccID, int StduentID,bool IsCompany ,int ContractID ,int ConpanyID)
        {
            try
            {
                string? EmployeeId = Request.Cookies["EmployeeId"];
                Employee employee = application.Employees.FirstOrDefault(b => b.Token == EmployeeId);
                var CoursSec = application.coursesSchedulesses.FirstOrDefault(b=>b.Id== SeccID);
                if (!IsCompany)
                {
                    var NewResvId = new CoursesReserved
                    {
                        CoursesSchedulessId = SeccID,
                        Payment = 0,
                        StutusPaidup = false,
                        Paidup = CoursSec.Cost,
                        Discount = 0,
                        BalanceDue = 0,
                        StudentId = StduentID,
                        UserCode = employee.Name,
                    };
                    work.CoursesReserved.AddNewRow(NewResvId);
                }
                else{
                    var NewResvId = new CoursesReserved
                    {
                        CoursesSchedulessId = SeccID,
                        Payment = CoursSec.Cost                                                                 ,
                        StutusPaidup = true,
                        Paidup = CoursSec.Cost,
                        Discount = 0,
                        BalanceDue = 0,
                        IsCompany = true,
                        ContractDatumId=ContractID,
                        StudentId = StduentID,
                        UserCode = employee.Name,
                    };
                    work.CoursesReserved.AddNewRow(NewResvId);
                }
                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }


        public IActionResult DeleteResved(int id)
        {
            var rsved = application.CoursesReserveds.FirstOrDefault(b => b.Id == id);
            work.CoursesReserved.DeleteRow(rsved);
            return Redirect($"AdminCoursesData/Students/GetDetailsStudent/{rsved.StudentId}");
        }


        [HttpGet]
        public IActionResult CheckDataEdit(string Email, string Phone, string Identfire, int IDs)
        {
            string email = Email.Trim().ToLower();
            var OldTraner = application.Students.Find(IDs);
            if (OldTraner.Idnumber == Identfire && OldTraner.Phone == Phone && OldTraner.Email == email)
            {
                return Json(true);
            }


            var Traner = application.Students.Where(b => b.Id != IDs).FirstOrDefault(b =>
            b.Email == email || b.Phone == Phone || b.Idnumber == Identfire);

            if (Traner != null)
            {

                if (Traner.Email == email)
                {
                    return Json(false);
                }
                if (Traner.Phone == Phone)
                {
                    return Json(false);
                }
                if (Traner.Idnumber == Identfire)
                {
                    return Json(false);
                }

            }
            return Json(true);
        }

    }


}