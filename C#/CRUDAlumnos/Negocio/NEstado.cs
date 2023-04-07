using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class NEstado
    {
        Datos.DEstado estado = new Datos.DEstado();

        public List<Estado> Consultar()
        {
            return estado.Consultar();
        }
        public Estado Consultar(int id)=>estado.Consultar(id);  
    }
}
