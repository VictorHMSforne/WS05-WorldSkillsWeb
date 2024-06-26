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
    public class HistoricoOcupacionalController : Controller
    {
        private readonly AppDbContext _context;

        public HistoricoOcupacionalController(AppDbContext context)
        {
            _context = context;
        }

        // GET: HistoricoOcupacional
        public async Task<IActionResult> Index()
        {
              return View(await _context.HistoricoOcupacional.ToListAsync());
        }

        // GET: HistoricoOcupacional/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HistoricoOcupacional == null)
            {
                return NotFound();
            }

            var historicoOcupacional = await _context.HistoricoOcupacional
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoOcupacional == null)
            {
                return NotFound();
            }

            return View(historicoOcupacional);
        }

        // GET: HistoricoOcupacional/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoOcupacional/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FuncoesAnteriores,AcidentesTrabalho")] HistoricoOcupacional historicoOcupacional)
        {
            if (ModelState.IsValid)
            {
                if (historicoOcupacional.AcidentesTrabalho == "Nao")
                {
                    historicoOcupacional.AcidentesTrabalho = "Não";
                }
                _context.Add(historicoOcupacional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoOcupacional);
        }

        // GET: HistoricoOcupacional/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HistoricoOcupacional == null)
            {
                return NotFound();
            }

            var historicoOcupacional = await _context.HistoricoOcupacional.FindAsync(id);
            if (historicoOcupacional == null)
            {
                return NotFound();
            }
            return View(historicoOcupacional);
        }

        // POST: HistoricoOcupacional/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FuncoesAnteriores,AcidentesTrabalho")] HistoricoOcupacional historicoOcupacional)
        {
            if (id != historicoOcupacional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoOcupacional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoOcupacionalExists(historicoOcupacional.Id))
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
            return View(historicoOcupacional);
        }

        // GET: HistoricoOcupacional/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HistoricoOcupacional == null)
            {
                return NotFound();
            }

            var historicoOcupacional = await _context.HistoricoOcupacional
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoOcupacional == null)
            {
                return NotFound();
            }

            return View(historicoOcupacional);
        }

        // POST: HistoricoOcupacional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HistoricoOcupacional == null)
            {
                return Problem("Entity set 'AppDbContext.HistoricoOcupacional'  is null.");
            }
            var historicoOcupacional = await _context.HistoricoOcupacional.FindAsync(id);
            if (historicoOcupacional != null)
            {
                _context.HistoricoOcupacional.Remove(historicoOcupacional);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoOcupacionalExists(int id)
        {
          return _context.HistoricoOcupacional.Any(e => e.Id == id);
        }
    }
}
