using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OCS.Data;
using OCS.Models;

namespace OCS.Controllers
{
    public class ReporterController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ReporterController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Reporter
        public async Task<IActionResult> Index()
        {
              return _context.DoctorIntimations != null ? 
                          View(await _context.DoctorIntimations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.DoctorIntimations'  is null.");
        }

        // GET: Reporter/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DoctorIntimations == null)
            {
                return NotFound();
            }

            var doctorIntimation = await _context.DoctorIntimations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorIntimation == null)
            {
                return NotFound();
            }

            return View(doctorIntimation);
        }

        // GET: Reporter/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reporter/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DoctorId,Date")] DoctorIntimation doctorIntimation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorIntimation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorIntimation);
        }

        // GET: Reporter/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DoctorIntimations == null)
            {
                return NotFound();
            }

            var doctorIntimation = await _context.DoctorIntimations.FindAsync(id);
            if (doctorIntimation == null)
            {
                return NotFound();
            }
            return View(doctorIntimation);
        }

        // POST: Reporter/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DoctorId,Date")] DoctorIntimation doctorIntimation)
        {
            if (id != doctorIntimation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorIntimation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorIntimationExists(doctorIntimation.Id))
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
            return View(doctorIntimation);
        }

        // GET: Reporter/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DoctorIntimations == null)
            {
                return NotFound();
            }

            var doctorIntimation = await _context.DoctorIntimations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctorIntimation == null)
            {
                return NotFound();
            }

            return View(doctorIntimation);
        }

        // POST: Reporter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DoctorIntimations == null)
            {
                return Problem("Entity set 'ApplicationDBContext.DoctorIntimations'  is null.");
            }
            var doctorIntimation = await _context.DoctorIntimations.FindAsync(id);
            if (doctorIntimation != null)
            {
                _context.DoctorIntimations.Remove(doctorIntimation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorIntimationExists(int id)
        {
          return (_context.DoctorIntimations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
