using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {
        private static decimal[,] factores = new decimal[,]
        {
            { 0, 20, 0.05m, 0.05m },
            { 21, 30, 0.1m, 0.1m },
            { 31, 40, 0.4m, 0.4m },
            { 41, 50, 0.5m, 0.55m },
            { 51, 60, 0.65m, 0.7m },
            { 61, decimal.MaxValue, 0.85m, 0.9m }
        };



        public static PolizaResultado Calcular(DateTime fechaInicio, string tipoPeriodo, int cantidadPeriodos,
            decimal sumaAsegurada, DateTime fechaNacimiento, string genero)
        {
            DateTime fechaTermino = fechaInicio;

            switch (tipoPeriodo.ToUpper())
            {
                case "AÑOS":
                    fechaTermino = fechaTermino.AddYears(cantidadPeriodos);
                    break;
                case "MESES":
                    fechaTermino = fechaTermino.AddMonths(cantidadPeriodos);
                    break;
                case "DÍAS":
                    fechaTermino = fechaTermino.AddDays(cantidadPeriodos);
                    break;
                default:
                    throw new ArgumentException("EL PERIODO NO ES VÁLIDO");
            }

            int edad = (int)((fechaInicio - fechaNacimiento).TotalDays / 365);
            int columnaGenero = genero.ToUpper() == "FEMENINO" ? 2 : 3;
            decimal factor = 0;

            for (int i = 0; i < factores.GetLength(0); i++)
            {
                if (edad >= factores[i, 0] && edad <= factores[i, 1])
                {
                    factor = factores[i, columnaGenero];
                    break;
                }
            }

            int diasDuracionPoliza = (fechaTermino - fechaInicio).Days;
            decimal prima = decimal.Round(sumaAsegurada * factor * (diasDuracionPoliza / 360m), 2) ;

            return new PolizaResultado { FechaTermino = fechaTermino, Prima = prima };

        }

        public static void Presentacion()
        {
            try
            {
                Console.Clear();
                Console.Write("Proporciona la fecha de inicio de Vigencia(dd/MM/yyyy): ");
                DateTime fechaInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Ingrese el tipo de periodo (años, meses, días): ");
                string tipoPeriodo = Console.ReadLine();

                Console.Write("Proporciona para cuanto tiempo requieres la póliza (ejemplo 2 años): ");
                int cantidadPeriodos = int.Parse(Console.ReadLine());

                Console.Write("Proporciona la suma asegurada: ");
                decimal sumaAsegurada = decimal.Parse(Console.ReadLine(), null);

                Console.Write("Proporciona la fecha de Nacimiento del asegurado(dd /MM/yyyy): ");
                DateTime fechaNacimiento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Proporciona el género del asegurado(femenino, masculino): ");
                string genero = Console.ReadLine();

                PolizaResultado resultado = Calcular(fechaInicio, tipoPeriodo, cantidadPeriodos, sumaAsegurada, fechaNacimiento, genero);
                Console.WriteLine($"Fecha de término de la póliza: {resultado.FechaTermino.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Prima: {resultado.Prima.ToString()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error de formato: {ex.Message}");
            }
        }

    }
}
