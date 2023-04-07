using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglos
    {
       public static void Cadenas()
        {
            Console.Clear();
            Console.WriteLine("\nProporciona tu nombre completo:");
            string nombre = Console.ReadLine();
            string[] partesNombre = nombre.Split(' ');
            Console.WriteLine("\nHola");
            foreach (string i in partesNombre)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("\nApellido Vertical");
            char[] letras = partesNombre[2].ToCharArray();
            foreach (char i in letras)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void Enteros()
        {
            Console.Clear();
            Int16[] numeros = new Int16[5];
            for (int i = 0; i <5;i++)
            {
                Console.WriteLine($"\nIngrese el número {i+1}:");
                numeros[i] = Convert.ToInt16(Console.ReadLine());

            }
            Console.WriteLine($"\nEl valor máximo es: {numeros.Max()}");
        }

        public static void ConvierteATipoOracion(string parametro)
        {
            Console.Clear();
            string parametroConvertido,letra;
            string[] partesNombre = parametro.Split(' ');
            int i = 0;
            foreach (string p in partesNombre)
            {
                letra = p.Substring(0, 1).ToUpper();
                parametroConvertido = p.Replace(p.Substring(0, 1),letra);
                partesNombre[i] = parametroConvertido;
                i++;
            }
            Console.WriteLine($"{string.Join(" ", partesNombre)}");
        }

    }
}
