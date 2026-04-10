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
            /*2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
(No se ingresan valores por teclado)*/

            int num = 1;
            int valor;

            while (num <= 25)
            {
                valor = num * 11;
                Console.WriteLine(valor);
                Console.WriteLine("-");
                num++;

            }
            Console.ReadKey();
        }
    }
}


