using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class mejorPeorTiempo
    {
        /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
carrera de 100 metros. El programa debe cargar los datos en dos vectores
paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
promedio.*/

        private int[] tiempos;
        private string[] nombre;
        string linea;

        public void ingresoDeInformacion()
        {
            Console.WriteLine("Ingrese el nombre del atleta:");
            nombre = new string[5];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                linea = Console.ReadLine();
                nombre[i] = linea;
            }
            Console.WriteLine("Ingresa el tiempo que hizo en segundos:");
            tiempos = new int[5];
            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write("tiempo " + (i + 1) + " segundos" + ":");
                linea = Console.ReadLine();
                tiempos[i] = int.Parse(linea);
            }
        }
        public void mejorPeorTime()
        {

        }
        static void Main(string[] args)
        {
            mejorPeorTiempo T = new mejorPeorTiempo();
            T.ingresoDeInformacion();
            T.mejorPeorTime();
            Console.ReadKey();

        }
    }
}
