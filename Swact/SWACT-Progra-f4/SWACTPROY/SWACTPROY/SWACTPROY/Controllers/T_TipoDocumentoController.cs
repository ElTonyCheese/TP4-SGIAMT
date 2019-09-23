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
    public class T_TipoDocumentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_TipoDocumentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_TipoDocumento
        public async Task<IActionResult> Index()
        {
            return View(await _context.T_TipoDocumento.ToListAsync());
        }

        // GET: T_TipoDocumento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_TipoDocumento = await _context.T_TipoDocumento
                .SingleOrDefaultAsync(m => m.idDocumento == id);
            if (t_TipoDocumento == null)
            {
                return NotFound();
            }

            return View(t_TipoDocumento);
        }

        // GET: T_TipoDocumento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: T_TipoDocumento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idDocumento,nombreDoc")] T_TipoDocumento t_TipoDocumento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_TipoDocumento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(t_TipoDocumento);
        }

        // GET: T_TipoDocumento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_TipoDocumento = await _context.T_TipoDocumento.SingleOrDefaultAsync(m => m.idDocumento == id);
            if (t_TipoDocumento == null)
            {
                return NotFound();
            }
            return View(t_TipoDocumento);
        }

        // POST: T_TipoDocumento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idDocumento,nombreDoc")] T_TipoDocumento t_TipoDocumento)
        {
            if (id != t_TipoDocumento.idDocumento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_TipoDocumento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_TipoDocumentoExists(t_TipoDocumento.idDocumento))
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
            return View(t_TipoDocumento);
        }

        // GET: T_TipoDocumento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_TipoDocumento = await _context.T_TipoDocumento
                .SingleOrDefaultAsync(m => m.idDocumento == id);
            if (t_TipoDocumento == null)
            {
                return NotFound();
            }

            return View(t_TipoDocumento);
        }

        // POST: T_TipoDocumento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_TipoDocumento = await _context.T_TipoDocumento.SingleOrDefaultAsync(m => m.idDocumento == id);
            _context.T_TipoDocumento.Remove(t_TipoDocumento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_TipoDocumentoExists(int id)
        {
            return _context.T_TipoDocumento.Any(e => e.idDocumento == id);
        }
    }
}
