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
            /*4. Se ingresan por teclado tres números, si al menos uno de los valores ingresados
             * es menor a 10, imprimir en pantalla la leyenda "Alguno de los números es menor a diez".*/
            int a, b, c;
            string linea;

            Console.WriteLine("Ingresa el primer número:");
            linea = Console.ReadLine();
            a = int.Parse(linea);

            Console.WriteLine("Ingresa el segundo número:");
            linea = Console.ReadLine();
            b = int.Parse(linea);

            Console.WriteLine("Ingresa el tercer número:");
            linea = Console.ReadLine();
            c = int.Parse(linea);

            if (a < 10 || b < 10 || c < 10)
            {
                Console.WriteLine("Alguno de los tres números es menor a diez");
            }
            Console.ReadKey();
        }
    }
}
