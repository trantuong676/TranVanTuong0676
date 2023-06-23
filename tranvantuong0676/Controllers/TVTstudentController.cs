using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TRANVANTUONG0676.Models;

namespace tranvantuong0676.Controllers
{
    public class TVTstudentController : Controller
    {
        private readonly BAITHI _context;

        public TVTstudentController(BAITHI context)
        {
            _context = context;
        }

        // GET: TVTstudent
        public async Task<IActionResult> Index()
        {
              return _context.TVTstudent != null ? 
                          View(await _context.TVTstudent.ToListAsync()) :
                          Problem("Entity set 'BAITHI.TVTstudent'  is null.");
        }

        // GET: TVTstudent/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TVTstudent == null)
            {
                return NotFound();
            }

            var tVTstudent = await _context.TVTstudent
                .FirstOrDefaultAsync(m => m.TVTstudentID == id);
            if (tVTstudent == null)
            {
                return NotFound();
            }

            return View(tVTstudent);
        }

        // GET: TVTstudent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TVTstudent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TVTstudentID,TVTstudentName,TVTStudentSex")] TVTstudent tVTstudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tVTstudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tVTstudent);
        }

        // GET: TVTstudent/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TVTstudent == null)
            {
                return NotFound();
            }

            var tVTstudent = await _context.TVTstudent.FindAsync(id);
            if (tVTstudent == null)
            {
                return NotFound();
            }
            return View(tVTstudent);
        }

        // POST: TVTstudent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TVTstudentID,TVTstudentName,TVTStudentSex")] TVTstudent tVTstudent)
        {
            if (id != tVTstudent.TVTstudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tVTstudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TVTstudentExists(tVTstudent.TVTstudentID))
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
            return View(tVTstudent);
        }

        // GET: TVTstudent/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TVTstudent == null)
            {
                return NotFound();
            }

            var tVTstudent = await _context.TVTstudent
                .FirstOrDefaultAsync(m => m.TVTstudentID == id);
            if (tVTstudent == null)
            {
                return NotFound();
            }

            return View(tVTstudent);
        }

        // POST: TVTstudent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TVTstudent == null)
            {
                return Problem("Entity set 'BAITHI.TVTstudent'  is null.");
            }
            var tVTstudent = await _context.TVTstudent.FindAsync(id);
            if (tVTstudent != null)
            {
                _context.TVTstudent.Remove(tVTstudent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TVTstudentExists(string id)
        {
          return (_context.TVTstudent?.Any(e => e.TVTstudentID == id)).GetValueOrDefault();
        }
    }
}
