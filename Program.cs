using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Práctica43MATH
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;
            long resul;
            Console.Write("Digite un numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            resul = Math.Abs(num1);
            Console.WriteLine("Valor absoluto: " + resul);
            Console.WriteLine("Potencia:  " + Math.Pow(num1, 3));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num1));
            Console.WriteLine("Seno: " + Math.Sin(num1 * Math.PI / 180));
            Console.WriteLine("Coseno: " + Math.Cos(num1 * Math.PI / 180));
            Console.WriteLine("Numero maximo: " + Math.Max(num1, 50));
            Console.WriteLine("Numero minimo: " + Math.Min(num1, 50));
            Console.WriteLine("Parte entera: " + Math.Truncate(18.78));
            Console.WriteLine("Redondeo: " + Math.Round(18.78));
            Console.Write("pulse una tecla: ");
            Console.ReadLine();
        }
    }
}
