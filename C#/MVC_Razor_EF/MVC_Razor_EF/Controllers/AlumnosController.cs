using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Razor_EF.Models;
using System.Data.Entity;

namespace MVC_Razor_EF.Controllers
{
    public class AlumnosController : Controller
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        List<Alumnos> _listAlumnos = new List<Alumnos>();
        Alumnos alumno = new Alumnos();
        // GET: Alumnos
        public ActionResult Index()
        {
            _listAlumnos = _DBContext.Alumnos.ToList();
            return View(_listAlumnos);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            alumno = _DBContext.Alumnos.Find(id);
            return View(alumno);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            ViewBag.listEstados = _DBContext.Estados.ToList();
            ViewBag.listEstatus = _DBContext.EstatusAlumnos.ToList();
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos collection)
        {
            try
            {
                _DBContext.Alumnos.Add(collection);
                _DBContext.SaveChanges();

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
            alumno = _DBContext.Alumnos.Find(id);
            ViewBag.listEstados = _DBContext.Estados.ToList();
            ViewBag.listEstatus = _DBContext.EstatusAlumnos.ToList();
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {

                _DBContext.Entry(collection).State = EntityState.Modified;
                _DBContext.SaveChanges();
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
            alumno = _DBContext.Alumnos.Find(id);
            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _DBContext.Entry(collection).State = EntityState.Deleted;
                _DBContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
