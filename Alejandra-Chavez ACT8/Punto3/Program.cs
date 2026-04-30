using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class ordenarVector
    {
        /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
(el orden lo pueden elegir ustedes).*/

        private int[] numeros;
        private int n;
        string linea;

        public void cargarDatos()

        {
            Console.Write("Ingrese la cantidad de elementos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            numeros = new int[n];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                linea = Console.ReadLine();
                numeros[i] = int.Parse(linea);
            }
        }
        public void ordenarMenorMayor()
        {
            int aux;

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            Console.WriteLine("\nVector ordenado:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        static void Main(string[] args)
        {
            ordenarVector V = new ordenarVector();
            V.cargarDatos();
            V.ordenarMenorMayor();
        }
    }
}
