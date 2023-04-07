using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace MenuGeneral
{
    internal class Archivotxt
    {
        public static void MostratTxt(string nombre)
        {
            string ruta = $@"C:\Users\Tichs\Desktop\FRANCISCO\C#\MenuGeneral\{nombre}.txt";

            if (File.Exists(ruta))
            {
                StreamReader archivo = new StreamReader(ruta);
                archivo.ReadToEnd();
                archivo.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe, se creará un nuevo archivo...");
                Thread.Sleep(3000);
                StreamWriter archivoN = new StreamWriter(ruta);
                Console.WriteLine($"\nEl archivo {nombre} se ha creado");
                archivoN.Close();
            }
        }

        public static void MostrarCSV(string nombre)
        {
            string ruta = $@"C:\Users\Tichs\Desktop\FRANCISCO\C#\MenuGeneral\{nombre}.csv";

            if (File.Exists(ruta))
            {
                StreamReader archivo = new StreamReader(ruta);
                string datos = archivo.ReadToEnd();
                Console.WriteLine(datos);
                archivo.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe, se creará un nuevo archivo...");
                Thread.Sleep(3000);
                StreamWriter archivoN = new StreamWriter(ruta);
                Console.WriteLine($"\nEl archivo {nombre} se ha creado");
                archivoN.Close();
            }

        }

        public static void Presentacion()
        {
            Console.Write("Ingrese el nombre del archivo txt: ");
            string nombre = Console.ReadLine();
            MostratTxt(nombre);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Ingrese el nombre del archivo csv: ");
            string nombreCSV = Console.ReadLine();
            MostrarCSV(nombreCSV);

        }

        public static void EscribirTxt(string nombre, bool estado, string codificacion)
        {
            String condicion = null;
            Encoding codigo;
            

            do
            {
                
                string ruta = $@"C:\Users\Tichs\Desktop\FRANCISCO\C#\MenuGeneral\{nombre}.txt";
                Console.Write("Ingrese sus nombres: ");
                string nombrePersona = Console.ReadLine();
                Console.Write("Ingrese su primer apellido: ");
                String apePat = Console.ReadLine();
                Console.Write("Ingrese su segundo apellido: ");
                String apeMat = Console.ReadLine();
                Console.Write("Ingrese su edad: ");
                Int16 edad = Convert.ToInt16(Console.ReadLine());
                Console.Write("Ingrese el estado de donde proviene: ");
                string estadoPersona = Console.ReadLine();
                switch (codificacion.ToUpper())
                {
                    case "UTF7":
                        codigo = Encoding.UTF7;
                        break;
                    case "UTF8":
                        codigo = Encoding.UTF8;
                        break;
                    case "UNICODE":
                        codigo = Encoding.Unicode;
                        break;
                    case "UTF32":
                        codigo = Encoding.UTF32;
                        break;
                    default:
                        codigo = Encoding.ASCII;
                        break;
                }

                if (estado == true)
                {
                    StreamWriter archivo = new StreamWriter(ruta, estado, codigo);
                    archivo.WriteLine($"{nombrePersona.ToUpper()}, {apePat.ToUpper()}, {apeMat.ToUpper()}, {edad}, {estadoPersona.ToUpper()}");
                    archivo.Close();
                }
                else
                {
                    Console.WriteLine(estado);
                    Console.WriteLine("El archivo no existe, se creará un nuevo archivo...");
                    Thread.Sleep(3000);
                    StreamWriter archivoN = new StreamWriter(ruta, estado, codigo);
                    Console.WriteLine($"\nEl archivo {nombre} se ha creado");
                    archivoN.WriteLine($"{nombrePersona.ToUpper()}, {apePat.ToUpper()}, {apeMat.ToUpper()}, {edad}, {estadoPersona.ToUpper()}");
                    archivoN.Close();
                }
                Console.Clear();
                Console.WriteLine("¿Desea agregar más datos? (SI, NO)");
                condicion = Console.ReadLine();
            } while (condicion.ToUpper() == "SI"); 

        }

    }
}
