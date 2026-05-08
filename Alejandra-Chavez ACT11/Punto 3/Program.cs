using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class empleados
    {
        /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
empresa.
Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
irregular para cargar los días que han faltado cada empleado (cargar el número de día que
faltó)
Cada fila de la matriz representa los días de cada empleado.
a. Mostrar los empleados con la cantidad de inasistencias.
b. Cuál empleado faltó menos días.*/
        private string[] nombres;
        private int[][] faltas;
        string linea;

        public void cargar()
        {
            nombres = new string[3];
            faltas = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese nombre del empleado: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Cuantos dias falto: ");
                linea = Console.ReadLine();
                int cantidad = int.Parse(linea);

                faltas[i] = new int[cantidad];

                for (int j = 0; j < faltas[i].Length; j++)
                {
                    Console.Write("Ingrese dia que falto: ");
                    linea = Console.ReadLine();
                    faltas[i][j] = int.Parse(linea);
                }
            }
        }

        public void mostrarInasistencias()
        {
            Console.WriteLine("Cantidad de inasistencias:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(
                    nombres[i] + " falto " +
                    faltas[i].Length + " dias");
            }
        }

        public void menosFaltas()
        {
            int menor = faltas[0].Length;
            string empleado = nombres[0];

            for (int i = 1; i < 3; i++)
            {
                if (faltas[i].Length < menor)
                {
                    menor = faltas[i].Length;
                    empleado = nombres[i];
                }
            }

            Console.WriteLine("El empleado que falto menos dias es: " + empleado);
        }

        static void Main(string[] args)
        {
            empleados E = new empleados();

            E.cargar();
            E.mostrarInasistencias();
            E.menosFaltas();

            Console.ReadKey();
        }
    }
}