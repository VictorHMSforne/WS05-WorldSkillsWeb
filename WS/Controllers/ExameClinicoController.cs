using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WS.Context;
using WS.Models;

namespace WS.Controllers
{
    public class ExameClinicoController : Controller
    {
        private readonly AppDbContext _context;

        public ExameClinicoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ExameClinico
        public async Task<IActionResult> Index()
        {
              return View(await _context.ExameClinico.ToListAsync());
        }

        // GET: ExameClinico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ExameClinico == null)
            {
                return NotFound();
            }

            var exameClinico = await _context.ExameClinico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exameClinico == null)
            {
                return NotFound();
            }

            return View(exameClinico);
        }

        // GET: ExameClinico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExameClinico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ocupacao,Nome,Idade,RG,Funcao,Empresa")] ExameClinico exameClinico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exameClinico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create","ClinicaPregressa");
            }
            return View(exameClinico);
        }

        // GET: ExameClinico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ExameClinico == null)
            {
                return NotFound();
            }

            var exameClinico = await _context.ExameClinico.FindAsync(id);
            if (exameClinico == null)
            {
                return NotFound();
            }
            return View(exameClinico);
        }

        // POST: ExameClinico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ocupacao,Nome,Idade,RG,Funcao,Empresa")] ExameClinico exameClinico)
        {
            if (id != exameClinico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exameClinico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExameClinicoExists(exameClinico.Id))
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
            return View(exameClinico);
        }

        // GET: ExameClinico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ExameClinico == null)
            {
                return NotFound();
            }

            var exameClinico = await _context.ExameClinico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exameClinico == null)
            {
                return NotFound();
            }

            return View(exameClinico);
        }

        // POST: ExameClinico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ExameClinico == null)
            {
                return Problem("Entity set 'AppDbContext.ExameClinico'  is null.");
            }
            var exameClinico = await _context.ExameClinico.FindAsync(id);
            if (exameClinico != null)
            {
                _context.ExameClinico.Remove(exameClinico);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExameClinicoExists(int id)
        {
          return _context.ExameClinico.Any(e => e.Id == id);
        }
    }
}
