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
    public class T_EntregablesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_EntregablesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: T_Entregable
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.T_Entregables.Include(t => t.t_Usuario).Include(t => t.T_OrdenTrabajo);
            return View(await applicationDbContext.ToListAsync());
        }




        public async Task<IActionResult> Index2()
        {
            var applicationDbContext = _context.T_Entregables.Include(t => t.t_Usuario).Include(t => t.T_OrdenTrabajo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: T_Entregable/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Entregable = await _context.T_Entregables
                .Include(t => t.T_OrdenTrabajo)
                .SingleOrDefaultAsync(m => m.idEntregable == id);
            if (t_Entregable == null)
            {
                return NotFound();
            }

            return View(t_Entregable);
        }

        // GET: T_Entregable/Create
        public IActionResult Create()



        {

            var xd = "93cae9be-e4c5-48c0-b014-1b6b354c74d4";

            var qAsesor = _context.T_Usuario.Where(x => x.idRol.Equals(xd)).Select(x => new { idUsu = x.idUsuario, status = x.nombre }).ToList();

            ViewData["idAsesor"] = new SelectList(qAsesor, "idUsu", "status");

            ViewData["idOrdenTrabajo"] = new SelectList(_context.Set<T_OrdenTrabajo>(), "idOrdenTrabajo", "idOrdenTrabajo");
            return View();
        }

        // POST: T_Entregable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idEntregable,fecha,horaInicio,horaFin,estado,idOrdenTrabajo,idUsuario")] T_Entregables t_Entregable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_Entregable);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "T_OrdenTrabajo");
            }


          var xd= "93cae9be-e4c5-48c0-b014-1b6b354c74d4";
          

                    var qAsesor = _context.T_Usuario.Where(x => x.idRol.Equals(xd)).Select(x => new { idUsu = x.idUsuario, status = x.nombre  }).ToList();

            ViewData["idAsesor"] = new SelectList(qAsesor, "idUsu", "status", t_Entregable.idUsuario);


            ViewData["idOrdenTrabajo"] = new SelectList(_context.Set<T_OrdenTrabajo>(), "idOrdenTrabajo", "idOrdenTrabajo", t_Entregable.idOrdenTrabajo);
            return View(t_Entregable);


        

           
        }

        // GET: T_Entregable/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Entregable = await _context.T_Entregables.SingleOrDefaultAsync(m => m.idEntregable == id);
            if (t_Entregable == null)
            {
                return NotFound();
            }
            ViewData["idOrdenTrabajo"] = new SelectList(_context.Set<T_OrdenTrabajo>(), "idOrdenTrabajo", "idOrdenTrabajo", t_Entregable.idOrdenTrabajo);
            return View(t_Entregable);
        }

        // POST: T_Entregable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idEntregable,fecha,horaInicio,horaFin,idOrdenTrabajo")] T_Entregables t_Entregable)
        {
            if (id != t_Entregable.idEntregable)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Entregable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_EntregableExists(t_Entregable.idEntregable))
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
            ViewData["idOrdenTrabajo"] = new SelectList(_context.Set<T_OrdenTrabajo>(), "idOrdenTrabajo", "idOrdenTrabajo", t_Entregable.idOrdenTrabajo);
            return View(t_Entregable);
        }

        // GET: T_Entregable/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Entregable = await _context.T_Entregables
                .Include(t => t.T_OrdenTrabajo)
                .SingleOrDefaultAsync(m => m.idEntregable == id);
            if (t_Entregable == null)
            {
                return NotFound();
            }

            return View(t_Entregable);
        }

        // POST: T_Entregable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Entregable = await _context.T_Entregables.SingleOrDefaultAsync(m => m.idEntregable == id);
            _context.T_Entregables.Remove(t_Entregable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_EntregableExists(int id)
        {
            return _context.T_Entregables.Any(e => e.idEntregable == id);
        }
    }
}
