using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcademiaCintia.Data;
using AcademiaCintia.Models;

namespace AcademiaCintia.Controllers
{
    public class GaleriaController : Controller
    {
        private readonly AppDbContext _context;

        public GaleriaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Galeria
        public async Task<IActionResult> Index()
        {
              return View(await _context.Galerias.ToListAsync());
        }

        // GET: Galeria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Galerias == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // GET: Galeria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galeria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Foto")] Galeria galeria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(galeria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(galeria);
        }

        // GET: Galeria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Galerias == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias.FindAsync(id);
            if (galeria == null)
            {
                return NotFound();
            }
            return View(galeria);
        }

        // POST: Galeria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Foto")] Galeria galeria)
        {
            if (id != galeria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(galeria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaleriaExists(galeria.Id))
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
            return View(galeria);
        }

        // GET: Galeria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Galerias == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }

        // POST: Galeria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Galerias == null)
            {
                return Problem("Entity set 'AppDbContext.Galerias'  is null.");
            }
            var galeria = await _context.Galerias.FindAsync(id);
            if (galeria != null)
            {
                _context.Galerias.Remove(galeria);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaleriaExists(int id)
        {
          return _context.Galerias.Any(e => e.Id == id);
        }
    }
}
