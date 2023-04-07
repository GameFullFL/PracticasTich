using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opc = "", opc2 = "", compañia, ticket;
            int id, cantidad, telefono;
            decimal descuento, comision, payTotal = 0;
            List<Articulo> _listaArticulos = CargarLista.CargarList();
            List<string> _ticket = new List<string>();
            Articulo articulo;
            Console.WriteLine("Presione 'V' para iniciar una nueva Venta");
            Console.WriteLine("Presione 'T' para Terminar");
            opc = Console.ReadLine().ToUpper();
            do
            {
                if (opc == "V")
                {
                    _ticket.Clear();
                    payTotal = 0;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("\nIngresa el id del articulo");
                        id = int.Parse(Console.ReadLine());
                        articulo = _listaArticulos.Find(x => x.id == id);
                        if (articulo.tipo == 1)
                        {
                            Console.WriteLine("Ingresa la cantidad a comprar");
                            cantidad = int.Parse(Console.ReadLine());
                            Item obItem = new Item(articulo, cantidad);
                            ticket = obItem.imprimir();
                            payTotal += obItem.Total();
                            Console.WriteLine($"{ticket}\n");

                        }
                        else if (articulo.tipo == 2)
                        {
                            Console.WriteLine("Ingresa la cantidad a comprar");
                            cantidad = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el porcentaje de descuento");
                            descuento = decimal.Parse(Console.ReadLine());
                            ItemDescuento obItemDesc = new ItemDescuento(articulo, cantidad);
                            obItemDesc.impDescuento = descuento;
                            ticket = obItemDesc.imprimir();
                            Console.WriteLine($"{ticket}\n");
                            payTotal += obItemDesc.Total();
                        }
                        else
                        {
                            Console.WriteLine("Proporcione el telefono");
                            telefono = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Proporcione la Compañia");
                            compañia = Console.ReadLine();
                            Console.WriteLine("Proporcione la comision");
                            comision = decimal.Parse(Console.ReadLine());
                            ItemTA obItemTA = new ItemTA(articulo, 1);
                            obItemTA.telefono = telefono;
                            obItemTA.compañia = compañia;
                            obItemTA.comision = comision;
                            ticket = obItemTA.imprimir();
                            Console.WriteLine($"{ticket}\n");
                            payTotal += obItemTA.Total();
                        }
                        _ticket.Add(ticket);
                        Console.WriteLine("presiona VT para terminar con la venta actual o c para continuar");
                        opc2 = Console.ReadLine().ToUpper();
                    } while (opc2 != "VT");

                }
                Console.Clear();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Empresa TICH");
                foreach (var tic in _ticket)
                {
                    Console.WriteLine($"{tic}\n");
                }
                Console.WriteLine($"TOTAL A PAGAR {payTotal.ToString("c2")}");
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Presione 'V' para iniciar una nueva Venta");
                Console.WriteLine("Presione 'T' para Terminar");
                opc = Console.ReadLine().ToUpper();
            } while (opc != "T");

        }
    }
}
