using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data;
using PetHotel.Models;

namespace PetHotel.Controllers
{
    public class CadastroPetsController : Controller
    {
        private readonly Contexto _context;

        public CadastroPetsController(Contexto context)
        {
            _context = context;
        }

        // GET: CadastroPets
        public async Task<IActionResult> Index()
        {
              return _context.CadastroPets != null ? 
                          View(await _context.CadastroPets.ToListAsync()) :
                          Problem("Entity set 'Contexto.CadastroPets'  is null.");
        }

        // GET: CadastroPets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadastroPets == null)
            {
                return NotFound();
            }

            var cadastroPet = await _context.CadastroPets
                .FirstOrDefaultAsync(m => m.CPF_Usuario == id);
            if (cadastroPet == null)
            {
                return NotFound();
            }

            return View(cadastroPet);
        }

        // GET: CadastroPets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroPets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CPF_Usuario,Nome,Porte,Idade,Raca,Vacina")] CadastroPet cadastroPet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroPet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroPet);
        }

        // GET: CadastroPets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadastroPets == null)
            {
                return NotFound();
            }

            var cadastroPet = await _context.CadastroPets.FindAsync(id);
            if (cadastroPet == null)
            {
                return NotFound();
            }
            return View(cadastroPet);
        }

        // POST: CadastroPets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CPF_Usuario,Nome,Porte,Idade,Raca,Vacina")] CadastroPet cadastroPet)
        {
            if (id != cadastroPet.CPF_Usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroPet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroPetExists(cadastroPet.CPF_Usuario))
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
            return View(cadastroPet);
        }

        // GET: CadastroPets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadastroPets == null)
            {
                return NotFound();
            }

            var cadastroPet = await _context.CadastroPets
                .FirstOrDefaultAsync(m => m.CPF_Usuario == id);
            if (cadastroPet == null)
            {
                return NotFound();
            }

            return View(cadastroPet);
        }

        // POST: CadastroPets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadastroPets == null)
            {
                return Problem("Entity set 'Contexto.CadastroPets'  is null.");
            }
            var cadastroPet = await _context.CadastroPets.FindAsync(id);
            if (cadastroPet != null)
            {
                _context.CadastroPets.Remove(cadastroPet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroPetExists(int id)
        {
          return (_context.CadastroPets?.Any(e => e.CPF_Usuario == id)).GetValueOrDefault();
        }
    }
}
