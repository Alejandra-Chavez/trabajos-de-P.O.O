using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class matrizIrregular
    {
        /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
(crearla sin la intervención del operador)
Realizar la carga por teclado e imprimir posteriormente.*/

        private int[][] mat;
        string linea;

        public void cargar()
        {
            mat = new int[5][];

            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = new int[i + 1];

                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write("Ingrese valor: ");
                    linea = Console.ReadLine();
                    mat[i][j] = int.Parse(linea);
                }
            }
        }

        public void imprimir()
        {
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write(mat[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matrizIrregular M = new matrizIrregular();

            M.cargar();
            M.imprimir();

            Console.ReadKey();
        }
    }
}