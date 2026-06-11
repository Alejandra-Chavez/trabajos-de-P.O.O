using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class sistemLogistica
    {
        /*1. Sistema de Logística: Envíos por Sucursal
Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
cantidad diferente de paquetes por día dependiendo de su demanda.
● Definir un vector de tipo string para los nombres de las 3 sucursales.
● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
represente el peso (en kg) de cada paquete enviado.
● Métodos:
1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
paquetes se enviaron hoy para definir el tamaño de su fila.
2. Cargar el peso de cada paquete.
3. Imprimir el peso de todos los paquetes organizados por sucursal.
4. Calcular e informar el peso total despachado por cada sucursal.
5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
pertenece.*/
        private string[] sucursal;
        private int[][] pesoPaquete;
        string linea;
        int cantidad;

        public void cargarDatos()
        {
            sucursal = new string[3];

            pesoPaquete = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingresa el nombre de la " + (i + 1) + "° Sucursal: ");
                sucursal[i] = Console.ReadLine();

                Console.Write("¿Cuántos paquetes envió hoy?: ");
                linea = Console.ReadLine();

                cantidad = int.Parse(linea);

                pesoPaquete[i] = new int[cantidad];

                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write("Ingresa el peso del paquete: ");
                    linea = Console.ReadLine();

                    pesoPaquete[i][j] = int.Parse(linea);
                }

                Console.WriteLine();
            }
        }
        public void totalPesoPaquetes()
        {
            int suma;

            Console.WriteLine("peso total de los paquetes");

            for (int i = 0; i < 3; i++)
            {
                suma = 0;

                for (int j = 0; j < pesoPaquete[i].Length; j++)
                {
                    suma += pesoPaquete[i][j];
                }

                Console.WriteLine("Sucursal " + sucursal[i] + ": " + suma + " kg");
            }
            Console.WriteLine();
        }
        public void mayorPeso()
        {
            int mayor = pesoPaquete[0][0];
            string sucursalMayor = sucursal[0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < pesoPaquete[i].Length; j++)
                {
                    if (pesoPaquete[i][j] > mayor)
                    {
                        mayor = pesoPaquete[i][j];
                        sucursalMayor = sucursal[i];
                    }
                }
            }

            Console.WriteLine( "El paquete más pesado es de " + mayor + " kg y pertenece a " + sucursalMayor);

            Console.WriteLine();
        }
        public void imprimirInformacion()
        {
            Console.WriteLine("Lista de paquetes:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sucursal: " + sucursal[i]);

                for (int j = 0; j < pesoPaquete[i].Length; j++)
                {
                    Console.WriteLine("Paquete " + (j + 1) + ": " + pesoPaquete[i][j] + " kg");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            sistemLogistica L = new sistemLogistica();
            L.cargarDatos();
            L.totalPesoPaquetes();
            L.mayorPeso();
            L.imprimirInformacion();

            Console.ReadKey();
        }
    }
}
