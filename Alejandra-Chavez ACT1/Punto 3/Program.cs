using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
            int num1, num2, num3, num4;
            int suma, promedio;
            string linea;
            Console.WriteLine("ingrese un serie de numeros");
            Console.WriteLine("Ingresa el primer numero");
            linea = Console.ReadLine();
            num1=int.Parse(linea);
            Console.WriteLine("Ingresa el primer numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingresa el primer numero");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.WriteLine("Ingresa el primer numero");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2 + num3 + num4;
            promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("La summe de los numeror ingresados es de"+ suma);
            Console.WriteLine("Y el promedio da en total"+ promedio);

            Console.ReadKey();
        }
    }
}
