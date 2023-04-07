using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Triangulo : IFigura
    {
        public Triangulo()
        {
        }

        public Triangulo(double baseT, double cateto)
        {
            this.baseT = baseT;
            this.cateto = cateto;
        }

        public double baseT { get; set; }
        public double altura { get { return Math.Sqrt((cateto * cateto) - ((baseT * baseT) / 4)); } }
        public double cateto { get; set; }

        public double area()
        {
            return (baseT * altura) / 2;
        }
        public double perimetro()
        {
            return baseT + (2 * cateto);
        }
    }
}
