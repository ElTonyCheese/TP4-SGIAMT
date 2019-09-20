using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWACTPROY.Data;
using SWACTPROY.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace SWACTPROY.Controllers
{
    public class T_SolicitudController : Controller
    {
        private readonly ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        public T_SolicitudController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: T_Solicitud
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.T_Solicitud.Include(t => t.T_Servicio).Include(t => t.T_Cliente).ThenInclude(t => t.T_Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: T_Solicitud/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Solicitud = await _context.T_Solicitud
                .Include(t => t.T_Cliente)
             
                .Include(t => t.T_Servicio)
                .SingleOrDefaultAsync(m => m.idSolicitud == id);
            if (t_Solicitud == null)
            {
                return NotFound();
            }

            return View(t_Solicitud);
        }

        // GET: T_Solicitud/Create
        [Authorize(Roles = "UsuarioActivo")]
        public IActionResult Create()
        {

            string sd = _userManager.GetUserId(User);

            var qcliente = _context.T_Cliente.Where(x => x.idUsuario.Equals(sd)).Select(x => new { idClie = x.idCliente, status = x.razonSocial }).ToList();

            ViewData["idCliente"] = new SelectList(qcliente, "idClie", "status");
            ViewData["idServicio"] = new SelectList(_context.Set<T_Servicio>(), "idServicio", "nombreServicio");

            return View();
        }

        // POST: T_Solicitud/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idSolicitud,detalle,ordentrabajo,estado,idCliente,idServicio")] T_Solicitud t_Solicitud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_Solicitud);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }


            string sd = _userManager.GetUserId(User);

            var qcliente = _context.T_Cliente.Where(x => x.idUsuario.Equals(sd)).Select(x => new { idClie = x.idCliente, status = x.razonSocial }).ToList();

            ViewData["idCliente"] = new SelectList(qcliente, "idClie", "status", t_Solicitud.idCliente);




            ViewData["idServicio"] = new SelectList(_context.Set<T_Servicio>(), "idServicio", "nombreServicio", t_Solicitud.idServicio);
        
            return View(t_Solicitud);

           

        }

        // GET: T_Solicitud/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Solicitud = await _context.T_Solicitud.SingleOrDefaultAsync(m => m.idSolicitud == id);
            if (t_Solicitud == null)
            {
                return NotFound();
            }
            ViewData["idCliente"] = new SelectList(_context.T_Cliente, "idCliente", "idCliente", t_Solicitud.idCliente);

            ViewData["idServicio"] = new SelectList(_context.T_Servicio, "idServicio", "idServicio", t_Solicitud.idServicio);
            return View(t_Solicitud);
        }

        // POST: T_Solicitud/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idSolicitud,detalle,estado,idCliente,idServicio,idOrdenTrabajo")] T_Solicitud t_Solicitud)
        {
            if (id != t_Solicitud.idSolicitud)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Solicitud);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_SolicitudExists(t_Solicitud.idSolicitud))
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
            ViewData["idCliente"] = new SelectList(_context.T_Cliente, "idCliente", "idCliente", t_Solicitud.idCliente);

            ViewData["idServicio"] = new SelectList(_context.T_Servicio, "idServicio", "idServicio", t_Solicitud.idServicio);
            return View(t_Solicitud);
        }

        // GET: T_Solicitud/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Solicitud = await _context.T_Solicitud
                .Include(t => t.T_Cliente)
             
                .Include(t => t.T_Servicio)
                .SingleOrDefaultAsync(m => m.idSolicitud == id);
            if (t_Solicitud == null)
            {
                return NotFound();
            }

            return View(t_Solicitud);
        }

        // POST: T_Solicitud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Solicitud = await _context.T_Solicitud.SingleOrDefaultAsync(m => m.idSolicitud == id);
            _context.T_Solicitud.Remove(t_Solicitud);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_SolicitudExists(int id)
        {
            return _context.T_Solicitud.Any(e => e.idSolicitud == id);
        }
    }
}
