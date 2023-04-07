using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuadrado : IFigura
    {

        public Cuadrado()
        {
        }

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double lado { get; set; }

        public double area()
        {
            return lado * lado;
        }
        public double perimetro()
        {
            return lado * 4;
        }
    }
}
