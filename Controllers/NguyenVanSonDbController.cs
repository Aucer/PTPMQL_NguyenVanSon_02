using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanSon_02.Models;
using NguyenVanSon_02.Data;

namespace NguyenVanSon_02.Controllers
{
    public class NguyenVanSonDbController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NguyenVanSonDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NguyenVanSonDb
        public async Task<IActionResult> Index()
        {
              return _context.NguyenVanSonDb != null ? 
                          View(await _context.NguyenVanSonDb.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NguyenVanSonDb'  is null.");
        }

        // GET: NguyenVanSonDb/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NguyenVanSonDb == null)
            {
                return NotFound();
            }

            var nguyenVanSonDb = await _context.NguyenVanSonDb
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nguyenVanSonDb == null)
            {
                return NotFound();
            }

            return View(nguyenVanSonDb);
        }

        // GET: NguyenVanSonDb/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NguyenVanSonDb/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] NguyenVanSonDb nguyenVanSonDb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguyenVanSonDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguyenVanSonDb);
        }

        // GET: NguyenVanSonDb/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NguyenVanSonDb == null)
            {
                return NotFound();
            }

            var nguyenVanSonDb = await _context.NguyenVanSonDb.FindAsync(id);
            if (nguyenVanSonDb == null)
            {
                return NotFound();
            }
            return View(nguyenVanSonDb);
        }

        // POST: NguyenVanSonDb/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name")] NguyenVanSonDb nguyenVanSonDb)
        {
            if (id != nguyenVanSonDb.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguyenVanSonDb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguyenVanSonDbExists(nguyenVanSonDb.ID))
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
            return View(nguyenVanSonDb);
        }

        // GET: NguyenVanSonDb/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NguyenVanSonDb == null)
            {
                return NotFound();
            }

            var nguyenVanSonDb = await _context.NguyenVanSonDb
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nguyenVanSonDb == null)
            {
                return NotFound();
            }

            return View(nguyenVanSonDb);
        }

        // POST: NguyenVanSonDb/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NguyenVanSonDb == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NguyenVanSonDb'  is null.");
            }
            var nguyenVanSonDb = await _context.NguyenVanSonDb.FindAsync(id);
            if (nguyenVanSonDb != null)
            {
                _context.NguyenVanSonDb.Remove(nguyenVanSonDb);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguyenVanSonDbExists(string id)
        {
          return (_context.NguyenVanSonDb?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
