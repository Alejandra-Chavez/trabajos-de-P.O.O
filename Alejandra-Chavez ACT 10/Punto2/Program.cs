using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class intercambioDeFila
    {
        /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.*/
        private int[,] mat;
        private int n,m;
        string linea;

        public void cargaDatos()
        {
            Console.Write("Cuantas filas va a tener la matriz:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.Write("Cuantas columnas va a tener la matriz:");
            linea = Console.ReadLine();
            m = int.Parse(linea);

            mat = new int[n,m];
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

        public void intercambiarFilas()
        {
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                int aux = mat[0, i];
                mat[0, i] = mat[1, i];
                mat[1, i] = aux;
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

        static void Main(string[] args)
        {
            intercambioDeFila I = new intercambioDeFila();
            I.cargaDatos();
            I.intercambiarFilas();
            I.imprimirMatriz();

            Console.ReadKey();
        }
    }
}
