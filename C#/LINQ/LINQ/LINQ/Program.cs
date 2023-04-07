using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opc;
            OperacionesLINQ operaciones = new OperacionesLINQ();
            (List<Alumno> alumnos, List<Estado> estados, List<Estatus> estatus, List<ItemISR> tablaISR) = operaciones.CargarLists();

            do
            {
                Console.WriteLine("\n\t\t\t\t\t\tBIENVENIDO AL MENÚ");
                Console.WriteLine("\n1.- Obtener el estado con el id 5");
                Console.WriteLine("2.- Obtener  a los alumnos cuyo idEstado 29 y 13, Ordenado por nombre");
                Console.WriteLine("3.- Obtener r los alumnos que son IdEstado 19 y 20 y además de que estén en el estatus 4 o 5");
                Console.WriteLine("4.- Obtener una lista de los alumnos que tienen calificación aprobatoria");
                Console.WriteLine("5.- Obtener la calificación promedio de los alumnos");
                Console.WriteLine("6.- Suma de puntos");
                Console.WriteLine("7.- Mostrar datos con alumnos en estatus 3");
                Console.WriteLine("8.- Mostrar datos con alumnos en estatus 2 ordenado por nombre");
                Console.WriteLine("9.- Mostrar datos con alumnos en estatus mayor a 2 ordenado por estatus");
                Console.WriteLine("F.- Calcular el impuesto para un sueldo mensual de 22,000");
                Console.WriteLine("T.- Termina");
                Console.WriteLine("\nIngrese una opción");
                opc = Convert.ToChar(Console.ReadLine());
                switch (opc.ToString().ToUpper())
                {
                    case "1":
                        operaciones.Consulta1(alumnos, estados);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        operaciones.Consulta2(alumnos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        operaciones.Consulta3(alumnos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        operaciones.Consulta4(alumnos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        operaciones.Consulta5(alumnos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        operaciones.Consulta6(alumnos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        operaciones.Consulta7(alumnos, estados);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        operaciones.Consulta8(alumnos, estatus);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "9":
                        operaciones.Consulta9(alumnos, estados, estatus);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "F":
                        decimal sueldo = 20000m;
                        operaciones.Consulta10(tablaISR, sueldo);
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
