using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.*/

            int num1, num2, num3;

            Console.Write("Ingrese el primer número: ");
            string linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo número: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer número: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El mayor es: " + num1);
                }
                else
                {
                    Console.WriteLine("El mayor es: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("El mayor es: " + num3);
                }
            }
            Console.ReadKey();
        }
    }
}




