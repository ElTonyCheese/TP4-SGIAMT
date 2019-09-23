using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWACTPROY.Data;
using SWACTPROY.Models;

namespace SWACTPROY.Controllers
{
    public class T_CotizacionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_CotizacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_Cotizacion
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.T_Cotizacion.Include(t => t.T_Solicitud).ThenInclude(t=>t.T_Cliente).ThenInclude(t => t.T_Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: T_Cotizacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Cotizacion = await _context.T_Cotizacion
                .Include(t => t.T_Solicitud).ThenInclude(t => t.T_Cliente).ThenInclude(t => t.T_Usuario)
                  .Include(t => t.T_Solicitud).ThenInclude(t => t.T_Servicio)
                  

                .SingleOrDefaultAsync(m => m.idCotizacion == id);
            if (t_Cotizacion == null)
            {
                return NotFound();
            }

            return View(t_Cotizacion);
        }

        // GET: T_Cotizacion/Create
        public IActionResult Create()
        {
            ViewData["idSolicitud"] = new SelectList(_context.T_Solicitud, "idSolicitud", "detalle");
            return View();
        }

        // POST: T_Cotizacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id ,[Bind("idCotizacion,nombrepdf,precio,duracion,estado,idSolicitud")] T_Cotizacion t_Cotizacion)
        {
            ViewData["ccc"] = id;
            var t_Solicitudx = await _context.T_Solicitud.SingleOrDefaultAsync(m => m.idSolicitud == id);
            var tsolicitudx = t_Solicitudx.idCliente;
            var t_Clientex = await _context.T_Cliente.SingleOrDefaultAsync(m => m.idCliente == tsolicitudx);
            var tclientex = t_Clientex.idUsuario;
            var t_Usuariox = await _context.T_Usuario.SingleOrDefaultAsync(m => m.idUsuario == tclientex);
            var tusuariox = t_Usuariox.email;
            ViewData["correox"] = tclientex;
            //var t_Cotizacion = await _context.T_Cliente.SingleOrDefaultAsync(m => m.idCliente ==1);
            //var correo = t_Cotizacion.correo;

            var path =t_Cotizacion.nombrepdf;

            if (ModelState.IsValid)
            {

                MailMessage mail = new MailMessage();
                mail.To.Add(tusuariox);


                mail.From = new MailAddress("matacraneo17@gmail.com");

                mail.Subject = "COTIZACION SWACT";

                mail.Body = "COTIZACION";
                mail.Attachments.Add(new Attachment(@"C:\Users\Renzo6998\Desktop\Taller de Proyectos\5ta Iteracion\proyectoswact\SWACT\Progra5\SWACT-Progra-f4\SWACTPROY\pdf\" + path));
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     ("matacraneo17@gmail.com", "990146595"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                _context.Add(t_Cotizacion);

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                _context.Add(t_Cotizacion);

                await _context.SaveChangesAsync();
                Content("Mensaje enviado");
                return RedirectToAction("Index", "Home");


            }
            ViewData["idSolicitud"] = new SelectList(_context.T_Solicitud, "idSolicitud", "detalle", t_Cotizacion.idSolicitud);


            return View(t_Cotizacion);

        }

        // GET: T_Cotizacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Cotizacion = await _context.T_Cotizacion.SingleOrDefaultAsync(m => m.idCotizacion == id);
            if (t_Cotizacion == null)
            {
                return NotFound();
            }
            ViewData["idSolicitud"] = new SelectList(_context.T_Solicitud, "idSolicitud", "detalle", t_Cotizacion.idSolicitud);
            return View(t_Cotizacion);
        }

        // POST: T_Cotizacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCotizacion,nombrepdf,precio,duracion,estado,idSolicitud")] T_Cotizacion t_Cotizacion)
        {
            if (id != t_Cotizacion.idCotizacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Cotizacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_CotizacionExists(t_Cotizacion.idCotizacion))
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
            ViewData["idSolicitud"] = new SelectList(_context.T_Solicitud, "idSolicitud", "detalle", t_Cotizacion.idSolicitud);
            return View(t_Cotizacion);
        }

        // GET: T_Cotizacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Cotizacion = await _context.T_Cotizacion
                .Include(t => t.T_Solicitud)
                .SingleOrDefaultAsync(m => m.idCotizacion == id);
            if (t_Cotizacion == null)
            {
                return NotFound();
            }

            return View(t_Cotizacion);
        }

        // POST: T_Cotizacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Cotizacion = await _context.T_Cotizacion.SingleOrDefaultAsync(m => m.idCotizacion == id);
            _context.T_Cotizacion.Remove(t_Cotizacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_CotizacionExists(int id)
        {
            return _context.T_Cotizacion.Any(e => e.idCotizacion == id);
        }
        public IActionResult Imprimir()
        {
            var applicationDbContext = _context.T_Cotizacion.Include(t => t.T_Solicitud);
            return View();
        }
    }
}
