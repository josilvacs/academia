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
    public class ModalidadeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ModalidadeController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }


        // GET: Modalidade
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Modalidades.Include(m => m.Categoria);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Modalidade/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Modalidades == null)
            {
                return NotFound();
            }

            var modalidade = await _context.Modalidades
                .Include(m => m.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalidade == null)
            {
                return NotFound();
            }

            return View(modalidade);
        }

        // GET: Modalidade/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome");
            return View();
        }

        // POST: Modalidade/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Foto,CategoriaId")] Modalidade modalidade,  IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modalidade);
                await _context.SaveChangesAsync();
                if (formFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = modalidade.Id.ToString("00") + Path.GetExtension(formFile.FileName);
                    string uploads = Path.Combine(wwwRootPath, @"img\services");
                    string newFile = Path.Combine(uploads, fileName);
                    using (var stream = new FileStream(newFile, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                    modalidade.Foto = @"\img\services\" + fileName;
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome", modalidade.CategoriaId);
            return View(modalidade);
        }

        // GET: Modalidade/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Modalidades == null)
            {
                return NotFound();
            }

            var modalidade = await _context.Modalidades.FindAsync(id);
            if (modalidade == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome", modalidade.CategoriaId);
            return View(modalidade);
        }

        // POST: Modalidade/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Foto,CategoriaId")] Modalidade modalidade, IFormFile formFile)
        {
            if (id != modalidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                
                    if (formFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        if (modalidade.Foto != null)
                        {
                            string oldFile = Path.Combine(wwwRootPath, modalidade.Foto.TrimStart('\\'));
                            if (System.IO.File.Exists(oldFile))
                            {
                                System.IO.File.Delete(oldFile);
                            }
                        }

                        string fileName = modalidade.Id.ToString("00") + Path.GetExtension(formFile.FileName);
                        string uploads = Path.Combine(wwwRootPath, @"img\services");
                        string newFile = Path.Combine(uploads, fileName);
                        using (var stream = new FileStream(newFile, FileMode.Create))
                        {
                            formFile.CopyTo(stream);
                        }
                        modalidade.Foto = @"\img\services\" + fileName;
                    }
                    _context.Update(modalidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModalidadeExists(modalidade.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "Id", "Nome", modalidade.CategoriaId);
            return View(modalidade);
        }

        // GET: Modalidade/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Modalidades == null)
            {
                return NotFound();
            }

            var modalidade = await _context.Modalidades
                .Include(m => m.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modalidade == null)
            {
                return NotFound();
            }

            return View(modalidade);
        }

        // POST: Modalidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Modalidades == null)
            {
                return Problem("Entity set 'AppDbContext.Modalidades'  is null.");
            }
            var modalidade = await _context.Modalidades.FindAsync(id);
            if (modalidade != null)
            {
                _context.Modalidades.Remove(modalidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModalidadeExists(int id)
        {
          return _context.Modalidades.Any(e => e.Id == id);
        }
    }
}
