using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Item : ItemBase
    {
        public Item(Articulo articulo, int cantidad) : base(articulo, cantidad)
        {
        }

        public override decimal Total()
        {
            return SubTotal();
        }

        public override string imprimir()
        {
            return $"{id} {nombre} precio: {precio} cantidad: {cantidad} subtotal: {SubTotal()}\n Total: {Total()}";
        }
    }
}
