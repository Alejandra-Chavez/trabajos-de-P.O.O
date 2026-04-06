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
            /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
   ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
   valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/

            int suma = 0;
            int numero;
            string linea;

            Console.Write("Ingrese un valor: ");
            Console.Write("Ingresa 9999 para terminar ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            while (numero != 9999)
            {
                suma = suma + numero;
                Console.Write("Ingrese un valor: ");
                Console.Write("Ingresa 9999 para terminar ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
            }

            Console.WriteLine("Valor acumulado: " + suma);

            if (suma == 0)
            {
                Console.WriteLine("La suma es cero");
            }
            else
            {
                if (suma > 0)
                {
                    Console.WriteLine("La suma es positiva");
                }
                else
                {
                    Console.WriteLine("La suma es negativa");
                }
            }

        }
    }
}
