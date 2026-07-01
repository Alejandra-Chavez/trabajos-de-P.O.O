using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*Actividad 3: Estadísticas de visitas a zonas arqueológicas
Problema:
Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
arqueológicas durante 4 semanas.
Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
días. Luego:
 Calcular el total de visitas por zona y almacenarlo en un vector.
 Mostrar los datos en forma tabular.
 Agregar estos resultados a una lista llamada zonasVisitadas que contenga
nombres de zonas y total de visitas.
 Determinar cuál fue la zona más visitada.*/

    internal class Program
    {

        static void Main(string[] args)
        {

            string[] zonas = { "Zona 1", "Zona 2", "Zona 3" };

            int[,] visitas = new int[3, 4];

            int[] totales = new int[3];

            List<string> zonasVisitadas = new List<string>();

            Console.WriteLine("INGRESO DE VISITAS");

            // Cargar matriz
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingresando datos de " + zonas[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Semana " + (j + 1) + ": ");
                    visitas[i, j] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            Console.WriteLine("TABLA DE VISITAS");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(zonas[i]);

                int suma = 0;

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(visitas[i, j]);
                    suma += visitas[i, j];
                }

                totales[i] = suma;

                Console.WriteLine(" Total: " + suma);
            }

            for (int i = 0; i < 3; i++)
            {
                zonasVisitadas.Add(zonas[i] + " Total visitas: " + totales[i]);
            }

            Console.WriteLine("RESUMEN EN LISTA");

            foreach (string z in zonasVisitadas)
            {
                Console.WriteLine(z);
            }

            int max = totales[0];
            int pos = 0;

            for (int i = 1; i < 3; i++)
            {
                if (totales[i] > max)
                {
                    max = totales[i];
                    pos = i;
                }
            }

            Console.WriteLine("ZONA MÁS VISITADA:");
            Console.WriteLine(zonas[pos] + " con " + max + " visitas");

            Console.ReadKey();
        }
    }
}