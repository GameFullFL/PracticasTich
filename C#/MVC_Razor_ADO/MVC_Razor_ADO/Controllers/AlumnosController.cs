using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Datos;
using Entidades;
using Negocio;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {
        NAlumno nalumno = new NAlumno();
        Alumno alumno = new Alumno();
        Estado estadoN = new Estado();
        EstatusAlumno estatusN = new EstatusAlumno();
        NEstado estado = new NEstado();
        NEstatusAlumno estatusAlumno = new NEstatusAlumno();

        // GET: Alumnos
        [HttpGet]
        public ActionResult Index()
        {
            
            return View(nalumno.Consultar());
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            alumno = nalumno.Consultar(id);

            estadoN = estado.Consultar(alumno.idEstadoOrigen);
            ViewBag.estado = estadoN.nombre;
            estatusN = estatusAlumno.Consultar(alumno.idEstatus);
            ViewBag.estatus = estatusN.nombre;  

            return View(alumno);
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            alumno.id = (int)id;
            alumno = nalumno.Consultar(alumno.id);
            estadoN = estado.Consultar(alumno.idEstadoOrigen);
            ViewBag.estado = estadoN.nombre;
            estatusN = estatusAlumno.Consultar(alumno.idEstatus);
            ViewBag.estatus = estatusN.nombre;
            return View(alumno);
        }
        [HttpPost]
        public ActionResult Delete(Alumno alumno)
        {
            nalumno.eliminar(alumno.id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.listEstados = estado.Consultar();
            ViewBag.listEstatus = estatusAlumno.Consultar();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (alumno.id.ToString() == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nalumno.Agregar(alumno);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.listEstados = estado.Consultar();
            ViewBag.listEstatus = estatusAlumno.Consultar();
            alumno.id = (int)id;
            alumno = nalumno.Consultar(alumno.id);
            return View(alumno);
        }
        [HttpPost]
        public ActionResult Edit(Alumno alumno)
        {
            nalumno.Actualizar(alumno);
            return RedirectToAction("Index");
        }

    }
}