using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationAbad.Areas.Setting.Data;
using WebApplicationAbad.Data; // Update this to the actual namespace of your DbContext

namespace WebApplicationAbad.Areas.Setting.Controllers
{
    [Area("Setting")]
    public class PrivacyController : Controller
    {
        private readonly ApplicationDbContext _context; // Update ApplicationDbContext with your actual context class

        public PrivacyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Privacy/Index
        public async Task<IActionResult> Index()
        {
            var privacyList = await _context.PrivacyModels.ToListAsync();
            return View(privacyList);
        }

        // GET: Privacy/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var privacyModel = await _context.PrivacyModels.FindAsync(id);
            if (privacyModel == null)
            {
                return NotFound();
            }
            return View(privacyModel);
        }

        // GET: Privacy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Privacy/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] PrivacyModel privacyModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(privacyModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(privacyModel);
        }

        // POST: Privacy/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [FromForm] PrivacyModel privacyModel)
        {
            if (id != privacyModel.Id)
            {
                return BadRequest("ID mismatch");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Entry(privacyModel).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrivacyModelExists(id))
                    {
                        return BadRequest("PrivacyModel not found");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(privacyModel);
        }

        // GET: Privacy/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var privacyModel = await _context.PrivacyModels.FindAsync(id);
            if (privacyModel == null)
            {
                return NotFound();
            }
            return View(privacyModel);
        }

      





        private bool PrivacyModelExists(int id)
        {
            return _context.PrivacyModels.Any(e => e.Id == id);
        }
    }
}
