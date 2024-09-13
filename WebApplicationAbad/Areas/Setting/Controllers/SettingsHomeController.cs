using Microsoft.AspNetCore.Mvc;
using WebApplicationAbad.Areas.Setting.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Data;

namespace WebApplicationAbad.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class SettingsHomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingsHomeController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Setting/SettingsHome
        public async Task<IActionResult> Index()
        {
            return View(await _context.SettingsHomes.ToListAsync());
        }

        // GET: Setting/SettingsHome/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Setting/SettingsHome/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SettingsHome settingsHome)
        {
            if (ModelState.IsValid)
            {
                if (settingsHome.formFile != null && settingsHome.formFile.Length > 0)
                {
                    // رفع الفيديو والحصول على اسم الملف الفريد
                    string uniqueFileName = UploadedFile(settingsHome);
                    settingsHome.lVideoURL = uniqueFileName;
                }

                _context.Add(settingsHome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(settingsHome);
        }


        // GET: Setting/SettingsHome/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settingsHome = await _context.SettingsHomes.FindAsync(id);
            if (settingsHome == null)
            {
                return NotFound();
            }
            return View(settingsHome);
        }



        // POST: Setting/SettingsHome/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SettingsHome settingsHome)
        {
            if (id != settingsHome.Id)
            {
                return NotFound();
            }

            try
            {
                var existingSettingsHome = await _context.SettingsHomes.FindAsync(id);

                if (existingSettingsHome == null)
                {
                    ModelState.AddModelError("", "لم يتم العثور على العنصر المطلوب للتحديث.");
                    return View(settingsHome);
                }

                // إذا كان هناك ملف فيديو جديد، قم بتحميله
                if (settingsHome.formFile != null && settingsHome.formFile.Length > 0)
                {
                    // تحميل الملف الجديد والحصول على اسمه الفريد
                    string uniqueFileName = UploadedFile(settingsHome);
                    existingSettingsHome.lVideoURL = uniqueFileName; // تحديث الفيديو القديم
                }

                // تحديث القيم الأخرى
                existingSettingsHome.TitlePlane = settingsHome.TitlePlane;
                existingSettingsHome.ShortDescription = settingsHome.ShortDescription;
                existingSettingsHome.WhoMe1 = settingsHome.WhoMe1;
                existingSettingsHome.WhoMe2 = settingsHome.WhoMe2;
                existingSettingsHome.WhoMe3 = settingsHome.WhoMe3;
                existingSettingsHome.WhoMe4 = settingsHome.WhoMe4;
                existingSettingsHome.TitleVideo = settingsHome.TitleVideo;
                existingSettingsHome.Phone = settingsHome.Phone;
                existingSettingsHome.WahtsAppNumber = settingsHome.WahtsAppNumber;
                existingSettingsHome.Email = settingsHome.Email;
                existingSettingsHome.LinkedinURL = settingsHome.LinkedinURL;
                existingSettingsHome.GoogleURL = settingsHome.GoogleURL;
                existingSettingsHome.FacebookURL = settingsHome.FacebookURL;
                existingSettingsHome.YoutubeURL = settingsHome.YoutubeURL;
                existingSettingsHome.TwitterURL = settingsHome.TwitterURL;
                existingSettingsHome.InstagramURL = settingsHome.InstagramURL;
                existingSettingsHome.SnapchatURL = settingsHome.SnapchatURL;

                _context.Update(existingSettingsHome);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettingsHomeExists(settingsHome.Id))
                {
                    ModelState.AddModelError("", "لم يتم العثور على العنصر للتحديث. يرجى التحقق من البيانات وحاول مرة أخرى.");
                    return View(settingsHome);
                }
                else
                {
                    throw;
                }
            }
        }

        // GET: Setting/SettingsHome/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var settingsHome = await _context.SettingsHomes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (settingsHome == null)
            {
                return NotFound();
            }

            return View(settingsHome);
        }

        // POST: Setting/SettingsHome/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var settingsHome = await _context.SettingsHomes.FindAsync(id);
            _context.SettingsHomes.Remove(settingsHome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private string UploadedFile(SettingsHome model)
        {
            string uniqueFileName = null;

            if (model.formFile != null && model.formFile.Length > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.formFile.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.formFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        private bool SettingsHomeExists(int id)
        {
            return _context.SettingsHomes.Any(e => e.Id == id);
        }
    }
}
