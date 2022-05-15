#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using PetHotel.Data;
using PetHotel.Models;

namespace PetHotel.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Contexto _context;

        public ClientesController(Contexto context)
        {
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha,")] Clientes clientes)
        {
            var user = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Email == clientes.Email);

            if (user == null)
            {
                ViewBag.Message= "Usuario e/ou Senha Inválidos!";
                return View();
            }


            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(clientes.Senha, user.Senha);

            if (isSenhaOk)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateAndTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            }

            ViewBag.Message = "Usuario e/ou Senha Inválidos!";
            return View();
            
        }



        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Clientes");


        }


        public IActionResult AccessDenied()
        {
            return View();
        }


        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CPF,DataDeNascimento,Endereco,Telefone,Email,Senha,Senha2")] Clientes clientes)
        {


            if (clientes.Senha != clientes.Senha2)
            {
                ViewBag.Message = "Senhas não conferem. Digite novamente";
                return View();
            }



            if (ModelState.IsValid)
            {
                clientes.Senha = BCrypt.Net.BCrypt.HashPassword(clientes.Senha);
                clientes.Senha2 = BCrypt.Net.BCrypt.HashPassword(clientes.Senha2);
                _context.Add(clientes);
                await _context.SaveChangesAsync();
                ViewBag.Message = "Cadastro realizado com sucesso!";
                return RedirectToAction(nameof(Index));

            }


            return View(clientes);
             
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind("Id,Nome,CPF,DataDeNascimento,Endereco,Telefone,Email,Senha,Senha2")] Clientes clientes)
        {
            if (id != clientes.Id)
            {
                return NotFound();
            }

            if (clientes.Senha != clientes.Senha2)
            {
                ViewBag.Message = "Senhas não conferem. Digite novamente";
                return View();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    clientes.Senha = BCrypt.Net.BCrypt.HashPassword(clientes.Senha);
                    clientes.Senha2 = BCrypt.Net.BCrypt.HashPassword(clientes.Senha2);
                    _context.Update(clientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesExists(clientes.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                ViewBag.Message = "Atualização realizada com sucesso!";
                //return RedirectToAction(nameof(Index));
            }

            return View(clientes);
        }

        // GET: Clientes/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var hospede = await _context.Clientes
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (hospede == null)
                {
                    return NotFound();
                }

                return View(hospede);
            }

            // POST: Hospedes/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var hospede = await _context.Clientes.FindAsync(id);
                _context.Clientes.Remove(hospede);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
