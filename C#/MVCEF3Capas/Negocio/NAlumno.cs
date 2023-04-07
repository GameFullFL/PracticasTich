using Datos;
using Entidades;
using Negocio.WCFAlumno;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        List<Alumnos> _listAlumnos = new List<Alumnos>();
        Alumnos alumno = new Alumnos();
        public List<Alumnos> Consultar()
        {
            _listAlumnos = _DBContext.Alumnos.ToList();
            return _listAlumnos;
        }
        public Alumnos Consultar(int id)
        {
            alumno = _DBContext.Alumnos.Find(id);
            alumno = _DBContext.Alumnos.Include(x => x.Estados).Where(x => x.id == id).FirstOrDefault();
            alumno = _DBContext.Alumnos.Include(x => x.EstatusAlumnos).Where(x => x.id == id).FirstOrDefault();

            return alumno;
        }
        public void Agregar(Alumnos alumno)
        {
            _DBContext.Alumnos.Add(alumno);
            _DBContext.SaveChanges();
        }
        public void Actualizar(Alumnos alumno)
        {
            _DBContext.Entry(alumno).State = EntityState.Modified;
            _DBContext.SaveChanges();
        }

        public void Eliminar(int id)
        {
            alumno = _DBContext.Alumnos.Find(id);
            _DBContext.Alumnos.Remove(alumno);
            _DBContext.SaveChanges();
        }
        public AportacionesIMSS CalcularIMSS(int id)
        {
            WCFAlumnosClient alumnoWCF = new WCFAlumnosClient();
            return alumnoWCF.CalcularIMSS(id);
        }

        public ItemTablaISR CalcularISR(int id)
        {
            WCFAlumnosClient alumnoWCFI = new WCFAlumnosClient();

            return alumnoWCFI.CalcularItemISR(id);
        }




    }
}
