using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Packaging.Signing;
using System.Drawing;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class CoursesDataController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        private readonly IHostingEnvironment host;

        public CoursesDataController(IUnitOfWork work, ApplicationDbContext context, IHostingEnvironment host)
        {
            this.work = work;
            this.context = context;
            this.host = host;
        }

        public void FillLast(int IndexValue = 1)
        {

            var datas = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
            SelectList list = new SelectList(datas, "Code", "EnglishName");


            ViewBag.FillData = list;

        }

        public IActionResult GetCoursesDataIndex()
        {
            var allData = context.CoursesData.Where(b => !b.IsDelete).ToList();
            return View(allData);

        }

        public IActionResult GetCoursesDataDetils(int id)

        {
            var FindId = work.CoursesData.GetByID(id);
            return View(FindId);
        }


        public IActionResult GetCoursesDataCreate(int id)
        {
            var FindId = work.CoursesData.GetByID(id);

            if (FindId == null)
            {
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
                FillLast();
            }
            else
            {
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                FillLast(id);
                return View(FindId);
            }

            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(500 * 1024 * 1024)]
        public IActionResult GetCoursesDataCreate(CoursesData coursesData, int id)
        {
            try
            {
                var findId = work.CoursesData.GetByID(id);
                var app = context.CoursesData.OrderBy(m => m.Id).LastOrDefault();
                string employeeId = Request.Cookies["EmployeeId"];
                Employee employee = context.Employees.FirstOrDefault(b => b.Token == employeeId);

                bool isFiles = coursesData.FormFileData != null && coursesData.FormFileData.Length > 0;
                bool isImage = coursesData.FormFiles != null && coursesData.FormFiles.Length > 0;

                // Check file sizes
                if (isFiles && coursesData.FormFileData.Length > 200 * 1024 * 1024)
                {
                    ViewBag.ErrorMessage = "حجم الملف اكبر من 500 ميجا.";
                    return View(coursesData);
                }

                if (isImage && coursesData.FormFiles.Length > 40 * 1024 * 1024)
                {
                    ViewBag.ErrorMessage = "حجم الملف اكبر من 40 ميجا.";
                    return View(coursesData);
                }

                if (findId == null)
                {
                    return CreateCourseData(coursesData, app, employee, isFiles, isImage);
                }
                else
                {
                    return UpdateCourseData(coursesData, findId, employee, isFiles, isImage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n{ex.InnerException?.ToString() ?? "No inner exception"}\n");
                System.IO.File.AppendAllText(Path.Combine(host.WebRootPath, "logs", "errors.log"), "---------------------------------------------------------------------\n");

                ModelState.AddModelError(string.Empty, "حدث اخطاء في رفع البيانات يرجي المحاوله مره اخري .");
                ModelState.AddModelError(string.Empty, $"تفاصيل الخطا{ex.Message}");
                if (ex.InnerException != null)
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.ToString());
                }
                return View(coursesData);
            }
        }








        private IActionResult CreateCourseData(CoursesData coursesData, CoursesData app, Employee employee, bool isFiles, bool isImage)
        {
            try
            {
                // Handle uploading test image
                if (coursesData.TestFormFiles != null)
                {
                    string uploadPath = Path.Combine(host.WebRootPath, "Admin", "TestImage");
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }
                    string filePath = Path.Combine(uploadPath, SanitizeFileName(coursesData.TestFormFiles.FileName));

                    if (filePath.Length <= 260)
                    {
                        coursesData.TestFormFiles.CopyTo(new FileStream(filePath, FileMode.Create));
                        coursesData.TestImage = Path.GetFileName(filePath);
                    }
                    else
                    {
                        throw new IOException("File path exceeds maximum length.");
                    }
                }

                string extension = string.Empty;
                string extensions = string.Empty;
                string newfile = string.Empty;
                string newfileData = string.Empty;

                var courseType = context.CoursesTypes.FirstOrDefault(t => t.Code == coursesData.CoursesTypeId);
                if (coursesData.FormFileOtiline != null)
                {
                    string uploadPath = Path.Combine(host.WebRootPath, "Admin", "FileOutline");
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }
                    string exestion = Path.GetExtension(SanitizeFileName(coursesData.FormFileOtiline.FileName));
                    string filePath = Path.Combine(uploadPath, SanitizeFileName(coursesData.HeaderAr + "_Outline" + exestion));

                    if (filePath.Length <= 260)
                    {
                        coursesData.FormFileOtiline.CopyTo(new FileStream(filePath, FileMode.Create));
                        coursesData.FileOutline = Path.GetFileName(filePath);
                    }
                    else
                    {
                        throw new IOException("File path exceeds maximum length.");
                    }
                }

                // Handle uploading files
                if (coursesData.FormFileData != null && coursesData.FormFileData.Length > 0)
                {
                    isFiles = true;
                    extension = Path.GetExtension(SanitizeFileName(coursesData.FormFileData.FileName));

                    string uploadFilesPath = Path.Combine(host.WebRootPath, "Admin", "CoursesDataFiles");
                    if (!Directory.Exists(uploadFilesPath))
                    {
                        Directory.CreateDirectory(uploadFilesPath);
                    }

                    string coursesTypePath = Path.Combine(uploadFilesPath, courseType.TokenNumber);
                    if (!Directory.Exists(coursesTypePath))
                    {
                        Directory.CreateDirectory(coursesTypePath);
                    }
                }

                // Handle uploading images
                if (coursesData.FormFiles != null && coursesData.FormFiles.Length > 0)
                {
                    isImage = true;
                    extensions = Path.GetExtension(SanitizeFileName(coursesData.FormFiles.FileName));

                    string uploadImagesPath = Path.Combine(host.WebRootPath, "Admin", "CoursesDataImage");
                    if (!Directory.Exists(uploadImagesPath))
                    {
                        Directory.CreateDirectory(uploadImagesPath);
                    }
                }

                // Handle saving files and updating database
                if (isImage && isFiles)
                {
                    coursesData.UserCode = employee.Email; // Ensure UserCode is set
                    work.CoursesData.AddNewRow(coursesData);
                    app = context.CoursesData.OrderByDescending(m => m.Id).FirstOrDefault(); // Assuming this retrieves the last added row

                    newfile = SanitizeFileName($"{coursesData.HeaderEn}-{(app.Id + 1)}{extension}");
                    string fileDataCoursesPath = Path.Combine(host.WebRootPath, "Admin", "CoursesDataFiles", courseType.TokenNumber, app.TokenNumber.ToString());
                    if (fileDataCoursesPath.Length <= 260)
                    {
                        Directory.CreateDirectory(fileDataCoursesPath);
                        string uploadCoursesDataPath = Path.Combine(fileDataCoursesPath, newfile);
                        coursesData.FormFileData.CopyTo(new FileStream(uploadCoursesDataPath, FileMode.Create));
                    }
                    else
                    {
                        throw new IOException("File path exceeds maximum length.");
                    }

                    app = context.CoursesData.OrderByDescending(m => m.Id).FirstOrDefault(); // Refresh app object after adding new row
                    newfileData = SanitizeFileName($"{app.Id}{extensions}");
                    string imagePath = Path.Combine(host.WebRootPath, "Admin", "CoursesDataImage", newfileData);
                    if (imagePath.Length <= 260)
                    {
                        coursesData.FormFiles.CopyTo(new FileStream(imagePath, FileMode.Create));
                    }
                    else
                    {
                        throw new IOException("File path exceeds maximum length.");
                    }

                    app.Image = newfileData;
                    app.FilesData = newfile;

                    work.CoursesData.UpdateRow(app);
                }
                else
                {
                    coursesData.UserCode = employee.Email; // Ensure UserCode is set
                    work.CoursesData.AddNewRow(coursesData);
                    app = context.CoursesData.OrderByDescending(m => m.Id).FirstOrDefault(); // Assuming this retrieves the last added row

                    newfile = SanitizeFileName($"{app.Id}{extensions}");
                    string imagePath = Path.Combine(host.WebRootPath, "Admin", "CoursesDataImage", newfile);
                    if (imagePath.Length <= 260)
                    {
                        coursesData.FormFiles.CopyTo(new FileStream(imagePath, FileMode.Create));
                    }
                    else
                    {
                        throw new IOException("File path exceeds maximum length.");
                    }

                    app.Image = newfile;
                    app.UserCode = employee.Email;
                    app.CreatedDate = DateTime.Now;

                    work.CoursesData.UpdateRow(app);
                }

                return RedirectToAction("GetCoursesDataIndex");
            }
            catch (IOException ioEx)
            {
                var datas = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
                SelectList list = new SelectList(datas, "Code", "EnglishName");

                ViewBag.FillData = list;
                // Handle file access issues
                ModelState.AddModelError(string.Empty, "حدث خطأ أثناء الوصول إلى الملف. يرجى المحاولة مرة أخرى.");
                return View(coursesData);
            }
            catch (Exception ex)
            {
                var datas = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
                SelectList list = new SelectList(datas, "Code", "EnglishName");

                ViewBag.FillData = list;
                // Log and handle other exceptions
                string logFilePath = Path.Combine(host.WebRootPath, "logs", "errors.log");
                System.IO.File.AppendAllText(logFilePath, $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
                System.IO.File.AppendAllText(logFilePath, "---------------------------------------------------------------------\n");

                ModelState.AddModelError(string.Empty, "حدث خطأ أثناء معالجة الطلب. يرجى المحاولة مرة أخرى.");
                return View(coursesData);
            }
        }



        // دالة لتنقية أسماء الملفات والاحتفاظ بأول 6 كلمات فقط
        private string SanitizeFileName(string fileName)
        {
            string[] words = fileName.Split(new char[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string firstSixWords = string.Join("_", words.Take(6));
            foreach (char invalidChar in Path.GetInvalidFileNameChars())
            {
                firstSixWords = firstSixWords.Replace(invalidChar, '_');
            }
            return firstSixWords;
        }




        private IActionResult UpdateCourseData(CoursesData coursesData, CoursesData findId, Employee employee, bool isFiles, bool isImage)
        {
            try
            {


                // Handle uploading images
                if (isImage)
                {
                    string newFileName = findId.Id.ToString() + Path.GetExtension(coursesData.FormFiles.FileName);
                    DeleteExistingFiles("CoursesDataImage", findId.TokenNumber.ToString());
                    SaveFile(coursesData.FormFiles, "CoursesDataImage", newFileName);
                    findId.Image = newFileName;
                }

                // Handle uploading data files
                if (isFiles)
                {
                    string newFileNameForm = SanitizeFileName(coursesData.HeaderEn + "-" + findId.Id.ToString() + Path.GetExtension(coursesData.FormFileData.FileName));
                    string uploadCoursesDataPath = Path.Combine(host.WebRootPath, "Admin", "CoursesDataFiles", SanitizeFileName(coursesData.TokenNumber.ToString()), SanitizeFileName(findId.TokenNumber.ToString()));
                    DeleteExistingFiles(uploadCoursesDataPath);

                    if (!Directory.Exists(uploadCoursesDataPath))
                    {
                        Directory.CreateDirectory(uploadCoursesDataPath);
                    }

                    string MyFile = Path.Combine(uploadCoursesDataPath, newFileNameForm);
                    using (var stream = new FileStream(MyFile, FileMode.Create))
                    {
                        coursesData.FormFileData.CopyTo(stream);
                    }

                    findId.FilesData = newFileNameForm;
                }

                // Handle uploading test image
                if (coursesData.TestFormFiles != null)
                {
                    string uploadPath = Path.Combine(host.WebRootPath, "Admin", "TestImage");
                    Directory.CreateDirectory(uploadPath);
                    string filePath = Path.Combine(uploadPath, SanitizeFileName(coursesData.TestFormFiles.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        coursesData.TestFormFiles.CopyTo(stream);
                    }
                    findId.TestImage = coursesData.TestFormFiles.FileName;
                }

                // Update course data fields
                UpdateCourseDataFields(coursesData, findId, employee);

                // Ensure UserCode is set
                findId.UserCode = employee.Email;

                work.CoursesData.UpdateRow(findId);
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                return RedirectToAction("GetCoursesDataIndex");
            }
            catch (IOException ioEx)
            {
                var datas = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
                SelectList list = new SelectList(datas, "Code", "EnglishName");


                ViewBag.FillData = list;
                // Handle file access issues
                ModelState.AddModelError(string.Empty, "حدث خطأ أثناء الوصول إلى الملف. يرجى المحاولة مرة أخرى.");
                return View(coursesData);
            }
            catch (Exception ex)
            {
                var datas = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
                SelectList list = new SelectList(datas, "Code", "EnglishName");


                ViewBag.FillData = list;
                // Log and handle other exceptions
                string logFilePath = Path.Combine(host.WebRootPath, "logs", "errors.log");
                System.IO.File.AppendAllText(logFilePath, $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
                System.IO.File.AppendAllText(logFilePath, "---------------------------------------------------------------------\n");

                ModelState.AddModelError(string.Empty, "حدث خطأ أثناء معالجة الطلب. يرجى المحاولة مرة أخرى.");
                return View(coursesData);
            }
        }

    


        private void SaveFile(IFormFile file, string folderName, string fileName)
        {
            string path = Path.Combine(host.WebRootPath, "Admin", folderName);
            Directory.CreateDirectory(path);
            string filePath = Path.Combine(path, fileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
        }


        private void SaveFile(IFormFile file, string folderName, string subFolder, string fileName)
        {
            string path = Path.Combine(host.WebRootPath, "Admin", folderName, subFolder);
            Directory.CreateDirectory(path);
            string filePath = Path.Combine(path, fileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
        }


        private void SaveFile(IFormFile file, string folderName, string subFolder, string id, string fileName)
        {
            string path = Path.Combine(host.WebRootPath, "Admin", folderName, subFolder, id);
            Directory.CreateDirectory(path);
            string filePath = Path.Combine(path, fileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
        }


        private void DeleteExistingFiles(string folderName, string fileNameWithoutExtension)
        {
            string path = Path.Combine(host.WebRootPath, "Admin", folderName);
            string[] extensions = { ".jpg", ".png" };
            foreach (string extension in extensions)
            {
                string filePath = Path.Combine(path, fileNameWithoutExtension + extension);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }
        }


        private void DeleteExistingFiles(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    System.IO.File.Delete(file);
                }
            }
        }



        private void UpdateCourseDataFields(CoursesData coursesData, CoursesData findId, Employee employee)
        {
            findId.HeaderAr = coursesData.HeaderAr;
            findId.HeaderEn = coursesData.HeaderEn;
            findId.SummaryAr = coursesData.SummaryAr;
            findId.SammaryEn = coursesData.SammaryEn;
            findId.TargetAr = coursesData.TargetAr;
            findId.TargetEn = coursesData.TargetEn;
            findId.DetailsAr = coursesData.DetailsAr;
            findId.SkillsAr = coursesData.SkillsAr;
            findId.GoalsAr = coursesData.GoalsAr;
            findId.CoursesTypeId = coursesData.CoursesTypeId;
            findId.GoalsEn = coursesData.GoalsEn;
            findId.TestAr = coursesData.TestAr;
            findId.TestEn = coursesData.TestEn;
            findId.FromalutetestAr = coursesData.FromalutetestAr;
            findId.PriceM = coursesData.PriceM;
    
            findId.Nots = coursesData.Nots;
            findId.Price = coursesData.Price;
            findId.TestVaild = coursesData.TestVaild;
            findId.IsHide = coursesData.IsHide;
            findId.LastUpdateUserCode = employee.Email;
            findId.LastUpdateDate = DateTime.Now;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCoursesDataIndex(int id)
        {
            var fintID = work.CoursesData.GetByID(id);
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (fintID != null)
            {
                fintID.IsDelete = true;
                fintID.LastUpdateDate = DateTime.Now;
                fintID.UserCode = employee.Email;
                work.CoursesData.UpdateRow(fintID);
            }
            return Redirect("GetCoursesDataIndex");
        }

    }
}