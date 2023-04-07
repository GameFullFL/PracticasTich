using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace Presentacion.Controllers
{
    public class EstatusAlumnosController : Controller
    {
        NEstatus _estatus = new NEstatus();
        // GET: EstatusAlumnos
        public ActionResult Index()
        {
            return View(_estatus.Consultar());
        }

        // GET: EstatusAlumnos/Details/5
        public ActionResult Details(int id)
        {
            return View(_estatus.Consultar(id));
        }

        // GET: EstatusAlumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstatusAlumnos/Create
        [HttpPost]
        public ActionResult Create(EstatusAlumnos estatusAlumnos)
        {
            try
            {
                _estatus.Agregar(estatusAlumnos); 
            }
            catch
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: EstatusAlumnos/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_estatus.Consultar(id)); 
        }

        // POST: EstatusAlumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EstatusAlumnos estatusAlumnos)
        {
            try
            {
                _estatus.Actualizar(estatusAlumnos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstatusAlumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_estatus.Consultar(id));
        }

        // POST: EstatusAlumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EstatusAlumnos estatusAlumnos)
        {
            try
            {
                _estatus.Eliminar(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
