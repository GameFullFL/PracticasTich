using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCrudEstatusAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opc;
            ADOEstatus estatus = new ADOEstatus();
            Estatus estatusAlu = new Estatus();
            List<Estatus> listConsulta = new List<Estatus>();

            do
            {
                Console.WriteLine("\n\t\t\t\t\t\tBIENVENIDO AL MENÚ");
                Console.WriteLine("\n1.- Consultar Todos");
                Console.WriteLine("2.- Consultar solo uno");
                Console.WriteLine("3.- Agregar");
                Console.WriteLine("4.- Actualizar");
                Console.WriteLine("5.- Eliminar");
                Console.WriteLine("T.- Terminar");
                Console.WriteLine("\nIngrese una opción");
                opc = Convert.ToChar(Console.ReadLine());
                switch (opc.ToString().ToUpper())
                {
                    case "1":
                        listConsulta = estatus.Consultar();
                        foreach (var item in listConsulta)
                        {
                            Console.WriteLine($"id: {item.id} clave: {item.clave} nombre: {item.nombre}");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("Ingrese el id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        estatusAlu = estatus.Consultar(id);
                        Console.WriteLine($"id: {estatusAlu.id} clave: {estatusAlu.clave} nombre: {estatusAlu.nombre}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("Ingrese la clave: ");
                        estatusAlu.clave = Console.ReadLine();
                        Console.Write("Ingrese el estatus del alumno: ");
                        estatusAlu.nombre = Console.ReadLine();
                        estatus.Agregar(estatusAlu);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("Ingrese el id: ");
                        estatusAlu.id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la clave: ");
                        estatusAlu.clave = Console.ReadLine();
                        Console.Write("Ingrese el estatus del alumno: ");
                        estatusAlu.nombre = Console.ReadLine();
                        estatus.Actualizar(estatusAlu);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write("Ingrese el id: ");
                        int idE = Convert.ToInt32(Console.ReadLine());
                        estatus.Eliminar(idE);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("La opción no existe");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (Convert.ToString(opc).ToUpper() != "T");

        }
    }
}
