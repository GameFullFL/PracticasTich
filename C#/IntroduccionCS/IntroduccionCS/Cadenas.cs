using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Cadenas
    {
        public static void HolaMundo()
        {
            Console.WriteLine("Proporciona tu nombre: ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Proporciona tu primer apellido: ");
            string apePat = Console.ReadLine().Trim();
            Console.WriteLine("Proporciona tu segundo apellido: ");
            string apeMat = Console.ReadLine().Trim();
            Console.WriteLine("Proporciona tu edad: ");
            Int16 edad = Convert.ToInt16(Console.ReadLine().Trim());
            Console.WriteLine("\nHola " + nombre + " " + apePat + " " +
                apeMat);
            Console.WriteLine("\nHola {0} {1} {2} tiene {3} años", nombre,apePat,apeMat,edad);
            string nombreCompleto = String.Join(" ", nombre,apePat,apePat);
            Console.WriteLine($"Gusto en conocerte {nombreCompleto.ToUpper()}!!!");
            string ruta = $@"El archivo fue almacenado en C:\Documentos\Diplomado.Net\{nombreCompleto.ToUpper()}.docx";
            Console.WriteLine("\n" + ruta);
            Console.ReadKey();
        }
    }
}
