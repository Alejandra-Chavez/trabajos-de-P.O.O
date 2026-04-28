using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Escribir un programa en el cual se ingresen cuatro números,
            //calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
            int num1, num2, num3, num4;
            int suma, producto;
            string linea;

            Console.WriteLine("Ingrese cuatro numeros");
            Console.WriteLine("Ingrese el primer numero:");
            linea= Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer numero:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.WriteLine("Ingrese el cuarto y ultimo numero:");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;
            Console.WriteLine("La suma de los dos primeros dos numeros ingresados es de:" + suma);
            Console.WriteLine("El producto de los dos numeros restantes es de:" + producto);

            Console.ReadKey();
        }
    }
}
