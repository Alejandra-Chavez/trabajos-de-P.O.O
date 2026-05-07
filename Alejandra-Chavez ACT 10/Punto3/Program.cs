using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class mismoVertice
    {
        /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)*/
        private int[,] mat;
        private int n, m;
        string linea;

        public void cargaDatos()
        {
            Console.Write("Cuantas filas va a tener la matriz:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.Write("Cuantas columnas va a tener la matriz:");
            linea = Console.ReadLine();
            m = int.Parse(linea);

            mat = new int[n, m];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int f = 0; f < mat.GetLength(1); f++)
                {
                    Console.WriteLine("Ingrese componentes:");
                    linea = Console.ReadLine();
                    mat[i, f] = int.Parse(linea);
                }
            }
        }

        public void imprimirMatriz()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int f = 0; f < mat.GetLength(1); f++)
                {
                    Console.Write(mat[i, f] + " ");
                }

                Console.WriteLine();
            }

        }
        public void imprimirVertices()
        {
            Console.WriteLine("Vertices de la matriz:");

            Console.WriteLine("Superior izquierdo: " + mat[0, 0]);
            Console.WriteLine("Superior derecho: " + mat[0, m - 1]);
            Console.WriteLine("Inferior izquierdo: " + mat[n - 1, 0]);
            Console.WriteLine("Inferior derecho: " + mat[n - 1, m - 1]);
        }



        static void Main(string[] args)
        {
            mismoVertice M = new mismoVertice();
            M.cargaDatos();
            M.imprimirMatriz();
            M.imprimirVertices();

            Console.ReadKey();
        }
    }
}
