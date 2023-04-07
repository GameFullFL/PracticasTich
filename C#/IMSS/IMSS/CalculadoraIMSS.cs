using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {
        public static Aportaciones Calcular(decimal SBC, decimal UMA, string indicador)
        {
            Aportaciones aport = new Aportaciones();
            if (indicador.ToUpper() == "TRABAJADOR")
            {
                aport.EnfermedadMaternidad = (SBC - (3 * UMA)) * 0.004m;
                aport.InvalidezVida = SBC * 0.00625m;
                aport.Retiro = SBC * 0;
                aport.Cesantia = SBC * 0.01125m;
                aport.Infonavit = SBC * 0;
            }
            else if (indicador.ToUpper() == "PATRON")
            {
                aport.EnfermedadMaternidad = (SBC - (3 * UMA)) * 0.011m;
                aport.InvalidezVida = SBC * 0.0175m;
                aport.Retiro = SBC * 0.02m;
                aport.Cesantia = SBC * 0.03150m;
                aport.Infonavit = SBC * 0.05m;
            }
            else
            {
                Console.WriteLine("EL INDICADOR NO EXISTE, REVISE BIEN LA ESCRITURA");
            }
            return aport;
        }

        public static void Presentacion()
        {
            Aportaciones aport = new Aportaciones();
            Console.WriteLine("Ingrese el salario Base de Cotización: ");
            decimal SBC = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la Unidad de Medida de Actualización: ");
            decimal UMA = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("¿Es Patrón o Trabajador?");
            string indicador = Console.ReadLine();
            aport = Calcular(SBC,UMA,indicador);
            decimal TOTAL = aport.EnfermedadMaternidad + aport.InvalidezVida + aport.Retiro + aport.Cesantia + aport.Infonavit;
            Console.WriteLine($"Enfermedades y maternidad ${aport.EnfermedadMaternidad}");
            Console.WriteLine($"Invalidez y Vida ${aport.InvalidezVida}");
            Console.WriteLine($"Retiro ${aport.Retiro}");
            Console.WriteLine($"Cesantia ${aport.Cesantia}");
            Console.WriteLine($"Credito infonavit ${aport.Infonavit}");
            Console.WriteLine($"EL TOTAL ES ${TOTAL}");
            Console.ReadKey();
            
        }
    }
}
