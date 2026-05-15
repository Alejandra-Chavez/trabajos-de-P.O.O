using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class cine
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
        private int[][] salas;
        string linea;
        int cantidad

        public void inicio()
        {
            salas = new int[4][];
            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];

        }
        public void ventaEntradas()
        }
    
}
        public void vistaDeLasSalas()
        {

        }
        public void cantidadDeMenores()
        {

        }
        public void promedioEdad()
        {

        }
        static void Main(string[] args)
        {
            cine C = new cine();
            C.inicio();
            C.ventaEntradas();
            C.vistaDeLasSalas();
            C.cantidadDeMenores();
            C.promedioEdad();

            Console.ReadKey();
        }
    }
}
