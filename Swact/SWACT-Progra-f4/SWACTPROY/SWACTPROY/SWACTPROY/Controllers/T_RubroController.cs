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
    public class T_RubroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public T_RubroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: T_Rubro
        public async Task<IActionResult> Index()
        {
            return View(await _context.T_Rubro.ToListAsync());
        }

        // GET: T_Rubro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Rubro = await _context.T_Rubro
                .SingleOrDefaultAsync(m => m.idRubro == id);
            if (t_Rubro == null)
            {
                return NotFound();
            }

            return View(t_Rubro);
        }

        // GET: T_Rubro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: T_Rubro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idRubro,nombreRubro,detalleRubro")] T_Rubro t_Rubro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(t_Rubro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(t_Rubro);
        }

        // GET: T_Rubro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Rubro = await _context.T_Rubro.SingleOrDefaultAsync(m => m.idRubro == id);
            if (t_Rubro == null)
            {
                return NotFound();
            }
            return View(t_Rubro);
        }

        // POST: T_Rubro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idRubro,nombreRubro,detalleRubro")] T_Rubro t_Rubro)
        {
            if (id != t_Rubro.idRubro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(t_Rubro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_RubroExists(t_Rubro.idRubro))
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
            return View(t_Rubro);
        }

        // GET: T_Rubro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t_Rubro = await _context.T_Rubro
                .SingleOrDefaultAsync(m => m.idRubro == id);
            if (t_Rubro == null)
            {
                return NotFound();
            }

            return View(t_Rubro);
        }

        // POST: T_Rubro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var t_Rubro = await _context.T_Rubro.SingleOrDefaultAsync(m => m.idRubro == id);
            _context.T_Rubro.Remove(t_Rubro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool T_RubroExists(int id)
        {
            return _context.T_Rubro.Any(e => e.idRubro == id);
        }
    }
}
