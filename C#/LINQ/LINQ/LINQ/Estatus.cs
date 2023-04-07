using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Estatus
    {
        public Estatus()
        {
        }

        public Estatus(int idEs, string nombreEs)
        {
            this.idEs = idEs;
            this.nombreEs = nombreEs;
        }

        public int idEs { get; set;}
        public string nombreEs { get; set;}
    }
}
