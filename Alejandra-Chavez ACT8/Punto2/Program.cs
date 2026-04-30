  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class ordenAlfabetico
    {
        /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
algoritmo de ordenamiento alfabético.*/

        private string [] paises;
        string linea;

        public void ingresoDatos()
        {
            Console.WriteLine("Ingresa el nombre de cinco pasises");
            paises = new string[5];
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Pais " + (i + 1) + ": ");
                paises[i] = Console.ReadLine();
            }

        }

        public void ordenarAlfabticamente()
        {
            
            Console.WriteLine("Países ordenados alfabéticamente:");
            for (int i = 0; i < paises.Length; i++)
            {
                Array.Sort(paises);
                Console.WriteLine(paises[i]);
            }
        }

        static void Main(string[] args)
        {
            ordenAlfabetico O = new ordenAlfabetico();
            O.ingresoDatos();
            O.ordenarAlfabticamente();

            Console.ReadKey();
        }
    }
}
