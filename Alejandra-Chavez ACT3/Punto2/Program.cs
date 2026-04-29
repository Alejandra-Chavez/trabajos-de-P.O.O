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

            /*2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del 
             * primero con el segundo y a este resultado se lo multiplica por el tercero.*/
            int num1,num2,num3;
            int calculo;
            string linea;

            Console.WriteLine("Ingresa el primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingresa el segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Ingresa el tercer valor:");
            linea = Console.ReadLine();
            num3= int.Parse(linea);

            if (num1 == num2 && num2 == num3)
            {
                calculo = (num1 + num2) * num3;
                Console.WriteLine("El resultado es: " + calculo);
            }
            else
            {
                Console.WriteLine("Los valores ingresados no son iguales");
            }
            Console.ReadKey();
        }
    }
}
