using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Evaluacion
    {
        /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
sus nombres y puntajes promedio obtenidos (de 1 a 10).
Cargar sus datos en vectores paralelos, mostrar docente con calificación más
alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
desaprobaron (tomando como base que se aprueba con una nota mayor o igual
a 6)*/
        private string[] docentes;
        private int[] nota;
        string linea;
        public void cargaDatos()
        {
            Console.WriteLine("Ingrese el nombre del profesor");
            docentes = new string[6];
            for (int i = 0; i < docentes.Length; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                linea = Console.ReadLine();
                docentes[i] = linea;
            }

            Console.WriteLine("Ingrese la calificacion de cada profe:");
            nota = new int[6];
            for (int i = 0; i < nota.Length; i++)
            {
                Console.Write("Notas " + (i + 1) + ": ");
                linea = Console.ReadLine();
                nota[i] = int.Parse(linea);
            }
        }
        public void ordenarMayorMenor()
        {
            int aux;
            string auxdocente;

            for (int i = 0; i < nota.Length - 1; i++)
            {
                for (int c = 0; c < nota.Length - 1; c++)
                {
                    if (nota[c] < nota[c + 1])
                    {
                        // Intercambio notas
                        aux = nota[c];
                        nota[c] = nota[c + 1];
                        nota[c + 1] = aux;

                        // Intercambio docentes
                        auxdocente = docentes[c];
                        docentes[c] = docentes[c + 1];
                        docentes[c + 1] = auxdocente; // ✔ corregido
                    }
                }
            }

            Console.WriteLine("Orden de mayor a menor:");
            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine(docentes[i] + " - " + nota[i]);
            }
        }

        public void aprobadoDesaprobado()
        {
            int aprobado = 0;      
            int desaprobado = 0;  

            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] >= 6) 
                {
                    aprobado++;
                }
                else
                {
                    desaprobado++;
                }
            }

            Console.WriteLine("Aprobaron " + aprobado + " profesores");
            Console.WriteLine("Desaprobaron " + desaprobado + " profesores");
        }
        static void Main(string[] args)
        {
            Evaluacion E = new Evaluacion();
            E.cargaDatos();
            E.ordenarMayorMenor();
            E.aprobadoDesaprobado();
        }
    }
}
