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
    public class EUsuariosController : Controller
    {
        private readonly BD_SGIAMTContext _context;

        public EUsuariosController(BD_SGIAMTContext context)
        {
            _context = context;
        }
        
        // GET: EUsuarios
        //public async Task<IActionResult> Index()
        //{
        //    var bD_SGIAMTContext = _context.EUsuario.Include(e => e.PkIc).Include(e => e.PkIdiCodNavigation).Include(e => e.PkItuTipoUsuarioNavigation);
        //    return View(await bD_SGIAMTContext.ToListAsync());
        //}

        // GET: EUsuarios/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eUsuario = await _context.EUsuario
        //        .Include(e => e.PkIc)
        //        .Include(e => e.PkIdiCodNavigation)
        //        .Include(e => e.PkItuTipoUsuarioNavigation)
        //        .FirstOrDefaultAsync(m => m.PkIuDni == id);
        //    if (eUsuario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(eUsuario);
        //}

        // GET: EUsuarios/Create
        public IActionResult Create()
        {
            ViewData["PkIcId"] = new SelectList(_context.ECategoría, "PkIcId", "VcNombreCat");
            ViewData["PkIdiCod"] = new SelectList(_context.EDistrito, "PkIdiCod", "VdiNombreDis");
            ViewData["PkItuTipoUsuario"] = new SelectList(_context.ETipoUsuario, "PkItuTipoUsuario", "VtuNombreTipoUsuario");
            return View();
        }

        // POST: EUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,VuCelular,VuCorreo,VuDireccion,DuFechaNacimiento,VuSexo,VuContraseña,VuEstado,VuHorario,FkItuTipoUsuario,FkIcId,FkIdiCod")] EUsuario eUsuario)
        {
            bool Isdniexist = _context.EUsuario.Any
              (x => x.PkIuDni == eUsuario.PkIuDni);
            if (Isdniexist == true)
            {
                ModelState.AddModelError("PkIuDni", "ya existe este dni");
            }

            if (ModelState.IsValid)
            {
                _context.Add(eUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "ENivelxTipoNivels");
            }
            ViewData["PkIcId"] = new SelectList(_context.ECategoría, "PkIcId", "VcNombreCat", eUsuario.FkIcId);
            ViewData["PkIdiCod"] = new SelectList(_context.EDistrito, "PkIdiCod", "VdiNombreDis", eUsuario.FkIdiCod);
            ViewData["PkItuTipoUsuario"] = new SelectList(_context.ETipoUsuario, "PkItuTipoUsuario", "VtuNombreTipoUsuario", eUsuario.FkItuTipoUsuario);
            return View(eUsuario);
        }

        //// GET: EUsuarios/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eUsuario = await _context.EUsuario.FindAsync(id);
        //    if (eUsuario == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["PkIcId"] = new SelectList(_context.ECategoría, "PkIcId", "VcNombreCat", eUsuario.PkIcId);
        //    ViewData["PkIdiCod"] = new SelectList(_context.EDistrito, "PkIdiCod", "VdiNombreDis", eUsuario.PkIdiCod);
        //    ViewData["PkItuTipoUsuario"] = new SelectList(_context.ETipoUsuario, "PkItuTipoUsuario", "VtuNombreTipoUsuario", eUsuario.PkItuTipoUsuario);
        //    return View(eUsuario);
        //}

        //// POST: EUsuarios/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,VuCelular,VuCorreo,VuDireccion,DuFechaNacimiento,VuSexo,VuContraseña,VuEstado,VuHorario,PkItuTipoUsuario,PkIcId,PkIdiCod")] EUsuario eUsuario)
        //{
        //    if (id != eUsuario.PkIuDni)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(eUsuario);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EUsuarioExists(eUsuario.PkIuDni))
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
        //    ViewData["PkIcId"] = new SelectList(_context.ECategoría, "PkIcId", "VcNombreCat", eUsuario.PkIcId);
        //    ViewData["PkIdiCod"] = new SelectList(_context.EDistrito, "PkIdiCod", "VdiNombreDis", eUsuario.PkIdiCod);
        //    ViewData["PkItuTipoUsuario"] = new SelectList(_context.ETipoUsuario, "PkItuTipoUsuario", "VtuNombreTipoUsuario", eUsuario.PkItuTipoUsuario);
        //    return View(eUsuario);
        //}

        //// GET: EUsuarios/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var eUsuario = await _context.EUsuario
        //        .Include(e => e.PkIc)
        //        .Include(e => e.PkIdiCodNavigation)
        //        .Include(e => e.PkItuTipoUsuarioNavigation)
        //        .FirstOrDefaultAsync(m => m.PkIuDni == id);
        //    if (eUsuario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(eUsuario);
        //}

        //// POST: EUsuarios/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var eUsuario = await _context.EUsuario.FindAsync(id);
        //    _context.EUsuario.Remove(eUsuario);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EUsuarioExists(int id)
        //{
        //    return _context.EUsuario.Any(e => e.PkIuDni == id);
        //}
    }
}
