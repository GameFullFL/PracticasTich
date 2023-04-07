using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;
using Datos;


namespace Negocio
{
    public class NEstado
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        List<Estados> _estado = new List<Estados>();
        Estados estado = new Estados();
        public List<Estados> Consultar()
        {
            return _estado = _DBContext.Estados.ToList();
        }
        public Estados Consultar(int id)
        {
            estado = _DBContext.Estados.Find(id);

            return estado;
        }


    }
}
