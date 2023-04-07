using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Estado estado = new Estado();
            CRUD crud = new CRUD();
            Dictionary<int, Estado> _listEstados = new Dictionary<int, Estado>();
            char opc;

            do
            {
                Console.WriteLine("\n\t\t\t\t\t\tBIENVENIDO AL MENÚ");
                Console.WriteLine("\n1.- Consultar todos");
                Console.WriteLine("2.- Consultar solo uno");
                Console.WriteLine("3.- Agregar");
                Console.WriteLine("4.- Actualizar");
                Console.WriteLine("5.- Eliminar");
                Console.WriteLine("6.- Terminar");
                Console.Write("\nIngrese una opción");
                opc = Convert.ToChar(Console.ReadLine());
                switch (opc)
                {
                    case '1':
                        _listEstados = crud.ConsultarTodos();
                        foreach (KeyValuePair<int, Estado> kvp in _listEstados)
                        {
                            Console.WriteLine("id = {0}, Nombre del Estado = {1}", kvp.Key, kvp.Value.nombre);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        Console.Write("\nIngrese el id: ");
                        int id = Convert.ToInt16(Console.ReadLine());
                        crud.ConsultarSoloUno(id);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        Console.Write("\nIngrese el id: ");
                        estado.id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\nIngrese el nombre del estado: ");
                        estado.nombre = Console.ReadLine();
                        crud.Agregar(estado);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        Console.Write("\nIngrese el id: ");
                        estado.id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\nIngrese el nombre del estado: ");
                        estado.nombre = Console.ReadLine();
                        crud.Actualizar(estado);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '5':
                        Console.Write("\nIngrese el id: ");
                        int idE = Convert.ToInt16(Console.ReadLine());
                        crud.Eliminar(idE);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\nNo existe la opción ingresada");
                        break;
                }
            } while (Convert.ToString(opc) != "6");


        }
    }
}
