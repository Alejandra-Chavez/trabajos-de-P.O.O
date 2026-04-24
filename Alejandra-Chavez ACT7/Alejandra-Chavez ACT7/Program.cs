using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT7
{
    internal class Mayor
    {
        /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
El valor acumulado de todos los elementos del vector.
El valor acumulado de los elementos del vector que sean mayores a 36.
Cantidad de valores mayores a 50.
             */

        private int[] elementos;
        string linea;

        public void cargaNumeros()
        {
            elementos = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingresa un numero:");
                linea = Console.ReadLine();
                elementos[i] = int.Parse(linea);
            }

        }
        public void sumaElementos()
        {
            int suma;
            suma = 0;
            for (int i = 0; i < 8; i++)
            {
                suma = suma + elementos[i];
            }
            Console.WriteLine("la suma de los numeros ingresados es de:" + suma);
        }
        public void sumaNumMayores()
        {
            int suma;
            suma = 0;
            for (int i = 0; i < 8; i++)
            {
                if (elementos[i] > 36)
                {
                    suma = suma + elementos[i];
                }
            }
            Console.WriteLine("La suma de los numeros mayoresa a 36 es de :" + suma);
        }
        public void numMayor()
        {
            int mayor = 0;
            for (int i = 0; i < 8; i++)
            {
                if (elementos[i] > 50)
                {
                    mayor++;
                }
            }
            Console.WriteLine("La cantidad de numeros mayores a 50 es de:" + mayor);
        }

        static void Main(string[] args)
        {
            Mayor M = new Mayor();
            M.cargaNumeros();
            M.sumaElementos();
            M.sumaNumMayores();
            M.numMayor();

            Console.ReadKey();
        }
    }
}
