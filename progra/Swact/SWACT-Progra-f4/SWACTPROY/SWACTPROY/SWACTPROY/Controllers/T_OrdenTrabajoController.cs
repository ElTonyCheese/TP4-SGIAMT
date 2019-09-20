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
    public class T_OrdenTrabajoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_OrdenTrabajoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_OrdenTrabajo
        public async Task<IActionResult> Index()
            
        {

            var applicationDbContext = _context.T_OrdenTrabajo.Include(t => t.t_Solicitud);
            return View(await applicationDbContext.ToListAsync());

        }

        // GET: T_OrdenTrabajo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_OrdenTrabajo = await _context.T_OrdenTrabajo
                .SingleOrDefaultAsync(m => m.idOrdenTrabajo == id);
            if (t_OrdenTrabajo == null)
            {
                return NotFound();
            }

            return View(t_OrdenTrabajo);
        }

        // GET: T_OrdenTrabajo/Create
        public IActionResult Create()
        {
                       
    
            return View();
        }

        // POST: T_OrdenTrabajo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idOrdenTrabajo,progreso,estado,idSolicitud")] T_OrdenTrabajo t_OrdenTrabajo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_OrdenTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(t_OrdenTrabajo);
        }

        // GET: T_OrdenTrabajo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_OrdenTrabajo = await _context.T_OrdenTrabajo.SingleOrDefaultAsync(m => m.idOrdenTrabajo == id);
            if (t_OrdenTrabajo == null)
            {
                return NotFound();
            }
            return View(t_OrdenTrabajo);
        }

        // POST: T_OrdenTrabajo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idOrdenTrabajo,idUsuario,progreso,estado")] T_OrdenTrabajo t_OrdenTrabajo)
        {
            if (id != t_OrdenTrabajo.idOrdenTrabajo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_OrdenTrabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_OrdenTrabajoExists(t_OrdenTrabajo.idOrdenTrabajo))
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
            return View(t_OrdenTrabajo);
        }

        // GET: T_OrdenTrabajo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_OrdenTrabajo = await _context.T_OrdenTrabajo
                .SingleOrDefaultAsync(m => m.idOrdenTrabajo == id);
            if (t_OrdenTrabajo == null)
            {
                return NotFound();
            }

            return View(t_OrdenTrabajo);
        }

        // POST: T_OrdenTrabajo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_OrdenTrabajo = await _context.T_OrdenTrabajo.SingleOrDefaultAsync(m => m.idOrdenTrabajo == id);
            _context.T_OrdenTrabajo.Remove(t_OrdenTrabajo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_OrdenTrabajoExists(int id)
        {
            return _context.T_OrdenTrabajo.Any(e => e.idOrdenTrabajo == id);
        }
    }
}
