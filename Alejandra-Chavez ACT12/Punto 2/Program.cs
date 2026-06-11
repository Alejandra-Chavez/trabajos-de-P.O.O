using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
        /*2. Gestión de Complejo de Cine
Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
● Definir una matriz irregular de 4 filas para representar los asientos.
● Métodos:
1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
intervención del operador).
2. Crear un método de "Venta de Entradas" que permita cargar la edad del
espectador en un asiento específico (fila y columna).
3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
en cada asiento.
4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
5. Informar cuál es el promedio de edad de los espectadores de todo el
complejo.*/

class Cine
    {
        private int[][] salas;

        public void Inicializar()
        {
            salas = new int[4][];

            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];
        }

        public void VentaEntrada()
        {
            int sala, asiento, edad;

            Console.Write("Ingrese sala (1-4): ");
            string linea = Console.ReadLine();
            sala = int.Parse(linea);

            Console.Write("Ingrese asiento: ");
            linea = Console.ReadLine();
            asiento = int.Parse(linea);

            if (asiento < 1 || asiento > salas[sala - 1].Length)
            {
                Console.WriteLine("Asiento inválido");
                return;
            }

            Console.Write("Ingrese edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);

            salas[sala - 1][asiento - 1] = edad;
        }

        public void MostrarSalas()
        {
            for (int f = 0; f < salas.Length; f++)
            {
                Console.WriteLine("Sala " + (f + 1));

                for (int c = 0; c < salas[f].Length; c++)
                {
                    Console.Write(salas[f][c] + " ");
                }

                Console.WriteLine();
            }
        }

        public void MenoresPorSala()
        {
            for (int f = 0; f < salas.Length; f++)
            {
                int menores = 0;

                for (int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] > 0 && salas[f][c] < 18)
                    {
                        menores++;
                    }
                }

                Console.WriteLine("Sala " + (f + 1) +": " + menores + " menores");
            }
        }

        public void PromedioEdad()
        {
            int suma = 0;
            int cantidad = 0;

            for (int f = 0; f < salas.Length; f++)
            {
                for (int c = 0; c < salas[f].Length; c++)
                {
                    if (salas[f][c] > 0)
                    {
                        suma += salas[f][c];
                        cantidad++;
                    }
                }
            }

            if (cantidad > 0)
            {
                double promedio = (double)suma / cantidad;
                Console.WriteLine("Promedio de edad: " + promedio);
            }
        }

        static void Main(string[] args)
        {
            Cine cine = new Cine();

            cine.Inicializar();

            cine.VentaEntrada();
            cine.VentaEntrada();
            cine.VentaEntrada();

            cine.MostrarSalas();
            cine.MenoresPorSala();
            cine.PromedioEdad();

            Console.ReadKey();
        }
    
}
}
