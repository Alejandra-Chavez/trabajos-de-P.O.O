using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class recetarioDinamico
    {
        /*3. Academia de Gastronomía: Recetario Dinámico
Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
● Definir un vector para los nombres de los alumnos.
● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
presentado.
● Métodos:
1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
de cada alumno.
2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado"
(promedio >= 70) o "Reprobado".
5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
valor máximo de la matriz).*/

        private string [] alumno;
        private int [][] puntaje;
        int cantidad;
        string linea;

        public void cargaDatos()
        {
            alumno = new string[3];
            puntaje = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingresa el nombre del " + (i + 1) + "° estudiante: ");
                alumno[i] = Console.ReadLine();

                Console.Write(" Cuantos platos presento dicho estudiante?: ");
                linea = Console.ReadLine();
                cantidad = int.Parse(linea);

                puntaje[i] = new int[cantidad];

                for (int j = 0; j < cantidad; j++)
                {
                    do
                    {
                        Console.Write("Ingresa el puntaje del"+(j +1) +"° plato: ");
                        linea = Console.ReadLine();
                        puntaje[i][j] = int.Parse(linea);

                        if (puntaje[i][j] > 100 || puntaje[i][j] < 0)
                        {
                            Console.WriteLine("El puntaje debe estar entre 0 y 100");
                        }

                    } while (puntaje[i][j] > 100 || puntaje[i][j] < 0);
                }

                Console.WriteLine();
            }
        }
        public void imprimirInformacion()
        {
            Console.WriteLine("Listado de alumnos:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno: " + alumno[i]);

                for (int j = 0; j < puntaje[i].Length; j++)
                {
                    Console.WriteLine("Plato " + (j + 1) + ":"+ "Tiene de puntuacion de " + puntaje[i][j] + " puntos" );
                }

                Console.WriteLine();
            }
        }
        public void puntajePromedio()
        {
            int suma;
            int promedio;

            Console.WriteLine("Promedio de cada alumno");

            for (int i = 0; i < 3; i++)
            {
                suma = 0;

                for (int j = 0; j < puntaje[i].Length; j++)
                {
                    suma += puntaje[i][j];
                }
                promedio = suma / puntaje[i].Length;
                Console.WriteLine("Alumno :" + alumno[i] + " Tiene un promedio de " + promedio);

                if (promedio >= 70)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            Console.WriteLine();

        }
        public void mejorPuntaje()
        {
            int mayor = puntaje[0][0];
            string mejorAlumno = alumno[0];

            for (int i = 0; i < alumno.Length; i++)
            {
                for (int j = 0; j < puntaje[i].Length; j++)
                {
                    if (puntaje[i][j] > mayor)
                    {
                        mayor = puntaje[i][j];
                        mejorAlumno= alumno[i];
                    }
                }
            }
            Console.WriteLine("El puntaje más alto fue: " + mayor);
            Console.WriteLine("Alumno destacado: " + mejorAlumno);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            recetarioDinamico R = new recetarioDinamico();
            R.cargaDatos();
            R.imprimirInformacion();
            R.puntajePromedio();
            R.mejorPuntaje();

            Console.ReadKey();
        }
    }
}
