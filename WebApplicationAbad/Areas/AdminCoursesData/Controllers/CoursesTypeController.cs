using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Repository.RepositoryInterface;
using System.IO;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using WebApplicationAbad.Data;

using System.IO.Pipes;
using System.Linq;
using System.Text;
using WebApplicationAbad.Areas.AdminManageData.Data;

namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{

    [Area("AdminCoursesData")]

    public class CoursesTypeController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly IHostingEnvironment host;
        private readonly ApplicationDbContext application;

        public CoursesTypeController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext application)
        {
            this.work = work;
            this.host = host;
            this.application = application;
        }


        public IActionResult GetCoursesTypeIndex()
        {
                var GetAllData = application.CoursesTypes.Where(b => !b.IsDelete).ToList();
                return View(GetAllData);
        }


        public IActionResult GetCoursesTypeCreate(int id)
        {
            var FindId = work.CoursesType.GetByID(id);
            if (FindId == null)
            {
                ViewBag.coursesStatus = "Submit";
                ViewBag.BoolValue = true;
                return View();
            }
            else
            {
                ViewBag.coursesStatus = "Edit";
                ViewBag.BoolValue = false;
                return View(FindId);

            }

           
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesTypeCreate(CoursesType coursesType, int id)
        {

            var FindId = work.CoursesType.GetByID(id);
            var app = application.CoursesTypes.OrderBy(m => m.Code).LastOrDefault();
            string file = string.Empty;
            string newfile = string.Empty;
            var apps = new CoursesType();
            string Paths = string.Empty;
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = application.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (FindId == null)
            {

                if (coursesType.FormFile != null && coursesType.FormFile.Length > 0)
                {
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "CoursesTypeImage");

                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }

                    file = coursesType.FormFile.FileName;

                    string extension = Path.GetExtension(coursesType.FormFile.FileName);

                    if (app != null)
                    {
                        newfile = (app.Code + 1).ToString() + extension;
                        Paths = Path.Combine(Upload, newfile);
                        coursesType.FormFile.CopyTo(new FileStream(Paths, FileMode.Create));
                        coursesType.Image = newfile;
                    }
                    else
                    {
                        
                        coursesType.UserCode = employee.Email;
                        coursesType.CreatedDate=DateTime.Now;
                        work.CoursesType.AddNewRow(coursesType);
                        apps = application.CoursesTypes.OrderBy(m => m.Code).LastOrDefault();
                        newfile = apps.Code.ToString() + extension;
                        apps.Image = newfile;
                        Paths = Path.Combine(Upload, newfile);
                        coursesType.FormFile.CopyTo(new FileStream(Paths, FileMode.Create));
                        coursesType.Image = newfile;
                        
                        

                    }

                }
                if (app == null)
                {
                    apps.UserCode = employee.Email;
                    apps.CreatedDate = DateTime.Now;
                    work.CoursesType.UpdateRow(apps);

                }
                else
                {

                    coursesType.UserCode = employee.Email;
                    coursesType.CreatedDate = DateTime.Now;
                    work.CoursesType.AddNewRow(coursesType);
                }
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
                return Redirect("GetCoursesTypeIndex");
            }

            //Update Data
            else
            {
                work.CoursesType.UpdateRow(FindId);
                if (coursesType.FormFile != null && coursesType.FormFile.Length > 0)
                {
                     
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "CoursesTypeImage");
                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }
                    string fileName = coursesType.FormFile.FileName;
                    string newFileName = coursesType.Code.ToString();
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
                        coursesType.FormFile.CopyTo(fileStream);
                    }
                    FindId.Image = newFileName + Path.GetExtension(fileName);
                }

                FindId.ArabicName = coursesType.ArabicName;
                FindId.EnglishName = coursesType.EnglishName;
                FindId.IsHide = coursesType.IsHide;
                FindId.LastUpdateUserCode = employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                work.CoursesType.UpdateRow(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                return RedirectToAction("GetCoursesTypeIndex");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesTypeIndex(CoursesType coursesType, int id)
        {
            var fintID = work.CoursesType.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = application.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (fintID != null)
            {
                fintID.IsDelete = true;
                fintID.LastUpdateDate = DateTime.Now;
                fintID.LastUpdateUserCode = employee.Email;
                work.CoursesType.UpdateRow(fintID);
            }
            return Redirect("GetCoursesTypeIndex");
        }

    }
}