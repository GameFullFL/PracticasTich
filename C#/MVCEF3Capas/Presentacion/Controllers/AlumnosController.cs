using Entidades;
using Negocio;
using Negocio.WCFAlumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class AlumnosController : Controller
    {
        NAlumno _nAlumno = new NAlumno();
        NEstado _estado = new NEstado();
        NEstatus _estatus = new NEstatus();
        ItemTablaISR _tablaISR = new ItemTablaISR();
        AportacionesIMSS _alumnoIMSS = new AportacionesIMSS();
        

        // GET: Alumnos
        public ActionResult Index()
        {
            return View(_nAlumno.Consultar());
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            return View(_nAlumno.Consultar(id));
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            ViewBag.listEstados = _estado.Consultar();
            ViewBag.listEstatus = _estatus.Consultar();
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumno)
        {
            try
            {
                _nAlumno.Agregar(alumno);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.listEstados = _estado.Consultar();
            ViewBag.listEstatus = _estatus.Consultar();
            return View(_nAlumno.Consultar(id));
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumnos alumno)
        {
            try
            {
                _nAlumno.Actualizar(alumno);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_nAlumno.Consultar(id));
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _nAlumno.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult _AportacionesIMSS(int id)
        {
            _alumnoIMSS = _nAlumno.CalcularIMSS(id);
            return PartialView(_alumnoIMSS);
        }

        public ActionResult _TablaISR(int id)
        {
            _tablaISR = _nAlumno.CalcularISR(id);
            return PartialView(_tablaISR);

        }

    }
}
