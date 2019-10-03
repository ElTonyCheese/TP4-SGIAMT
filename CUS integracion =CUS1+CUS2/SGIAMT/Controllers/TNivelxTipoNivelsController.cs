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
    public class TNivelxTipoNivelsController : Controller
    {
        private readonly BD_SGIAMTvscus1cu2Context _context;

        public TNivelxTipoNivelsController(BD_SGIAMTvscus1cu2Context context)
        {
            _context = context;
        }

        // GET: TNivelxTipoNivels
        public async Task<IActionResult> Index()
        {
            var bD_SGIAMTContext = _context.TNivelxTipoNivel.Include(t => t.FkInCodNavigation).Include(t => t.FkItnCodNavigation).Include(t => t.FkIuDniNavigation);
            return View(await bD_SGIAMTContext.ToListAsync());
        }

      
        public IActionResult Create()
        {
            ViewBag.data = TempData["PkIuDni"].ToString();
            ViewBag.data1 = TempData["VuNombre"].ToString();
            ViewBag.data2 = TempData["DuFechaNacimiento"].ToString();
            ViewData["FkInCod"] = new SelectList(_context.TNivel, "PkInCod", "VnNombreNivel");
            ViewData["FkItnCod"] = new SelectList(_context.TTipoNivel, "PkItnCod", "ItnNombreTipoNivel");
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "VuNombre");
            return View();
        }

        // POST: TNivelxTipoNivels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIntnCod,FkInCod,FkItnCod,NroAlumno,FkIuDni")] TNivelxTipoNivel tNivelxTipoNivel)
        {
            if (ModelState.IsValid)
            {
                if (0 < tNivelxTipoNivel.NroAlumno && tNivelxTipoNivel.NroAlumno < 16)
                {
                    _context.Add(tNivelxTipoNivel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "TPagoes");
                }
                else
                {
               
                    ModelState.AddModelError("NroAlumno", "ya no hay cupos");
                }
            }
            ViewData["FkInCod"] = new SelectList(_context.TNivel, "PkInCod", "VnNombreNivel", tNivelxTipoNivel.FkInCod);
            ViewData["FkItnCod"] = new SelectList(_context.TTipoNivel, "PkItnCod", "ItnNombreTipoNivel", tNivelxTipoNivel.FkItnCod);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "VuNombre", tNivelxTipoNivel.FkIuDni);
            return View(tNivelxTipoNivel);
        }

        // GET: TNivelxTipoNivels/Edit/5
        
    }
}
