 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Areas.AdminManageData.Data;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using static System.Net.Mime.MediaTypeNames;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        private readonly IHostingEnvironment host;

        public void FillLast(int IndexValue = 1)
        {

            var datas = context.CoursesTypes.Where(b => !b.IsDelete && !b.IsHide);
            SelectList list = new SelectList(datas, "Code", "EnglishName");


            ViewBag.FillData = list;

        }


        public ArticleController(IUnitOfWork work, ApplicationDbContext context, IHostingEnvironment host)
        {
            this.work = work;
            this.context = context;
            this.host = host;

        }


        public IActionResult ArticleIndex()
        {
            var Art = context.Article.Where(b => !b.IsDelete).OrderByDescending(b => b.PublishDate).ToList();
            return View(Art);
        }


        
        public IActionResult ArticleCreate(int id)
        {
            var FindId = context.Article.Find(id);

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
        public IActionResult ArticleCreate(Article article, int id)
        {
            var FindId = context.Article.Find(id);
            var app = context.Article.OrderBy(m => m.Id).LastOrDefault();
            string fileArticle = string.Empty;
            string newFileArticle = string.Empty;
            string fileAuthor = string.Empty;
            string newFileAuthor = string.Empty;
            string PathsArticle = string.Empty;
            string PathsAuthor = string.Empty;
            string? EmployeeId = Request.Cookies["EmployeeId"];
            Employee employee = context.Employees.FirstOrDefault(b => b.Token == EmployeeId);

            if (FindId == null)
            {
                // معالجة رفع صورة المقال
                if (article.FormFiles != null && article.FormFiles.Length > 0)
                {
                    string UploadArticle = Path.Combine(host.WebRootPath, "Admin", "ImageArticle");

                    if (!Directory.Exists(UploadArticle))
                    {
                        Directory.CreateDirectory(UploadArticle);
                    }

                    fileArticle = article.FormFiles.FileName;
                    string extensionArticle = Path.GetExtension(article.FormFiles.FileName);

                    if (app != null)
                    {
                        newFileArticle = (app.Id + 1).ToString() + extensionArticle;
                    }
                    else
                    {
                        // أضف المقالة أولاً للحصول على ID جديد
                        context.Article.Add(article);
                        context.SaveChanges();
                        var newApp = context.Article.OrderBy(m => m.Id).LastOrDefault();
                        newFileArticle = newApp.Id.ToString() + extensionArticle;
                    }

                    PathsArticle = Path.Combine(UploadArticle, newFileArticle);
                    using (var stream = new FileStream(PathsArticle, FileMode.Create))
                    {
                        article.FormFiles.CopyTo(stream);
                    }
                    article.IamgeArticle = newFileArticle;
                }

                // معالجة رفع صورة الناشر
                if (article.FormFilesAuthor != null && article.FormFilesAuthor.Length > 0)
                {
                    string UploadAuthor = Path.Combine(host.WebRootPath, "Admin", "ImageAuthor");

                    if (!Directory.Exists(UploadAuthor))
                    {
                        Directory.CreateDirectory(UploadAuthor);
                    }

                    fileAuthor = article.FormFilesAuthor.FileName;
                    string extensionAuthor = Path.GetExtension(article.FormFilesAuthor.FileName);

                    if (app != null)
                    {
                        newFileAuthor = (app.Id + 1).ToString() + extensionAuthor;
                    }
                    else
                    {
                        // أضف المقالة أولاً للحصول على ID جديد
                       article.Token=Guid.NewGuid().ToString();
                        context.Article.Add(article);
                        context.SaveChanges();
                        var newApp = context.Article.OrderBy(m => m.Id).LastOrDefault();
                        newFileAuthor = newApp.Id.ToString() + extensionAuthor;
                    }

                    PathsAuthor = Path.Combine(UploadAuthor, newFileAuthor);
                    using (var stream = new FileStream(PathsAuthor, FileMode.Create))
                    {
                        article.FormFilesAuthor.CopyTo(stream);
                    }
                    article.IamgeAuthor = newFileAuthor;
                }

                article.LastUpdateUserCode = employee.Email;
                article.LastUpdateDate = DateTime.Now;
                context.Article.Add(article);
                context.SaveChanges();

                ViewBag.coursesStatus = "Submit";
                ViewBag.BoolValue = true;
                return RedirectToAction("ArticleIndex");
            }
            else
            {
                // تحديث البيانات
                if (article.FormFiles != null && article.FormFiles.Length > 0)
                {
                    string UploadArticle = Path.Combine(host.WebRootPath, "Admin", "ImageArticle");
                    if (!Directory.Exists(UploadArticle))
                    {
                        Directory.CreateDirectory(UploadArticle);
                    }

                    string fileNameArticle = article.FormFiles.FileName;
                    string newFileNameArticle = FindId.Id.ToString();
                    string newFilePathArticle = Path.Combine(UploadArticle, newFileNameArticle);

                    string[] existingFilesArticle = { newFilePathArticle + ".jpg", newFilePathArticle + ".png", newFilePathArticle + ".webp" };
                    foreach (string existingFile in existingFilesArticle)
                    {
                        if (System.IO.File.Exists(existingFile))
                        {
                            System.IO.File.Delete(existingFile);
                        }
                    }

                    newFilePathArticle += Path.GetExtension(fileNameArticle);
                    using (var fileStream = new FileStream(newFilePathArticle, FileMode.Create))
                    {
                        article.FormFiles.CopyTo(fileStream);
                    }
                    FindId.IamgeArticle = newFileNameArticle + Path.GetExtension(fileNameArticle);
                }

                if (article.FormFilesAuthor != null && article.FormFilesAuthor.Length > 0)
                {
                    string UploadAuthor = Path.Combine(host.WebRootPath, "Admin", "ImageAuthor");
                    if (!Directory.Exists(UploadAuthor))
                    {
                        Directory.CreateDirectory(UploadAuthor);
                    }

                    string fileNameAuthor = article.FormFilesAuthor.FileName;
                    string newFileNameAuthor = FindId.Id.ToString();
                    string newFilePathAuthor = Path.Combine(UploadAuthor, newFileNameAuthor);

                    string[] existingFilesAuthor = { newFilePathAuthor + ".jpg", newFilePathAuthor + ".png" , newFilePathAuthor + ".webp" };
                    foreach (string existingFile in existingFilesAuthor)
                    {
                        if (System.IO.File.Exists(existingFile))
                        {
                            System.IO.File.Delete(existingFile);
                        }
                    }

                    newFilePathAuthor += Path.GetExtension(fileNameAuthor);
                    using (var fileStream = new FileStream(newFilePathAuthor, FileMode.Create))
                    {
                        article.FormFilesAuthor.CopyTo(fileStream);
                    }
                    FindId.IamgeAuthor = newFileNameAuthor + Path.GetExtension(fileNameAuthor);
                }
                FindId.Token=Guid.NewGuid().ToString();
                FindId.Title = article.Title;
                FindId.Contetnt = article.Contetnt;
                FindId.Author = article.Author;
                FindId.Authorjob = article.Authorjob;
                FindId.PublishDate = article.PublishDate;
                FindId.ReadTime = article.ReadTime;
                FindId.IsHide = article.IsHide;
                FindId.IsDelete = article.IsDelete;
                FindId.LastUpdateUserCode = employee.Email;
                FindId.LastUpdateDate = DateTime.Now;

                context.Article.Update(FindId);
                context.SaveChanges();

                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                return RedirectToAction("ArticleIndex");
            }
        }


 
    }

}
