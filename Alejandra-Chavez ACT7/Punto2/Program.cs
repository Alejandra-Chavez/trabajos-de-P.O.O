using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class sumaVectores
    {
        /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
tercer vector del mismo tamaño. Sumar componente a componente.*/

        private int[] Vec1;
        private int[] Vec2;
        private int[] Vec3;
        string linea;

        public void IngresoDeDatos()
        {
            Vec1= new int[4];
            Vec2 = new int[4];
            Console.Write("Ingresa cuatro numeros para el primer vector =");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingresa un numero:");
                linea = Console.ReadLine();
                Vec1[i] = int.Parse(linea);
            }
            Console.Write("Ingresa cuatro numeros para el segundo vector =");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingresa un numero:");
                linea = Console.ReadLine();
                Vec2[i] = int.Parse(linea);
            }

        }
        public void sumaEntreVectores()
        {
            int sum;
            sum = 0;
            for (int i = 0; i < 4; i++)
            {
               sum = Vec1[i] + Vec2[i];
                Vec3 = new int[sum];
                Console.WriteLine("La suma de cada componenete da:" + sum);
            }


        }
        static void Main(string[] args)
        {
            sumaVectores s = new sumaVectores();
            s.IngresoDeDatos();
            s.sumaEntreVectores();

            Console.ReadKey();
        }
    }
}
