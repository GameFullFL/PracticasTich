using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace MenuGeneral
{
    internal class ISR
    {
        private static decimal[,] matriz;

        public static void CargarTabla(string nombreA)
        {
            int filas = 0;
            int columnas = 0;
            string ruta = $@"C:\Users\Tichs\Desktop\FRANCISCO\C#\MenuGeneral\{nombreA}.csv";
            StreamReader archivo = new StreamReader(ruta);
            // obtener cantidad de filas y columnas del archivo
            string linea; 
            while ((linea = archivo.ReadLine())  != null)
            {
                filas++;
                string[] valores = linea.Split(',');
                columnas = Math.Max(columnas, valores.Length);
            }
            // crear matriz vacía con dimensiones adecuadas
            matriz = new decimal[filas, columnas];
            // volver a leer el archivo para cargar los datos en la matriz
            archivo.BaseStream.Seek(0, SeekOrigin.Begin);
            int fila = 0;
            while ((linea = archivo.ReadLine()) != null)
            {
                string[] valores = linea.Split(',');
                for (int columna = 1; columna < valores.Length; columna++)
                {
                    matriz[fila, columna] = Convert.ToDecimal(valores[columna]);
                }
                fila++;
            }
            archivo.Close();
            // imprimir matriz para verificar que se haya cargado correctamente
            /*
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 1; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            */
        }

        public static decimal Calcular(decimal sueldo)
        {
            decimal quincena = sueldo / 2;
            decimal isrQuincenal = 0;
            decimal isrimpuesto = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (quincena >= matriz[i, 1] && quincena <= matriz[i, 2])
                {
                    decimal LimInf = matriz[i, 1];
                    decimal PorExcLimInf = (matriz[i, 4] / 100);
                    isrQuincenal = (quincena - LimInf) * PorExcLimInf;
                    isrimpuesto = ((isrQuincenal + matriz[i, 3]) - matriz[i, 5]);
                }
            }
            return isrimpuesto;

        }

        public static void Presentacion() 
        {
            Console.WriteLine("Dame el nombre del archivo");
            //NombreArcISR = ;
            CargarTabla(Console.ReadLine());

            Console.WriteLine("Ingresa el sueldo Mensual:");
            decimal sueldoM = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"ISR a Pagar:  {Calcular(sueldoM).ToString("C2")}");
            Console.ReadKey();
        }

    }
}
