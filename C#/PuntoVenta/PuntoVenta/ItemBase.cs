using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {

        protected ItemBase()
        {
        }

        protected ItemBase(Articulo articulo, int cantidad)
        {
            this.id = articulo.id;
            this.nombre = articulo.nombre;
            this.precio = articulo.precio;
            this.cantidad = cantidad;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }

        public virtual decimal SubTotal()
        {
            return precio * cantidad;
        }

        public virtual decimal Total()
        {
            return precio * cantidad;
        }

        public abstract string imprimir();
    }
}
