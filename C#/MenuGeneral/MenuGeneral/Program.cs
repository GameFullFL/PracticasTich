using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char opc;

            do
            {
                Console.WriteLine("\n\t\t\t\t\t\tBIENVENIDO AL MENÚ");
                Console.WriteLine("\n1.- Cadenas de texto");
                Console.WriteLine("2.- Valor máximo de numeros enteros");
                Console.WriteLine("3.- Convierte a tipo oración");
                Console.WriteLine("4.- Poliza");
                Console.WriteLine("5.- Archivos(txt y csv)");
                Console.WriteLine("6.- Escribir archivos txt");
                Console.WriteLine("7.- Archivos txt");
                Console.WriteLine("8.- Archivos csv");
                Console.WriteLine("F.- Termina");
                Console.WriteLine("\nIngrese una opción");
                opc = Convert.ToChar(Console.ReadLine());
                switch (opc)
                {
                    case '1':
                        Arreglos.Cadenas();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        Arreglos.Enteros();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("\nIngrese un texto:");
                        string texto = Console.ReadLine();
                        Arreglos.ConvierteATipoOracion(texto);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        Poliza.Presentacion();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '5':
                        Archivotxt.Presentacion();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '6':
                        Console.Clear();
                        Console.Write("Ingrese el nombre del archivo: ");
                        string nombre = Console.ReadLine();
                        Console.Write("¿El archivo es nuevo? 1)SI 2)NO: ");
                        Int16 o = Convert.ToInt16(Console.ReadLine());
                        bool condicion = o == 1 ? false : true;
                        Console.Write("Ingrese la codificación: ");
                        string codificacion = Console.ReadLine();
                        Archivotxt.EscribirTxt(nombre,condicion,codificacion);
                        Console.Clear();
                        break;
                    case '7':
                        Console.Write("Ingrese el nombre del archivo: ");
                        string nombres = Console.ReadLine();
                        Archivotxt.MostratTxt(nombres);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '8':
                        Console.Write("Ingrese el nombre del archivo: ");
                        string nombreCSV = Console.ReadLine();
                        Archivotxt.MostratTxt(nombreCSV);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        ISR.Presentacion();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (Convert.ToString(opc).ToUpper() != "F");
   
        }
    }
    }
