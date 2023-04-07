using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    public class Calculadora
    {
        public static decimal sumar(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
        public static decimal restar(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
        public static decimal multiplicar(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
        public static decimal dividir(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
        public static decimal modulo(decimal n1, decimal n2)
        {
            return n1 % n2;
        }


        public static decimal Operacion(OperacionAritmetica operacionAritmetica)
        {
            decimal result = 0;
            if (operacionAritmetica.operacion == tipoOperacion.sumar)
            {
                result = sumar(operacionAritmetica.num1, operacionAritmetica.num2);
            }
            else if (operacionAritmetica.operacion == tipoOperacion.restar)
            {
                result = restar(operacionAritmetica.num1, operacionAritmetica.num2);
            }
            else if (operacionAritmetica.operacion == tipoOperacion.multiplicar)
            {
                result = multiplicar(operacionAritmetica.num1, operacionAritmetica.num2);
            }
            else if (operacionAritmetica.operacion == tipoOperacion.dividir)
            {
                result = dividir(operacionAritmetica.num1, operacionAritmetica.num2);
            }
            else if (operacionAritmetica.operacion == tipoOperacion.modulo)
            {
                result = modulo(operacionAritmetica.num1, operacionAritmetica.num2);
            }
            return result;
        }
        public static Resultado Simultaneas(decimal n1, decimal n2)
        {
            Resultado result = new Resultado();
            result.suma = sumar(n1, n2);
            result.resta = restar(n1, n2);
            result.multiplicacion = multiplicar(n1, n2);
            result.division = dividir(n1, n2);
            result.modulo = modulo(n1, n2);
            return result;
        }

        public static void Presentacion()
        {
            OperacionAritmetica operacion = new OperacionAritmetica();
            Console.WriteLine("OPERACIÓN A REALIZAR");
            Console.WriteLine("1.- Sumar" + "\n2.- Restar" + "\n3.- Multiplicar" + "\n4.- Dividir" + "\n5.- Módulo" + "\n6.- Todas");
            Console.WriteLine("\nSelecciona operación a realizar");
            operacion.operacion = (tipoOperacion)Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nProporciona el primer numero");
            operacion.num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nProporciona el segundo numero");
            operacion.num2 = Convert.ToDecimal(Console.ReadLine());
            Operacion(operacion);
            if (operacion.operacion == tipoOperacion.todos)
            {
                Resultado resultado = Simultaneas(operacion.num1, operacion.num2);
                Console.WriteLine($"\nEl resultado de la suma es : {resultado.suma}");
                Console.WriteLine($"El resultado de la resta es : {resultado.resta}");
                Console.WriteLine($"El resultado de la multiplicación es : {resultado.multiplicacion}");
                Console.WriteLine($"El resultado de la división es : {resultado.division}");
            }
            else
            {
                Console.WriteLine($"\nEl resultado de {operacion.operacion} es : {Operacion(operacion)}");

            }
            Console.ReadKey();
        }
    }
}
