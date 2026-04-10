using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Partidas
    {

        /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
un videojuego. El programa debe:
.Mostrar la puntuación más alta y la más baja.
.Calcular el promedio de puntuación.
.Contar cuántas veces superó los 500 puntos.*/

        private int[] puntuacion;
        string linea;
        public void IngresoDePuntuacion()
        {
            puntuacion = new int[6];
            Console.Write("Ingresa tu puntuacion de las seis partidas");
        }
        public void mayorMenor()
        {
            int mayor = 0;
            int menor;
            menor = 10000000;

            for (int i = 0; i < 6; i++)
            {
                if( puntuacion[i] > mayor)
                {
                    mayor = puntuacion[i];
                }
                else if (puntuacion[i] < menor)
                {
                    menor = puntuacion[i];
                }
            }
            Console.WriteLine("La puntuacion mas alta es de" + mayor + "puntos");
            Console.WriteLine("La puntuacion mas baja es de" + menor + "puntos");
        }
        public void promdioDePuntuacion()
        {
            int suma;
            int promedio;
            suma = 0;

            for (int i = 0; i < 6; i++)
            {
                suma = suma + puntuacion[i];
            }
            promedio = suma / 6;
            Console.WriteLine("El promedio de la puntuacion es de" + promedio);
            }
        public void puntuacionMayor500()
        {
            int max = 0;
            for (int i = 0; i < 6; i++)
            {
              if(puntuacion[i] > 500)
                {
                    max++;
                }
            }
            Console.WriteLine("Se supero los 500 puntos uns cantidad de " + max + "veces");
        }
        static void Main(string[] args)
        {
            Partidas P = new Partidas();
            P.IngresoDePuntuacion();
            P.mayorMenor();
            P.promdioDePuntuacion();
            P.puntuacionMayor500();

            Console.ReadKey();
        }
    }
}
