using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMarzo23.Data.Context;
using DemoMarzo23.Data.Models;

namespace DemoMarzo23.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly InstitutoContext _context;

        public AlumnosController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: Alumnos
        public async Task<IActionResult> Index()
        {
            var institutoContext = _context.Alumnos.Include(a => a.IdEstadoOrigenNavigation).Include(a => a.IdEstatusNavigation);
            return View(await institutoContext.ToListAsync());
        }

        // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .Include(a => a.IdEstadoOrigenNavigation)
                .Include(a => a.IdEstatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // GET: Alumnos/Create
        public IActionResult Create()
        {
            ViewData["IdEstadoOrigen"] = new SelectList(_context.Estados, "Id", "Id");
            ViewData["IdEstatus"] = new SelectList(_context.EstatusAlumnos, "Id", "Clave");
            return View();
        }

        // POST: Alumnos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,PrimerApellido,SegundoApellido,Correo,Telefono,FechaNacimiento,Curp,Sueldo,IdEstadoOrigen,IdEstatus")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEstadoOrigen"] = new SelectList(_context.Estados, "Id", "Id", alumno.IdEstadoOrigen);
            ViewData["IdEstatus"] = new SelectList(_context.EstatusAlumnos, "Id", "Clave", alumno.IdEstatus);
            return View(alumno);
        }

        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }
            ViewData["IdEstadoOrigen"] = new SelectList(_context.Estados, "Id", "Id", alumno.IdEstadoOrigen);
            ViewData["IdEstatus"] = new SelectList(_context.EstatusAlumnos, "Id", "Clave", alumno.IdEstatus);
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,PrimerApellido,SegundoApellido,Correo,Telefono,FechaNacimiento,Curp,Sueldo,IdEstadoOrigen,IdEstatus")] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoExists(alumno.Id))
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
            ViewData["IdEstadoOrigen"] = new SelectList(_context.Estados, "Id", "Id", alumno.IdEstadoOrigen);
            ViewData["IdEstatus"] = new SelectList(_context.EstatusAlumnos, "Id", "Clave", alumno.IdEstatus);
            return View(alumno);
        }

        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .Include(a => a.IdEstadoOrigenNavigation)
                .Include(a => a.IdEstatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumnoExists(int id)
        {
            return _context.Alumnos.Any(e => e.Id == id);
        }
    }
}
