using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemTA : ItemBase
    {
        public ItemTA(Articulo articulo, int cantidad) : base(articulo, cantidad)
        {
        }

        public int telefono { get; set; }
        public string compañia { get; set; }
        public decimal comision { get; set; }

        public override string imprimir()
        {
            return $"{id} {nombre} precio: {precio} cantidad: {cantidad} subtotal: {SubTotal()}\n " +
                  $"telefono: {telefono} Compañia: {compañia} Comision: {2}\n" +
                  $"\nTotal: {Total()}";
        }

        public override decimal SubTotal()
        {
            return precio * cantidad;
        }

        public override decimal Total()
        {
            return (decimal)SubTotal() + comision;
        }
    }
}
