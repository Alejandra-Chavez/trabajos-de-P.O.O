using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Ventas
    {
        /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
vectores paralelos, ordenar los datos de mayor a menor según las ventas,
imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
el que menos vendió de los 5 empleados.*/

        private int[] ventas;
        private string[] nombre;
        string linea;

        public void ingresoDatos()
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = new string[5];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                linea = Console.ReadLine();
                nombre[i] = linea;
            }
            Console.WriteLine("Ingrese las ventas que reaizo el empleado:");
            ventas = new int[5];
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write("ventas " + (i + 1) + ": ");
                linea = Console.ReadLine();
                ventas[i] = int.Parse(linea);
            }
        }

        public void ordenMayorMenor()
        {

            int aux;
            string auxNombre;

            for (int i = 0; i < ventas.Length - 1; i++)
            {
                for (int c = 0; c < ventas.Length - 1; c++)
                {
                    if (ventas[c] < ventas[c + 1]) 
                    {
                        
                        aux = ventas[c];
                        ventas[c] = ventas[c + 1];
                        ventas[c + 1] = aux;

                        
                        auxNombre = nombre[c];
                        nombre[c] = nombre[c + 1];
                        nombre[c + 1] = auxNombre;
                    }
                }
            }

            Console.WriteLine("Orden de mayor a menor:");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine(nombre[i] + " - " + ventas[i]);
            }
        }
        static void Main(string[] args)
        {
            Ventas V = new Ventas();
            V.ingresoDatos();
            V.ordenMayorMenor();
            Console.ReadKey();

        }
    }
}
