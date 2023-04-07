using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class EstatusAlumnos
    {
        public EstatusAlumnos()
        {
        }
        public EstatusAlumnos(int id, string clave, string estatus)
        {
            this.id = id;
            this.clave = clave;
            this.estatus = estatus;
        }

        public int id { get; set; }
        public string clave { get; set; }
        public string estatus { get; set; }
    }
}
