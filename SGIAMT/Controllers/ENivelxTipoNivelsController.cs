using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGIAMT.Models;

namespace SGIAMT.Controllers
{
    public class ENivelxTipoNivelsController : Controller
    {
        private readonly BD_SGIAMTContext _context;

        public ENivelxTipoNivelsController(BD_SGIAMTContext context)
        {
            _context = context;
        }

        // GET: ENivelxTipoNivels
        public async Task<IActionResult> Index()
        {
            var bD_SGIAMTContext = _context.ENivelxTipoNivel.Include(e => e.FkInCodNavigation).Include(e => e.FkItnCodNavigation).Include(e => e.FkIuDniNavigation);
            return View(await bD_SGIAMTContext.ToListAsync());
        }

        // GET: ENivelxTipoNivels/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eNivelxTipoNivel = await _context.ENivelxTipoNivel
        //        .Include(e => e.FkInCodNavigation)
        //        .Include(e => e.FkItnCodNavigation)
        //        .Include(e => e.FkIuDniNavigation)
        //        .FirstOrDefaultAsync(m => m.PkIntnCod == id);
        //    if (eNivelxTipoNivel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(eNivelxTipoNivel);
        //}

        // GET: ENivelxTipoNivels/Create
        public IActionResult Create()
        {
            ViewData["FkInCod"] = new SelectList(_context.ENivel, "PkInCod", "VnNombreNivel");
            ViewData["FkItnCod"] = new SelectList(_context.ETipoNivel, "PkItnCod", "ItnNombreTipoNivel");
            ViewData["FkIuDni"] = new SelectList(_context.EUsuario, "PkIuDni", "VuNombre");
            return View();
        }

        // POST: ENivelxTipoNivels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIntnCod,FkInCod,FkItnCod,NroAlumno,FkIuDni")] ENivelxTipoNivel eNivelxTipoNivel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eNivelxTipoNivel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["FkInCod"] = new SelectList(_context.ENivel, "PkInCod", "VnNombreNivel", eNivelxTipoNivel.FkInCod);
            ViewData["FkItnCod"] = new SelectList(_context.ETipoNivel, "PkItnCod", "ItnNombreTipoNivel", eNivelxTipoNivel.FkItnCod);
            ViewData["FkIuDni"] = new SelectList(_context.EUsuario, "PkIuDni", "VuNombre", eNivelxTipoNivel.FkIuDni);
            return View(eNivelxTipoNivel);
        }

        //// GET: ENivelxTipoNivels/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eNivelxTipoNivel = await _context.ENivelxTipoNivel.FindAsync(id);
        //    if (eNivelxTipoNivel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["FkInCod"] = new SelectList(_context.ENivel, "PkInCod", "VnNombreNivel", eNivelxTipoNivel.FkInCod);
        //    ViewData["FkItnCod"] = new SelectList(_context.ETipoNivel, "PkItnCod", "ItnNombreTipoNivel", eNivelxTipoNivel.FkItnCod);
        //    ViewData["FkIuDni"] = new SelectList(_context.EUsuario, "PkIuDni", "VuAmaterno", eNivelxTipoNivel.FkIuDni);
        //    return View(eNivelxTipoNivel);
        //}

        //// POST: ENivelxTipoNivels/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("PkIntnCod,FkInCod,FkItnCod,NroAlumno,FkIuDni")] ENivelxTipoNivel eNivelxTipoNivel)
        //{
        //    if (id != eNivelxTipoNivel.PkIntnCod)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(eNivelxTipoNivel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ENivelxTipoNivelExists(eNivelxTipoNivel.PkIntnCod))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FkInCod"] = new SelectList(_context.ENivel, "PkInCod", "VnNombreNivel", eNivelxTipoNivel.FkInCod);
        //    ViewData["FkItnCod"] = new SelectList(_context.ETipoNivel, "PkItnCod", "ItnNombreTipoNivel", eNivelxTipoNivel.FkItnCod);
        //    ViewData["FkIuDni"] = new SelectList(_context.EUsuario, "PkIuDni", "VuAmaterno", eNivelxTipoNivel.FkIuDni);
        //    return View(eNivelxTipoNivel);
        //}

        //// GET: ENivelxTipoNivels/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eNivelxTipoNivel = await _context.ENivelxTipoNivel
        //        .Include(e => e.FkInCodNavigation)
        //        .Include(e => e.FkItnCodNavigation)
        //        .Include(e => e.FkIuDniNavigation)
        //        .FirstOrDefaultAsync(m => m.PkIntnCod == id);
        //    if (eNivelxTipoNivel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(eNivelxTipoNivel);
        //}

        //// POST: ENivelxTipoNivels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var eNivelxTipoNivel = await _context.ENivelxTipoNivel.FindAsync(id);
        //    _context.ENivelxTipoNivel.Remove(eNivelxTipoNivel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ENivelxTipoNivelExists(int id)
        //{
        //    return _context.ENivelxTipoNivel.Any(e => e.PkIntnCod == id);
        //}
    }
}
