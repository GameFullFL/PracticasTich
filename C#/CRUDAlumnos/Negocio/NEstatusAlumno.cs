using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Negocio
{
    public class NEstatusAlumno
    {
        Datos.DEstatusAlumno estatusAlumno = new Datos.DEstatusAlumno();

        public List<EstatusAlumno> Consultar()
        {
            return estatusAlumno.Consultar();
        }
        public EstatusAlumno Consultar(int id) => estatusAlumno.Consultar(id);
    }
}
