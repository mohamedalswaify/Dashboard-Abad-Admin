using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Areas.CompanyData.Models;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplicationAbad.Areas.AdminManageData.Controllers
{
    [Area("AdminManageData")]
    public class TrainerController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        private readonly IHostingEnvironment host;

        public TrainerController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext context)
        {
            this.work = work;
            this.host = host;
            this.context = context;
        }


        public IActionResult GetIndexTrainer()
        {
            var allData = context.TrainerData.Where(b=>!b.IsDelete).ToList();
            return View(allData);
        }


        public IActionResult GetTrainerCreate(string Token)
        {
            var FindId = context.TrainerData.FirstOrDefault(b => b.Token == Token);
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
        public IActionResult GetTrainerCreate(Trainer Trainer, string Token)
        {
            var FindId = context.TrainerData.Find(Trainer.Id);
            var app = context.TrainerData.OrderBy(m => m.Id).LastOrDefault();
            string file = string.Empty;
            string newfile = string.Empty;
            var apps = new Trainer();
            string Paths = string.Empty;
            if (FindId == null)
            {

                if (Trainer.FormFile != null && Trainer.FormFile.Length > 0)
                {
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "TrainerImage");

                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }

                    file = Trainer.FormFile.FileName;

                    string extension = Path.GetExtension(Trainer.FormFile.FileName);

                    if (app != null)
                    {
                        newfile = (app.Id + 1).ToString() + extension;
                        Paths = Path.Combine(Upload, newfile);
                        Trainer.FormFile.CopyTo(new FileStream(Paths, FileMode.Create));
                        Trainer.Image = newfile;
                    }
                    else
                    {
                        Trainer.EmailPerson= Trainer.EmailPerson.Trim().ToLower();
                        context.TrainerData.Add(Trainer);
                        context.SaveChanges();
                        apps = context.TrainerData.OrderBy(m => m.Id).LastOrDefault();
                        newfile = apps.Id.ToString() + extension;
                        apps.Image = newfile;
                        Paths = Path.Combine(Upload, newfile);
                        Trainer.FormFile.CopyTo(new FileStream(Paths, FileMode.Create));
                        Trainer.Image = newfile;

                    }

                }
                if (app == null)
                {
                    Trainer.EmailPerson=Trainer.EmailPerson.Trim().ToLower();
                    context.TrainerData.Update(apps);


                }
                else
                {
                    Trainer.EmailPerson=Trainer.EmailPerson.Trim().ToLower();
                    context.TrainerData.Add(Trainer);
                }
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
                context.SaveChanges();
                return RedirectToAction("GetIndexTrainer");
            }

            //Update Data
            else
            {
                context.TrainerData.Update(FindId);
                if (Trainer.FormFile != null && Trainer.FormFile.Length > 0)
                {

                    string Upload = Path.Combine(host.WebRootPath, "Admin", "TrainerImage");
                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }
                    string fileName = Trainer.FormFile.FileName;
                    string newFileName = Trainer.Id.ToString();
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
                        Trainer.FormFile.CopyTo(fileStream);
                    }
                    FindId.Image = newFileName + Path.GetExtension(fileName);
                }
                

                FindId.NameAr = Trainer.NameAr;
                FindId.NameEn = Trainer.NameEn;
                FindId.Mobile = Trainer.Mobile;
                FindId.Salary = Trainer.Salary;
                FindId.EmailPerson = Trainer.EmailPerson.Trim().ToLower();
                FindId.PasswordPerson = Trainer.PasswordPerson;
                FindId.EmailZoom = Trainer.EmailZoom;
                FindId.PasswordZoom = Trainer.PasswordZoom;
                FindId.IsHide = Trainer.IsHide;
                FindId.LastUpdateUserCode = Trainer.LastUpdateUserCode;
                FindId.LastUpdateDate = Trainer.LastUpdateDate;
                context.TrainerData.Update(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                context.SaveChanges();
                return RedirectToAction("GetIndexTrainer");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetIndexTrainer(Trainer trainer, string Token)
        {
            var fintID = context.TrainerData.FirstOrDefault(b => b.Token == Token);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                context.TrainerData.Update(fintID);
                context.SaveChanges();
            }
            return RedirectToAction("GetIndexTrainer");
        }


        public IActionResult GetTrainerDetails(string Token)
        {
            var trainer=context.TrainerData.FirstOrDefault(b=>b.Token==Token);
            return View(trainer);
        }        


        [HttpGet]
        public IActionResult CheckData(string Email, string Phone, int Identfire)
        {
            var CheckDateModel = context.TrainerData.FirstOrDefault(b => b.EmailPerson == Email || b.Mobile == Phone || b.IdNumber == Identfire);
            if (CheckDateModel == null)
            {
                return Json(true);
            }
            return Json(false);
        }


        [HttpGet]
        public IActionResult CheckDataEdit(string Email, string Phone, int Identfire, int IDs)
        {
            string email = Email.Trim().ToLower();
            var OldTraner = context.TrainerData.Find(IDs);
            if(OldTraner.IdNumber == Identfire && OldTraner.Mobile == Phone && OldTraner.EmailPerson == email)
            {
                return Json(true);
            }


            var Traner=context.TrainerData.Where(b=>b.Id !=IDs).FirstOrDefault(b=>
            b.EmailPerson == email || b.Mobile==Phone || b.IdNumber == Identfire);
            
            if (Traner != null) { 

            if(Traner.EmailPerson == email)
            {
                return Json(false);
            }
            if( Traner.Mobile == Phone)
            {
                return Json(false);
            }
            if (Traner.IdNumber == Identfire)
            {
                return Json(false);
            }

            }
            return Json(true);
        }


    }
}
