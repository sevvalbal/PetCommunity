using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetCommunity.Data;
using PetCommunity.Models;
using System;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Sitecore.FakeDb;

namespace PetCommunity.Controllers
{
    public class MissingNoticesController : Controller
    {
        private readonly ApplicationDbContext _context;

        IHostingEnvironment _cevresel;
        public MissingNoticesController(ApplicationDbContext context, IHostingEnvironment cevresel)
        {
            _context = context;
            _cevresel = cevresel;
        }

        // GET: MissingNotices
        public async Task<IActionResult> Index()
        {
            return View(await _context.MissingNotice.ToListAsync());
        }

        // GET: MissingNotices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missingNotice = await _context.MissingNotice
                .FirstOrDefaultAsync(m => m.MN_ID == id);
            if (missingNotice == null)
            {
                return NotFound();
            }

            return View(missingNotice);
        }

        // GET: MissingNotices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: c
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MN_ID,Name,LastName,PhoneNumber,EMail,City,Address,Description,PetType,PetBreed,PetGender,PetName,image,imageFolder")] MissingNotice missingNotice)
        {
            if (ModelState.IsValid)
            {
                var Resimler = Path.Combine(_cevresel.WebRootPath, "Resimler");
                if (missingNotice.imageFolder.Length > 0 )
                {
                    using (var dosya = new FileStream(Path.Combine(Resimler, missingNotice.imageFolder.FileName),FileMode.Create))
                    {
                        await missingNotice.imageFolder.CopyToAsync(dosya);

                    }
                }

                missingNotice.image = missingNotice.imageFolder.FileName;
                _context.Add(missingNotice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(missingNotice);
        }

        // GET: MissingNotices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missingNotice = await _context.MissingNotice.FindAsync(id);
            if (missingNotice == null)
            {
                return NotFound();
            }
            return View(missingNotice);
        }

        // POST: MissingNotices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MN_ID,Name,LastName,PhoneNumber,EMail,City,Address,Description,PetType,PetBreed,PetGender,PetName,image")] MissingNotice missingNotice)
        {
            if (id != missingNotice.MN_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(missingNotice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MissingNoticeExists(missingNotice.MN_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(missingNotice);
        }

        // GET: MissingNotices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var missingNotice = await _context.MissingNotice
                .FirstOrDefaultAsync(m => m.MN_ID == id);
            if (missingNotice == null)
            {
                return NotFound();
            }

            return View(missingNotice);
        }

        // POST: MissingNotices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var missingNotice = await _context.MissingNotice.FindAsync(id);
            _context.MissingNotice.Remove(missingNotice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MissingNoticeExists(int id)
        {
            return _context.MissingNotice.Any(e => e.MN_ID == id);

        }


    }
}
