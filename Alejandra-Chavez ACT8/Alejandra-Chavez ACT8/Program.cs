using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT8
{
    internal class mayorYRepetidos
    {

        /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
del vector.*/

        int n;
        private int[] V;
        string linea;
        int menor;

        public void cargaDatos()
        {
            Console.Write("Ingre la cantidad de elementos:");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            V = new int[n];
                for(int i=0; i<n;i ++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                V[i] = int.Parse(Console.ReadLine());
            }
        }

        public void buscarMenor()
        {
            menor = V[0];
            for (int i = 1; i < n; i++)
            {
                if (V[i] < menor)
                {
                    menor = V[i];
                }
            }

            Console.WriteLine("El menor es: " + menor);
        }

        public void buscarRepetido()
        {
            int contador = 0;
            for (int i = 0; i < n; i++)
            {
                if (V[i] == menor)
                {
                    contador++;
                }
            }

            if (contador > 1)
            {
                Console.WriteLine("El menor se repite ");
            }
        }

        static void Main(string[] args)
        {
            mayorYRepetidos m = new mayorYRepetidos();
            m.cargaDatos();
            m.buscarMenor();
            m.buscarRepetido();
        }
    }
}
