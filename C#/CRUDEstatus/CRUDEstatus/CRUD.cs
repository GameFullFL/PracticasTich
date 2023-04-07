using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    
    internal class CRUD
    {
        EstatusAlumnos _estatusA;
        private List<EstatusAlumnos> EstatusAlumnos = new List<EstatusAlumnos>();

        public List<EstatusAlumnos> ConsultarTodos() => EstatusAlumnos;
        public EstatusAlumnos ConsultarSoloUno(EstatusAlumnos estatus) => EstatusAlumnos.Find(estA => estA.id == estatus.id);
        public void Agregar(EstatusAlumnos estatus)
        {
            EstatusAlumnos.Add(estatus);
        }
        public void Actualizar(EstatusAlumnos estatus)
        {
            _estatusA = EstatusAlumnos.Find(estA => estA.id == estatus.id);
            _estatusA = estatus;
        }
        public void Eliminar(int id)
        {
            _estatusA = EstatusAlumnos.Find(estA => estA.id == id);
            EstatusAlumnos.Remove(_estatusA);
        }
    }
}
