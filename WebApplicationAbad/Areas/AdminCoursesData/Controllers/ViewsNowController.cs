using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Text;
using WebApplicationAbad.Areas.AdminCoursesData.Models;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace WebApplicationAbad.Areas.AdminCoursesData.Controllers
{
    [Area("AdminCoursesData")]

    public class ViewsNowController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly ApplicationDbContext context;
        private readonly IHostingEnvironment host;


        public ViewsNowController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext context)
        {
            this.work = work;
            this.context = context;
            this.host = host;
        }

        public IActionResult GetViewsNowIndex()
        {

            var allData = context.ViewsNows.Where(b => !b.IsDelete).OrderByDescending(b => b.IsOpen).ToList();
            return View(allData);

        }


        public IActionResult GetViewsNowCreate(int id)
        {
            var FindId = context.ViewsNows.Find(id);
            if (FindId == null)
            {
                ViewBag.coursesStatus = "ارسال";
                ViewBag.BoolValue = true;
            }
            else
            {
                ViewBag.coursesStatus = "تعديل";
                ViewBag.BoolValue = false;
                return View(FindId);

            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetViewsNowCreate(ViewsNow viewsNow, int id)
        {
            var FindId = context.ViewsNows.Find(id);
            var app = context.ViewsNows.OrderBy(m => m.Id).LastOrDefault();
            string file = string.Empty;
            string newfile = string.Empty;
            var apps = new ViewsNow();
            string Paths = string.Empty;
            if (FindId == null)
            {

                if (viewsNow.FormFiles != null && viewsNow.FormFiles.Length > 0)
                {
                    string Upload = Path.Combine(host.WebRootPath, "Admin", "viewsNowImage");

                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }

                    file = viewsNow.FormFiles.FileName;

                    string extension = Path.GetExtension(viewsNow.FormFiles.FileName);

                    if (app != null)
                    {
                        newfile = (app.Id + 1).ToString() + extension;
                        Paths = Path.Combine(Upload, newfile);
                        viewsNow.FormFiles.CopyTo(new FileStream(Paths, FileMode.Create));
                        viewsNow.Image = newfile;
                    }
                    else
                    {
                        context.ViewsNows.Add(viewsNow);
                        context.SaveChanges();
                        apps = context.ViewsNows.OrderBy(m => m.Id).LastOrDefault();
                        newfile = apps.Id.ToString() + extension;
                        apps.Image = newfile;
                        Paths = Path.Combine(Upload, newfile);
                        viewsNow.FormFiles.CopyTo(new FileStream(Paths, FileMode.Create));
                        viewsNow.Image = newfile;

                    }

                }
                if (app == null)
                {
                    context.Update(apps);
                    context.SaveChanges();

                }
                else
                {
                    context.ViewsNows.Add(viewsNow);
                    context.SaveChanges();
                }
                ViewBag.coursesStatus = "Submit";
                ViewBag.BoolValue = true;
                return Redirect("GetviewsNowIndex");
            }

            else
            {
                context.Update(FindId);
                if (viewsNow.FormFiles != null && viewsNow.FormFiles.Length > 0)
                {

                    string Upload = Path.Combine(host.WebRootPath, "Admin", "ViewsNowImage");
                    if (!Directory.Exists(Upload))
                    {
                        Directory.CreateDirectory(Upload);
                    }
                    string fileName = viewsNow.FormFiles.FileName;
                    string newFileName = viewsNow.Id.ToString();
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
                        viewsNow.FormFiles.CopyTo(fileStream);
                    }
                    FindId.Image = newFileName + Path.GetExtension(fileName);
                }

                FindId.NumberOfCourses = viewsNow.NumberOfCourses;
                FindId.PreDiscount = viewsNow.PreDiscount;
                FindId.Head = viewsNow.Head;
                FindId.Descraption = viewsNow.Descraption;
                FindId.LastUpdateUserCode = viewsNow.LastUpdateUserCode;
                FindId.LastUpdateDate = viewsNow.LastUpdateDate;
                context.ViewsNows.Update(FindId);
                context.SaveChanges();
                ViewBag.coursesStatus = "Edit";
                ViewBag.BoolValue = false;
                return RedirectToAction("GetViewsNowIndex");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetViewsNowIndex(ViewsNow viewsNow, int id)
        {
            var fintID = context.ViewsNows.Find(id);
            if (fintID != null)
            {
                fintID.IsDelete = true;
                context.ViewsNows.Update(fintID);
                context.SaveChanges();
            }
            return Redirect("GetViewsNowIndex");
        }

        public IActionResult IsOpenView(int id)
        {
            var ViewTrue = context.ViewsNows.FirstOrDefault(b => b.IsOpen == true);
            if (ViewTrue != null) {
                ViewTrue.DateClosed = DateTime.Now;
                ViewTrue.IsOpen = false;
                context.ViewsNows.Update(ViewTrue);
                context.SaveChanges();
            }

            var ViewData = context.ViewsNows.Find(id);
            if (ViewData != null)
            {
                ViewData.DateOpen = DateTime.Now;
                ViewData.IsOpen = true;
                ViewData.DateClosed = null;
                context.ViewsNows.Update(ViewData);
                context.SaveChanges();
            }
            var StudntViews = context.ViewStudnts.ToList();
            foreach (var item in StudntViews)
            {
                context.ViewStudnts.Remove(item);
            }
            context.SaveChanges();
            return Redirect("/AdminCoursesData/ViewsNow/GetViewsNowIndex");
        }

        public ActionResult ClossedAll()
        {
            var ViewTrue = context.ViewsNows.FirstOrDefault(b => b.IsOpen == true);
            if (ViewTrue != null)
            {
                ViewTrue.DateClosed = DateTime.Now;
                ViewTrue.IsOpen = false;
                context.ViewsNows.Update(ViewTrue);
                context.SaveChanges();
            }
            var allData = context.ViewsNows.ToList();
            foreach (var item in allData)
            {
                item.IsOpen = false;
            }
            context.SaveChanges();

            var StudntViews = context.ViewStudnts.ToList();
            foreach (var item in StudntViews)
            {
                context.ViewStudnts.Remove(item);
            }
            context.SaveChanges();

            return Redirect("/AdminCoursesData/ViewsNow/GetViewsNowIndex");
        }
        }
    }