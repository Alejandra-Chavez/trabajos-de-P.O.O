using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda 
             * "Todos los números son menores a diez"*/
            int NUM1,NUM2,NUM3;
            string linea;

            Console.WriteLine("Ingresa el primer número:");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);

            Console.WriteLine("Ingresa el segundo número:");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);

            Console.WriteLine("Ingresa el tercer número:");
            linea = Console.ReadLine();
            NUM3 = int.Parse(linea);

            if (NUM1< 10 && NUM2 < 10 && NUM3 < 10)
            {
                Console.WriteLine("Todos los números son menores a diez");
            }
            Console.ReadKey();
        }
    }
}
