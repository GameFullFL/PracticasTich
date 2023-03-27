using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemDescuento : ItemBase
    {
        public ItemDescuento(Articulo articulo, int cantidad) : base(articulo, cantidad)
        {
        }

        public decimal descuento { get; set; }

        public decimal impDescuento { get; set; }

        public override string imprimir()
        {
            descuento = SubTotal() * impDescuento;
            return $"{id} {nombre} precio: {precio} cantidad: {cantidad} subtotal: {SubTotal()}\nDescuento: {descuento.ToString("c2")} \nTotal: {Total()}";
        }

        public override decimal Total()
        {
            descuento = SubTotal() * impDescuento;
            return SubTotal() - descuento;
        }
    }

}

