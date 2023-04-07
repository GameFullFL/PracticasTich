using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuras = new IFigura[2] { new Cuadrado(5), new Triangulo(5,3) };

            foreach (var figura in figuras)
            {
                double area = figura.area();
                Console.WriteLine("El área de la figura es: " + Math.Round(area,2));
                double perimetro = figura.perimetro();
                Console.WriteLine("El perimetro de la figura es: " + perimetro);
            }
            Console.ReadKey();
        }
    }
}
