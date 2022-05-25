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
    public class CadPetController : Controller
    {
        private readonly Contexto _context;

        public CadPetController(Contexto context)
        {
            _context = context;
        }

        // GET: CadPet
        public async Task<IActionResult> Index()
        {
              return _context.CadPet != null ? 
                          View(await _context.CadPet.ToListAsync()) :
                          Problem("Entity set 'Contexto.CadPet'  is null.");
        }

        // GET: CadPet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CadPet == null)
            {
                return NotFound();
            }

            var cadPet = await _context.CadPet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadPet == null)
            {
                return NotFound();
            }

            return View(cadPet);
        }

        // GET: CadPet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadPet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CPF_Usuario,Nome,Idade,Porte,Raca,Raiva,Giárdia,PolivalenteV8ouV10")] CadPet cadPet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadPet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadPet);
        }

        // GET: CadPet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CadPet == null)
            {
                return NotFound();
            }

            var cadPet = await _context.CadPet.FindAsync(id);
            if (cadPet == null)
            {
                return NotFound();
            }
            return View(cadPet);
        }

        // POST: CadPet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CPF_Usuario,Nome,Idade,Porte,Raca,Raiva,Giárdia,PolivalenteV8ouV10")] CadPet cadPet)
        {
            if (id != cadPet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadPet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadPetExists(cadPet.Id))
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
            return View(cadPet);
        }

        // GET: CadPet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CadPet == null)
            {
                return NotFound();
            }

            var cadPet = await _context.CadPet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadPet == null)
            {
                return NotFound();
            }

            return View(cadPet);
        }

        // POST: CadPet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CadPet == null)
            {
                return Problem("Entity set 'Contexto.CadPet'  is null.");
            }
            var cadPet = await _context.CadPet.FindAsync(id);
            if (cadPet != null)
            {
                _context.CadPet.Remove(cadPet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadPetExists(int id)
        {
          return (_context.CadPet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
