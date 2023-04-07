using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Alumno
    {
        public Alumno()
        {
        }

        public Alumno(int idA, string nombreA, int calificacion, int idEstado, int idEstatus)
        {
            this.idA = idA;
            this.nombreA = nombreA;
            Calificacion = calificacion;
            this.idEstado = idEstado;
            this.idEstatus = idEstatus;
        }

        public int idA { get; set; }
        public string nombreA { get; set; }
        public int Calificacion { get; set; }

        public int idEstado { get; set; }

        public int idEstatus { get; set; }

    }
}
