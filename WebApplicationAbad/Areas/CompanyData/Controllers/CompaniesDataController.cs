using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using NuGet.Common;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.CompanyData.Models;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplicationAbad.Areas.CompanyData.Controllers
{
    [Area("CompanyData")]
    public class CompaniesDataController : Controller
    {

        private readonly IUnitOfWork work;
        private readonly IHostingEnvironment host;
        private readonly ApplicationDbContext application;

        public CompaniesDataController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext application)
        {
            this.work = work;
            this.host = host;
            this.application = application;
        }


        public IActionResult Index()
        {
            var company = application.CompaniesData.Where(b=>!b.IsDelete).ToList();
            return View(company);
        }


        public IActionResult Create(string Token)
        {
            var FindId = application.CompaniesData.FirstOrDefault(b => b.Token == Token);
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
        public IActionResult Create(CompaniesData CompaniesData, string Token)
        {
            string? Tokens = Request.Cookies["EmployeeId"];
            var Employee = application.Employees.FirstOrDefault(b => b.Token == Tokens);

            var FindId = application.CompaniesData.FirstOrDefault(b => b.Code == CompaniesData.Code);
            var app = application.CompaniesData.OrderBy(m => m.Code).LastOrDefault();
            string file = string.Empty;
            string newfile = string.Empty;
            var apps = new CompaniesData();
            string Paths = string.Empty;
            if (FindId == null)
            {

                if (CompaniesData.FormFile != null && CompaniesData.FormFile.Length > 0)
                {
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "CompanyImage");

                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }

                    file = CompaniesData.FormFile.FileName;

                    string extension = Path.GetExtension(CompaniesData.FormFile.FileName);

                    if (app != null)
                    {

                        newfile = (app.Code + 1).ToString() + extension;
                        Paths = Path.Combine(Upload, newfile);
                        CompaniesData.FormFile.CopyTo(new FileStream(Paths, FileMode.Create));
                        CompaniesData.Image = newfile;
                    }
                    else
                    {
                        CompaniesData.UserCode = Employee.Email;
                        application.CompaniesData.Add(CompaniesData);
                        application.SaveChanges();
                        apps = application.CompaniesData.OrderBy(m => m.Code).LastOrDefault();
                        newfile = apps.Code.ToString() + extension;
                        apps.Image = newfile;
                        Paths = Path.Combine(Upload, newfile);
                        CompaniesData.FormFile.CopyTo(new FileStream(Paths, FileMode.Create));
                        CompaniesData.Image = newfile;

                    }

                }
                if (app == null)
                {
                    application.CompaniesData.Update(apps);

                }
                else
                {
                    CompaniesData.CreatedDate = DateTime.Now;
                    CompaniesData.UserCode = Employee.Email;
                    application.CompaniesData.Add(CompaniesData);

                }
                ViewBag.coursesStatus = "Submit";
                ViewBag.BoolValue = true;
                application.SaveChanges();
                return Redirect("Index");
            }

            //Update Data
            else
            {
                application.CompaniesData.Update(FindId);
                if (CompaniesData.FormFile != null && CompaniesData.FormFile.Length > 0)
                {

                    string Upload = Path.Combine(host.WebRootPath, "Admin", "CompanyImage");
                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }
                    string fileName = CompaniesData.FormFile.FileName;
                    string newFileName = CompaniesData.Code.ToString();
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
                        CompaniesData.FormFile.CopyTo(fileStream);
                    }
                    FindId.Image = newFileName + Path.GetExtension(fileName);
                }

                FindId.ArabicName = CompaniesData.ArabicName;
                FindId.EnglishName = CompaniesData.EnglishName;
                FindId.ResponsibleNameAr = CompaniesData.ResponsibleNameAr;
                FindId.ResponsibleNameEn = CompaniesData.ResponsibleNameEn;
                FindId.ResponsiblePhone = CompaniesData.ResponsiblePhone;
                FindId.Email = CompaniesData.Email;
                FindId.Phone = CompaniesData.Phone;
                FindId.WorkFiled = CompaniesData.WorkFiled;
                FindId.LastUpdateUserCode = Employee.Email;
                FindId.LastUpdateDate = DateTime.Now;
                application.CompaniesData.Update(FindId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                application.SaveChanges();
                return RedirectToAction("Index");
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CompaniesData companiesData, string Token)
        {
            var fintID = application.CompaniesData.FirstOrDefault(b => b.Token == Token);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                application.CompaniesData.Update(fintID);
                application.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult GetDaitelsCompany(string Token)
        {
            var CompanyData = application.CompaniesData.FirstOrDefault(b=>b.Token==Token);
            return View(CompanyData);
        }


        public IActionResult AddContract(ContractDatum contractDatum)
        {
            try
            {
                string? Tokens = Request.Cookies["EmployeeId"];
                var Employee = application.Employees.FirstOrDefault(b => b.Token == Tokens);
                contractDatum.UserCode = Employee.Email;
                application.ContractData.Add(contractDatum);
                application.SaveChanges();
                var company = application.CompaniesData.Find(contractDatum.CompaniesDataId);
                return Redirect($"/CompanyData/CompaniesData/GetDaitelsCompany?Token={company.Token}");
            }
            catch (Exception)
            {

                throw;
            }
           
        }


        public IActionResult DeleteContract(CompaniesData companiesData, int id)
        {
            var fintID = application.ContractData.FirstOrDefault(b => b.Id == id);
            if (fintID != null)
            {
                fintID.IsDeletae = true;
                application.ContractData.Update(fintID);
                application.SaveChanges();
            }
            var company = application.CompaniesData.Find(fintID.CompaniesDataId);
            return Json(true);
        }


        public IActionResult GetUpdateContrat(string Token)
        {
            var DataCont=application.ContractData.FirstOrDefault(b=>b.Token== Token);
            return View(DataCont);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetUpdateContrat(ContractDatum contractDatum)
        {
            string? Tokens = Request.Cookies["EmployeeId"];
            var Employee = application.Employees.FirstOrDefault(b => b.Token == Tokens);
            var contract = application.ContractData.Find(contractDatum.Id);
            if (contract != null)
            {
                contract.ContractPrise = contractDatum.ContractPrise;
                contract.ContractRest = contractDatum.ContractRest;
                contract.Nots = contractDatum.Nots;
                contract.ContractPaid = contractDatum.ContractPaid;
                contract.StatusCode = contractDatum.StatusCode;
                contract.StudentCount = contractDatum.StudentCount;
                contract.Tiltle = contractDatum.Tiltle;
                contract.Subject = contractDatum.Subject;
                contract.Subject = contractDatum.Subject;
                contract.LastUpdateUserCode = Employee.Email;
                contract.LastUpdateDate = DateTime.Now;

                application.ContractData.Update(contract); 
                application.SaveChanges();
            }
            var company = application.CompaniesData.Find(contract.CompaniesDataId);
            return Redirect($"/CompanyData/CompaniesData/GetDaitelsCompany?Token={company.Token}");
        }
    }
}
