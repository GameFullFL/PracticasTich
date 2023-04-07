using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstatusAlumnos estatus = new EstatusAlumnos();
            CRUD crud = new CRUD();
            List<EstatusAlumnos> EstatusAlumnos = new List<EstatusAlumnos>();
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
                Console.Write("\nIngrese una opción: ");
                opc = Convert.ToChar(Console.ReadLine());
                switch (opc)
                {
                    case '1':
                        EstatusAlumnos = crud.ConsultarTodos();
                        foreach (var eAlumnos in EstatusAlumnos)
                        {
                            Console.WriteLine($"Id:{eAlumnos.id}, Clave:{eAlumnos.clave}, Estatus:{eAlumnos.estatus}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        Console.Write("\nIngrese el id: ");
                        estatus.id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine($"Id:{estatus.id}, Clave:{estatus.clave}, Estatus:{estatus.estatus}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        estatus = new EstatusAlumnos();
                        Console.Write("\nIngrese el id: ");
                        estatus.id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\nIngrese la clave: ");
                        estatus.clave = Console.ReadLine();
                        Console.Write("\nIngrese es estatus del Alumno: ");
                        estatus.estatus = Console.ReadLine();
                        crud.Agregar(estatus);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        Console.Write("\nIngrese el id: ");
                        estatus.id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\nIngrese la clave: ");
                        estatus.clave = Console.ReadLine();
                        Console.Write("\nIngrese es estatus del Alumno: ");
                        estatus.estatus = Console.ReadLine();
                        crud.Actualizar(estatus);
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
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (Convert.ToString(opc) != "6");

        }
    }
}
