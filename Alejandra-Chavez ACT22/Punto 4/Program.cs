using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    /*Actividad 4: Gestión de vuelos
Problema:

Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
 Usar la palabra clave this en el constructor para diferenciar los parámetros de
los atributos.
 Crear un método para calcular la duración del vuelo (TimeSpan).
 Cargar un vector con 4 vuelos y mostrar:
1. El código y duración del vuelo más largo.
2. El código del vuelo que salga más temprano.*/

    internal class vuelo
    {
        public int codigo;
        public DateTime horaSalida;
        public DateTime horaLlegada;

        public vuelo(int codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan DuracionVuelo()
        {
            return horaLlegada - horaSalida;
        }

        static void Main(string[] args)
        {
            vuelo[] vuelos = new vuelo[4];

            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.WriteLine("Vuelo " + (i + 1));

                Console.Write("Ingrese el código del vuelo: ");
                string linea = Console.ReadLine();
                int codigo = int.Parse(linea);

                Console.Write("Ingrese la hora de salida (HH:mm): ");
                DateTime horaSalida = DateTime.Parse(Console.ReadLine());

                Console.Write("Ingrese la hora de llegada (HH:mm): ");
                DateTime horaLlegada = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new vuelo(codigo, horaSalida, horaLlegada);
            }

            vuelo mayorDuracion = vuelos[0];

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].DuracionVuelo() > mayorDuracion.DuracionVuelo())
                {
                    mayorDuracion = vuelos[i];
                }
            }

            Console.WriteLine("Vuelo con mayor duración:"  +  mayorDuracion.codigo + "Dura: " + mayorDuracion.DuracionVuelo());

            vuelo masTemprano = vuelos[0];

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].horaSalida < masTemprano.horaSalida)
                {
                    masTemprano = vuelos[i];
                }
            }
            Console.WriteLine("Vuelo que sale más temprano:" + masTemprano.codigo + "Su hora de salida es a las: " + masTemprano.horaSalida.ToString("HH:mm"));

            Console.ReadKey();
        }
    }
}