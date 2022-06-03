using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetCommunity.Data;
using PetCommunity.Models;

namespace PetCommunity.Controllers
{
    public class PetAdoptionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        IHostingEnvironment _cevresel;
        public PetAdoptionsController(ApplicationDbContext context, IHostingEnvironment cevresel)
        {
            _context = context;
            _cevresel = cevresel;
        }

        // GET: PetAdoptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.PetAdoption.ToListAsync());
        }

        // GET: PetAdoptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petAdoption = await _context.PetAdoption
                .FirstOrDefaultAsync(m => m.PA_ID == id);
            if (petAdoption == null)
            {
                return NotFound();
            }

            return View(petAdoption);
        }

        // GET: PetAdoptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PetAdoptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PA_ID,Name,LastName,PhoneNumber,EMail,City,Address,Description,PetType,PetBreed,PetGender,PetName,image,imageFolder")] PetAdoption petAdoption)
        {
            if (ModelState.IsValid)
            {
                var Resimler = Path.Combine(_cevresel.WebRootPath, "Resimler");
                if (petAdoption.imageFolder.Length > 0)
                {
                    using (var dosya = new FileStream(Path.Combine(Resimler, petAdoption.imageFolder.FileName), FileMode.Create))
                    {
                        await petAdoption.imageFolder.CopyToAsync(dosya);

                    }
                }

                petAdoption.image = petAdoption.imageFolder.FileName;
                _context.Add(petAdoption);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petAdoption);
        }

        // GET: PetAdoptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petAdoption = await _context.PetAdoption.FindAsync(id);
            if (petAdoption == null)
            {
                return NotFound();
            }
            return View(petAdoption);
        }

        // POST: PetAdoptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PA_ID,Name,LastName,PhoneNumber,EMail,City,Address,Description,PetType,PetBreed,PetGender,PetName,image")] PetAdoption petAdoption)
        {
            if (id != petAdoption.PA_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(petAdoption);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetAdoptionExists(petAdoption.PA_ID))
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
            return View(petAdoption);
        }

        // GET: PetAdoptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petAdoption = await _context.PetAdoption
                .FirstOrDefaultAsync(m => m.PA_ID == id);
            if (petAdoption == null)
            {
                return NotFound();
            }

            return View(petAdoption);
        }

        // POST: PetAdoptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var petAdoption = await _context.PetAdoption.FindAsync(id);
            _context.PetAdoption.Remove(petAdoption);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetAdoptionExists(int id)
        {
            return _context.PetAdoption.Any(e => e.PA_ID == id);
        }
    }
}
