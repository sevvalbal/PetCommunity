using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetCommunity.Data;
using PetCommunity.Models;

namespace PetCommunity.Controllers
{
    public class SolidaritiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SolidaritiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Solidarities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Solidarity.ToListAsync());
        }

        // GET: Solidarities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solidarity = await _context.Solidarity
                .FirstOrDefaultAsync(m => m.S_ID == id);
            if (solidarity == null)
            {
                return NotFound();
            }

            return View(solidarity);
        }

        // GET: Solidarities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solidarities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("S_ID,Name,LastName,PhoneNumber,EMail,City,Address,Help_Type,Description")] Solidarity solidarity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solidarity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solidarity);
        }

        // GET: Solidarities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solidarity = await _context.Solidarity.FindAsync(id);
            if (solidarity == null)
            {
                return NotFound();
            }
            return View(solidarity);
        }

        // POST: Solidarities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("S_ID,Name,LastName,PhoneNumber,EMail,City,Address,Help_Type,Description")] Solidarity solidarity)
        {
            if (id != solidarity.S_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solidarity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolidarityExists(solidarity.S_ID))
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
            return View(solidarity);
        }

        // GET: Solidarities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solidarity = await _context.Solidarity
                .FirstOrDefaultAsync(m => m.S_ID == id);
            if (solidarity == null)
            {
                return NotFound();
            }

            return View(solidarity);
        }

        // POST: Solidarities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solidarity = await _context.Solidarity.FindAsync(id);
            _context.Solidarity.Remove(solidarity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolidarityExists(int id)
        {
            return _context.Solidarity.Any(e => e.S_ID == id);
        }
    }
}
