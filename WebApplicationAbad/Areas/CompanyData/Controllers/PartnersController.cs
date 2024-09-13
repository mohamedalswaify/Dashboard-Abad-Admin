using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Data;
using WebApplicationAbad.Repository.RepositoryInterface;
using WebApplicationAbad.Areas.CompanyData.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplicationAbad.Areas.CompanyData.Controllers
{
    [Area("CompanyData")]
    public class PartnersController : Controller
    {
        private readonly IUnitOfWork work;
        private readonly IHostingEnvironment host;
        private readonly ApplicationDbContext application;

        public PartnersController(IUnitOfWork work, IHostingEnvironment host, ApplicationDbContext application)
        {
            this.work = work;
            this.host = host;
            this.application = application;
        }

        // GET: Partners
        public IActionResult Index()
        {
            var partners = application.Partners.ToList();
            return View(partners);
        }

        // GET: Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Partners/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Partners model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.formFile != null)
                    {
                        // تحديد المسار الخاص بالمجلد
                        string uploadDir = Path.Combine(host.WebRootPath, "Partners");

                        // التحقق من وجود المجلد، وإذا لم يكن موجودًا يتم إنشاؤه
                        if (!Directory.Exists(uploadDir))
                        {
                            Directory.CreateDirectory(uploadDir);
                        }

                        // إنشاء اسم الملف باستخدام GUID لتجنب التكرار
                        string fileName = Guid.NewGuid().ToString() + "_" + model.formFile.FileName;
                        string filePath = Path.Combine(uploadDir, fileName);

                        // نسخ الملف إلى المسار المحدد
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await model.formFile.CopyToAsync(fileStream);
                        }

                        // حفظ المسار في النموذج
                        model.Image = "/Partners/" + fileName;
                    }

                    // إضافة النموذج إلى قاعدة البيانات وحفظ التغييرات
                    application.Partners.Add(model);
                    await application.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // إضافة رسالة خطأ إلى النموذج
                    ModelState.AddModelError("", "حدث خطأ أثناء رفع الملف: " + ex.Message);
                }
            }
            return View(model);
        }

        // GET: Partners/Edit/5
        public IActionResult Edit(int id)
        {
            var partner = application.Partners.Find(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Partners/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Partners model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var partner = application.Partners.Find(id);

                    if (model.formFile != null)
                    {
                        // تحديد المسار الخاص بالمجلد
                        string uploadDir = Path.Combine(host.WebRootPath, "Partners");

                        // التحقق من وجود المجلد، وإذا لم يكن موجودًا يتم إنشاؤه
                        if (!Directory.Exists(uploadDir))
                        {
                            Directory.CreateDirectory(uploadDir);
                        }

                        // إنشاء اسم الملف باستخدام GUID لتجنب التكرار
                        string fileName = Guid.NewGuid().ToString() + "_" + model.formFile.FileName;
                        string filePath = Path.Combine(uploadDir, fileName);

                        // نسخ الملف إلى المسار المحدد
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await model.formFile.CopyToAsync(fileStream);
                        }

                        // تحديث مسار الصورة في النموذج
                        partner.Image = "/Partners/" + fileName;
                    }

                    // تحديث باقي البيانات
                    partner.Name = model.Name;
                    application.Partners.Update(partner);
                    await application.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    // إضافة رسالة خطأ إلى النموذج
                    ModelState.AddModelError("", "Unable to save changes. " + ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Partners/Delete/5
        public IActionResult Delete(int id)
        {
            var partner = application.Partners.Find(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partner = application.Partners.Find(id);
            if (partner == null)
            {
                return NotFound();
            }

            application.Partners.Remove(partner);
            await application.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
