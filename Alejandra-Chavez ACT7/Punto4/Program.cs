using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class MayorMenor
    {
        /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
ordenado de menor a mayor y de mayor a menor.*/

        private int[] num;
        string linea;

        public void ingresarNumeros()
        {
            num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingresa un numero:");
                linea = Console.ReadLine();
                num[i] = int.Parse(linea);
            }
        }
        public void saberSiEstaOrdenado()
        {
            bool menorMayor = true;
            bool mayorMenor = true;

            for (int i = 0; i < 9; i++)
            {
                if (num[i] > num[i + 1])
                {
                    menorMayor = false;
                }

                if (num[i] < num[i + 1])
                {
                    mayorMenor = false;
                }
            }

            if (menorMayor)
            {
                Console.WriteLine("Está ordenado de menor a mayor");
            }
            else if (mayorMenor)
            {
                Console.WriteLine("Está ordenado de mayor a menor");
            }
            else
            {
                Console.WriteLine("No está ordenado");
            }
        }

        static void Main(string[] args)
        {
            MayorMenor MM = new MayorMenor();
            MM.ingresarNumeros();
            MM.saberSiEstaOrdenado();

            Console.ReadKey();
        }
    }
}
