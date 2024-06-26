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
    public class ClinicaPregressaController : Controller
    {
        private readonly AppDbContext _context;

        public ClinicaPregressaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ClinicaPregressa
        public async Task<IActionResult> Index()
        {
              return View(await _context.ClinicaPregressa.ToListAsync());
        }

        // GET: ClinicaPregressa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ClinicaPregressa == null)
            {
                return NotFound();
            }

            var clinicaPregressa = await _context.ClinicaPregressa
                .FirstOrDefaultAsync(m => m.MyProperty == id);
            if (clinicaPregressa == null)
            {
                return NotFound();
            }

            return View(clinicaPregressa);
        }

        // GET: ClinicaPregressa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClinicaPregressa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MyProperty,DoencasInfecciosas,Alergias,Cirurgias,TransfusaoSangue,MedicamentosContinuo,Outros")] ClinicaPregressa clinicaPregressa)
        {
            if (ModelState.IsValid)
            {
                if (clinicaPregressa.DoencasInfecciosas == "Nao")
                {
                    clinicaPregressa.DoencasInfecciosas = "Não";
                }
                if (clinicaPregressa.Alergias == "Nao")
                {
                    clinicaPregressa.Alergias = "Não";
                }
                if (clinicaPregressa.Cirurgias == "Nao")
                {
                    clinicaPregressa.Cirurgias = "Não";
                }
                if (clinicaPregressa.TransfusaoSangue == "Nao")
                {
                    clinicaPregressa.TransfusaoSangue = "Não";
                }
                if (clinicaPregressa.MedicamentosContinuo == "Nao")
                {
                    clinicaPregressa.MedicamentosContinuo = "Não";
                }
                _context.Add(clinicaPregressa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "HistoricoOcupacional");
            }
            return View(clinicaPregressa);
        }

        // GET: ClinicaPregressa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ClinicaPregressa == null)
            {
                return NotFound();
            }

            var clinicaPregressa = await _context.ClinicaPregressa.FindAsync(id);
            if (clinicaPregressa == null)
            {
                return NotFound();
            }
            return View(clinicaPregressa);
        }

        // POST: ClinicaPregressa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MyProperty,DoencasInfecciosas,Alergias,Cirurgias,TransfusaoSangue,MedicamentosContinuo,Outros")] ClinicaPregressa clinicaPregressa)
        {
            if (id != clinicaPregressa.MyProperty)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clinicaPregressa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClinicaPregressaExists(clinicaPregressa.MyProperty))
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
            return View(clinicaPregressa);
        }

        // GET: ClinicaPregressa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ClinicaPregressa == null)
            {
                return NotFound();
            }

            var clinicaPregressa = await _context.ClinicaPregressa
                .FirstOrDefaultAsync(m => m.MyProperty == id);
            if (clinicaPregressa == null)
            {
                return NotFound();
            }

            return View(clinicaPregressa);
        }

        // POST: ClinicaPregressa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ClinicaPregressa == null)
            {
                return Problem("Entity set 'AppDbContext.ClinicaPregressa'  is null.");
            }
            var clinicaPregressa = await _context.ClinicaPregressa.FindAsync(id);
            if (clinicaPregressa != null)
            {
                _context.ClinicaPregressa.Remove(clinicaPregressa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClinicaPregressaExists(int id)
        {
          return _context.ClinicaPregressa.Any(e => e.MyProperty == id);
        }
    }
}
