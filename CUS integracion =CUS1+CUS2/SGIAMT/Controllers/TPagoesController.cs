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
    public class TPagoesController : Controller
    {
        private readonly BD_SGIAMTvscus1cu2Context _context;
        public TPagoesController(BD_SGIAMTvscus1cu2Context context)
        {
            _context = context;
        }
        // GET: TPagoes
        public async Task<IActionResult> Index()
        {
            var bD_SGIAMTContext = _context.TPago.Include(t => t.FkIcpNavigation).Include(t => t.FkIuDniNavigation);
            return View(await bD_SGIAMTContext.ToListAsync());
        }

        // GET: TPagoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tPago = await _context.TPago
                .Include(t => t.FkIcpNavigation)
                .Include(t => t.FkIuDniNavigation)
                .FirstOrDefaultAsync(m => m.PkIpId == id);
            if (tPago == null)
            {
                return NotFound();
            }

            return View(tPago);
        }

        // GET: TPagoes/Create
        public IActionResult Create()
        {
            ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "VcpDescripcion");
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
            return View();
        }



        /*public async Task<IActionResult> Create(int? id)
        {
            ViewData["Usuario"] = new List<TUsuario>.List(_context.TUsuario, "VuNombre", "VuApaterno", "VuAmaterno");
            return View();
        }*/


        // POST: TPagoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIpId,VpValor,VpFecha,VpMes,VpAño,VpPdf,FkIuDni,FkIcpId")] TPago tPago)
        {
            bool pagoMensualExiste = _context.TPago.Any
              (x => x.FkIuDni == tPago.FkIuDni && x.VpMes == tPago.VpMes && x.VpAño == tPago.VpAño);
            if (pagoMensualExiste == true)
            {
                ModelState.AddModelError("VpMes", "EL ALUMNO YA REALIZO ESE PAGO");
                ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "VcpDescripcion");
                ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
                return View();
            }

            bool pagoMatriculaExiste = _context.TPago.Any(x => x.FkIuDni == tPago.FkIuDni && x.FkIcpId == 1 && x.VpAño == tPago.VpAño);
            if (pagoMatriculaExiste == true && tPago.FkIcpId == 1)
            {
                ModelState.AddModelError("VpAño", "EL ALUMNO YA REALIZO ESE PAGO");
                ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "VcpDescripcion");
                ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
                return View();
            }

            bool ConMatricula = _context.TPago.Any(x => x.FkIuDni == tPago.FkIuDni && x.VpAño == tPago.VpAño && x.FkIcpId == 1);
            if (ConMatricula == false && tPago.FkIcpId == 2)
            {
                ModelState.AddModelError("VpMes", "EL ALUMNO AUN NO A PAGO LA MATRICULA");
                ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "VcpDescripcion");
                ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
                return View();
            }

            if (ModelState.IsValid)
            {
                if (tPago.FkIcpId == 1) { tPago.VpValor = 30; tPago.VpMes = ""; }
                if (tPago.FkIcpId == 2) { tPago.VpValor = 80; }
                _context.Add(tPago);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "EUsuarios");
            }
            ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "VcpDescripcion");
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
            return View(tPago);
        }

        // GET: TPagoes/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var tPago = await _context.TPago.FindAsync(id);
        //    if (tPago == null)
        //    {
        //        return NotFound();
        //    }

        //    ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "PkIcpId", tPago.FkIcpId);
        //    ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tPago.FkIuDni);
        //    return View(tPago);
        //}

        //// POST: TPagoes/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("PkIpId,VpValor,VpFecha,VpMes,VpAño,VpPdf,FkIuDni,FkIcpId")] TPago tPago)
        //{
        //    if (id != tPago.PkIpId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(tPago);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TPagoExists(tPago.PkIpId))
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
        //    ViewData["FkIcpId"] = new SelectList(_context.TConceptoPago, "PkIcpId", "PkIcpId", tPago.FkIcpId);
        //    ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tPago.FkIuDni);
        //    return View(tPago);
        //}

        //// GET: TPagoes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var tPago = await _context.TPago
        //        .Include(t => t.FkIcp)
        //        .Include(t => t.FkIuDniNavigation)
        //        .FirstOrDefaultAsync(m => m.PkIpId == id);
        //    if (tPago == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tPago);
        //}

        //// POST: TPagoes/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var tPago = await _context.TPago.FindAsync(id);
        //    _context.TPago.Remove(tPago);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool TPagoExists(int id)
        //{
        //    return _context.TPago.Any(e => e.PkIpId == id);
        //}
    }
}