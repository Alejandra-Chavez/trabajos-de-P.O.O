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
            /*3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
a) La cantidad de valores ingresados negativos.
b) La cantidad de valores ingresados positivos.
c) La cantidad de múltiplos de 15.
d) El valor acumulado de los números ingresados que son pares.*/

            int negativos = 0;
            int positivos = 0;
            int multiplos15 = 0;
            int sumaPares = 0;
            int num;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese un número: ");
                 num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }

                if (num % 15 == 0)
                {
                    multiplos15++;
                }

                if (num % 2 == 0)
                {
                    sumaPares = sumaPares + num;
                }
            }

            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de múltiplos de 15: " + multiplos15);
            Console.WriteLine("Suma de números pares: " + sumaPares);
            
            Console.ReadKey();
        }
    }
}
  

