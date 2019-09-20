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
    public class T_ServicioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_ServicioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_Servicio
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.T_Servicio.Include(t => t.T_Rubro);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: T_Servicio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Servicio = await _context.T_Servicio
                .Include(t => t.T_Rubro)
                .SingleOrDefaultAsync(m => m.idServicio == id);
            if (t_Servicio == null)
            {
                return NotFound();
            }

            return View(t_Servicio);
        }

        // GET: T_Servicio/Create
        public IActionResult Create()
        {
            ViewData["idRubro"] = new SelectList(_context.T_Rubro, "idRubro", "nombreRubro");
            return View();
        }

        // POST: T_Servicio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idServicio,nombreServicio,detalle,idRubro")] T_Servicio t_Servicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_Servicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idRubro"] = new SelectList(_context.T_Rubro, "idRubro", "nombreRubro", t_Servicio.idRubro);
            return View(t_Servicio);
        }

        // GET: T_Servicio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Servicio = await _context.T_Servicio.SingleOrDefaultAsync(m => m.idServicio == id);
            if (t_Servicio == null)
            {
                return NotFound();
            }
            ViewData["idRubro"] = new SelectList(_context.T_Rubro, "idRubro", "nombreRubro", t_Servicio.idRubro);
            return View(t_Servicio);
        }

        // POST: T_Servicio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idServicio,nombreServicio,detalle,idRubro")] T_Servicio t_Servicio)
        {
            if (id != t_Servicio.idServicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Servicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_ServicioExists(t_Servicio.idServicio))
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
            ViewData["idRubro"] = new SelectList(_context.T_Rubro, "idRubro", "idRubro", t_Servicio.idRubro);
            return View(t_Servicio);
        }

        // GET: T_Servicio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Servicio = await _context.T_Servicio
                .Include(t => t.T_Rubro)
                .SingleOrDefaultAsync(m => m.idServicio == id);
            if (t_Servicio == null)
            {
                return NotFound();
            }

            return View(t_Servicio);
        }

        // POST: T_Servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Servicio = await _context.T_Servicio.SingleOrDefaultAsync(m => m.idServicio == id);
            _context.T_Servicio.Remove(t_Servicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_ServicioExists(int id)
        {
            return _context.T_Servicio.Any(e => e.idServicio == id);
        }
    }
}
