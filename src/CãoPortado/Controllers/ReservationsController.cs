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
    public class ReservationsController : Controller
    {
        private readonly Contexto _context;

        public ReservationsController(Contexto context)
        {
            _context = context;
        }

        // GET: Reservations

        public async Task<IActionResult> Index()
        {
              return _context.Reservation != null ? 
                          View(await _context.Reservation.ToListAsync()) :
                          Problem("Entity set 'Contexto.Reservation'  is null.");
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            List<SelectListItem> Serviços = new List<SelectListItem>();
            Serviços.Add(new SelectListItem() { Text = "Serviços", Value = "Serviços" });
            Serviços.Add(new SelectListItem() { Text = "Adestramentos", Value = "Adestramentos" });
            Serviços.Add(new SelectListItem() { Text = "Pet Hotel", Value = "Pet Hotel" });
            Serviços.Add(new SelectListItem() { Text = "Creche", Value = "Creche" });
            ViewBag.Serviços = Serviços;
            List<SelectListItem> QuantidadeDePets = new List<SelectListItem>();
            QuantidadeDePets.Add(new SelectListItem() { Text = "QuantidadeDePets", Value = "0" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "1 Pet", Value = "1" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "2 Pets", Value = "2" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "3 Pets", Value = "3" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "4 Pets", Value = "4" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "5 Pets", Value = "5" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "More", Value = "6" });
            ViewBag.QuantidadeDePets = QuantidadeDePets;
            return View(new ReservationViewModel());
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                Reservation obj = new Reservation()
                {
                    Name = model.Name, Email = model.Email, DataDeChegadaHora = model.DataDeChegadaHora,
                    DataDePartidaHora = model.DataDePartidaHora, Serviços = model.Serviços,
                    QuantidadeDePets = model.QuantidadeDePets
                };

                _context.Reservation.Add(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            //Init
            List<SelectListItem> Serviços = new List<SelectListItem>();
            Serviços.Add(new SelectListItem() { Text = "Serviços", Value = "Serviços" });
            Serviços.Add(new SelectListItem() { Text = "Adestramentos", Value = "Adestramentos" });
            Serviços.Add(new SelectListItem() { Text = "Pet Hotel", Value = "Pet Hotel" });
            Serviços.Add(new SelectListItem() { Text = "Creche", Value = "Creche" });
            ViewBag.Serviços = Serviços;
            List<SelectListItem> QuantidadeDePets = new List<SelectListItem>();
            QuantidadeDePets.Add(new SelectListItem() { Text = "QuantidadeDePets", Value = "0" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "1 Pet", Value = "1" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "2 Pets", Value = "2" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "3 Pets", Value = "3" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "4 Pets", Value = "4" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "5 Pets", Value = "5" });
            QuantidadeDePets.Add(new SelectListItem() { Text = "More", Value = "6" });
            ViewBag.QuantidadeDePets = QuantidadeDePets;

            return View(model);
        }
            

            // GET: Reservations/Edit/5
            public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,DataDeChegadaHora,DataDePartidaHora,Serviços,QuantidadeDePets")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
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
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reservation == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reservation == null)
            {
                return Problem("Entity set 'Contexto.Reservation'  is null.");
            }
            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservation.Remove(reservation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
          return (_context.Reservation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
