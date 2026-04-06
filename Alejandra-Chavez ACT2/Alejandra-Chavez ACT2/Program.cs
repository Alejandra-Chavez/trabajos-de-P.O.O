using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia,
             * en caso contrario informar el producto y la división del primero respecto al segundo.*/

            int num1, num2;
            int suma, resta;
            int producto, division;
            Console.Write("Ingrese el primer número: ");
            string linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo número: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                suma = num1 + num2;
                resta = num1 - num2;

                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Diferencia: " + resta);
            }
            else
            {
                producto = num1 * num2;
                division = num1 / num2;

                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("División: " + division);
            }
        }
    }
}

