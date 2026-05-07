using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT_10
{
    using System;

    internal class Matriz
    {
        /*1- Crear una matriz de 2 filas y 5 columnas.
        Realizar la carga de componentes por columna.
        Imprimir luego la matriz.*/

        private int[,] mat;
        string linea;

        public void cargar()
        {
            mat = new int[2, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.WriteLine("Ingrese componentes:");
                    linea = Console.ReadLine();
                    mat[f, i] = int.Parse(linea);
                }
            }
        }

        public void imprimirMatriz()
        {
            for (int f = 0; f < 2; f++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(mat[f, i] + " ");
                }

                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Matriz M = new Matriz();

            M.cargar();
            M.imprimirMatriz();
            Console.ReadKey();
        }
    }
}
