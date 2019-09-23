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
    public class T_VersionamientoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_VersionamientoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_Versionamiento
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.T_Versionamiento.Include(t => t.T_Cotizacion);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: T_Versionamiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Versionamiento = await _context.T_Versionamiento
                .Include(t => t.T_Cotizacion)
                .SingleOrDefaultAsync(m => m.idVersion == id);
            if (t_Versionamiento == null)
            {
                return NotFound();
            }

            return View(t_Versionamiento);
        }

        // GET: T_Versionamiento/Create
        public IActionResult Create()
        {
            ViewData["idCotizacion"] = new SelectList(_context.T_Cotizacion, "idCotizacion", "estado");
            return View();
        }

        // POST: T_Versionamiento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idVersion,nombrepdf,precio,fechaCreacion,fechaCotizacion,detalleRespuesta,estado,idSolicitud,idCotizacion")] T_Versionamiento t_Versionamiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_Versionamiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCotizacion"] = new SelectList(_context.T_Cotizacion, "idCotizacion", "estado", t_Versionamiento.idCotizacion);
            return View(t_Versionamiento);
        }

        // GET: T_Versionamiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Versionamiento = await _context.T_Versionamiento.SingleOrDefaultAsync(m => m.idVersion == id);
            if (t_Versionamiento == null)
            {
                return NotFound();
            }
            ViewData["idCotizacion"] = new SelectList(_context.T_Cotizacion, "idCotizacion", "estado", t_Versionamiento.idCotizacion);
            return View(t_Versionamiento);
        }

        // POST: T_Versionamiento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idVersion,nombrepdf,precio,fechaCreacion,fechaRespuesta,detalleRespuesta,estado,idCotizacion")] T_Versionamiento t_Versionamiento)
        {
            if (id != t_Versionamiento.idVersion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Versionamiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_VersionamientoExists(t_Versionamiento.idVersion))
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
            ViewData["idCotizacion"] = new SelectList(_context.T_Cotizacion, "idCotizacion", "estado", t_Versionamiento.idCotizacion);
            return View(t_Versionamiento);
        }

        // GET: T_Versionamiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Versionamiento = await _context.T_Versionamiento
                .Include(t => t.T_Cotizacion)
                .SingleOrDefaultAsync(m => m.idVersion == id);
            if (t_Versionamiento == null)
            {
                return NotFound();
            }

            return View(t_Versionamiento);
        }

        // POST: T_Versionamiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Versionamiento = await _context.T_Versionamiento.SingleOrDefaultAsync(m => m.idVersion == id);
            _context.T_Versionamiento.Remove(t_Versionamiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_VersionamientoExists(int id)
        {
            return _context.T_Versionamiento.Any(e => e.idVersion == id);
        }
    }
}
