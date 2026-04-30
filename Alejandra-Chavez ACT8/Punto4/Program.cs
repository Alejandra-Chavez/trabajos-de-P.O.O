using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class paisesHabitates
    {
        /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
nuevamente.*/

        private string[] paises;
        private int[] habitantes;
        string linea;

        public void CargarDatos()
        {
            Console.WriteLine("Ingresa el nombre de 5 paises");
          paises = new string[5];
            for(int i = 0;  i < paises.Length; i++)
            {
                Console.WriteLine("Pais " + (i + 1) + ": ");
                paises[i] = Console.ReadLine();
            }
            Console.WriteLine("Y de cada pais ingresa su numero de habitantes");
            habitantes = new int[5];
            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.WriteLine("Habitantes del pais " + (i + 1) + ": ");
                linea = Console.ReadLine();
                    habitantes[i] = int.Parse(linea);
            }
        }

        public void OrdenarAlfabeticamente()
        {

            Console.WriteLine("Países ordenados alfabéticamente:");
            Array.Sort(paises);
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }

        public void OrdenarMayorMenor()
        {
            Console.WriteLine("Los habitantes de los paises ordenados de mayor a menor:");
            Array.Sort(habitantes, paises);
            Array.Reverse(habitantes);
            Array.Reverse(paises);

            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }

        }

        static void Main(string[] args)
        {
            paisesHabitates P = new paisesHabitates();
            P.CargarDatos();
            P.OrdenarAlfabeticamente();
            P.OrdenarMayorMenor();

            Console.ReadKey();
        }
    }
}
