using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
muestre la tabla de multiplicar del mismo (los primeros 13 términos)
Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
39.*/
            int numero;
            int resultado;


           Console.Write("Ingrese un número del 1-10: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 13; i++)
            {
                resultado = numero * i;
                Console.WriteLine(resultado);
            }
            Console.ReadKey();
        }
    }
}
