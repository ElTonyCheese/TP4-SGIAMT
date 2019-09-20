using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWACTPROY.Data;
using SWACTPROY.Models;

namespace SWACTPROY.Controllers
{
    public class T_ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_Cliente
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.T_Cliente.Include(t => t.T_Rubro).Include(t => t.T_Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: T_Cliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Cliente = await _context.T_Cliente
                .SingleOrDefaultAsync(m => m.idCliente == id);
            if (t_Cliente == null)
            {
                return NotFound();
            }

            return View(t_Cliente);
        }

        // GET: T_Cliente/Create
        public IActionResult Create()
        {

            ViewData["idRubro"] = new SelectList(_context.Set<T_Rubro>(), "idRubro", "nombreRubro");
            return View();
        }

        // POST: T_Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCliente,idUsuario,razonSocial,ruc,direccion,idRubro")] T_Cliente t_Cliente)
        {

            bool IsProductNameExist = _context.T_Cliente.Any
        (x => x.ruc == t_Cliente.ruc && x.idCliente != t_Cliente.idCliente);
            if (IsProductNameExist == true)
            {
                ModelState.AddModelError("ruc", "Ya existe este ruc");
            }


            if (ModelState.IsValid)
            {
                _context.Add(t_Cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }


            ViewData["idRubro"] = new SelectList(_context.Set<T_Rubro>(), "idRubro", "nombreRubro", t_Cliente.idRubro);
            return View(t_Cliente);
        }

        // GET: T_Cliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Cliente = await _context.T_Cliente.SingleOrDefaultAsync(m => m.idCliente == id);
            if (t_Cliente == null)
            {
                return NotFound();
            }
            return View(t_Cliente);
        }

        // POST: T_Cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCliente,idUsuario,razonSocial,ruc,direccion,rubro")] T_Cliente t_Cliente)
        {
            if (id != t_Cliente.idCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_ClienteExists(t_Cliente.idCliente))
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
            return View(t_Cliente);
        }

        // GET: T_Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Cliente = await _context.T_Cliente
                .SingleOrDefaultAsync(m => m.idCliente == id);
            if (t_Cliente == null)
            {
                return NotFound();
            }

            return View(t_Cliente);
        }

        // POST: T_Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Cliente = await _context.T_Cliente.SingleOrDefaultAsync(m => m.idCliente == id);
            _context.T_Cliente.Remove(t_Cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_ClienteExists(int id)
        {
            return _context.T_Cliente.Any(e => e.idCliente == id);
        }
    }
}
