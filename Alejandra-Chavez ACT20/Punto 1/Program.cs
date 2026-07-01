using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*Actividad 1: Sistema de control de vuelos
Problema:
Una aerolínea administra los vuelos programados mediante un sistema orientado a
objetos.
Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
destino y duración en horas. Luego definir una clase derivada VueloInternacional que
herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
desde consola y luego:
 Mostrar los vuelos registrados y el país de destino.
 Informar cuál es el vuelo con mayor duración.
 Mostrar el orden de ejecución de los constructores.*/

    class vuelo
    {
        int numVuelo;
        string destino;
        float duracionVuelo;

        public vuelo(int nVuelo, string dest, float duracion)
        {
            Console.WriteLine("Se ejecutó el constructor de Vuelo");

            numVuelo = nVuelo;
            destino = dest;
            duracionVuelo = duracion;
        }

        public int NumVuelo
        {
            get { return numVuelo; }
        }

        public string Destino
        {
            get { return destino; }
        }

        public float DuracionVuelo
        {
            get { return duracionVuelo; }
        }
    }

    class VueloInternacional : vuelo
    {
        string paisDestino;

        public VueloInternacional(int nVuelo, string dest, float duracion, string pais)
        {
            Console.WriteLine("Se ejecutó el constructor de Vuelo Internacional");

            paisDestino = pais;
        }

        public string PaisDestino
        {
            get { return paisDestino; }
        }

        static void Main(string[] args)
        {
            List<VueloInternacional> listaVuelos = new List<VueloInternacional>();

            Console.WriteLine("Registro vuelos: ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vuelo N° " + (i + 1));

                Console.Write("Ingrese el número de vuelo: ");
                int numVuelo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el destino: ");
                string destino = Console.ReadLine();

                Console.Write("Ingrese la duración del vuelo: ");
                float duracion = float.Parse(Console.ReadLine());

                Console.Write("Ingrese el país destino: ");
                string pais = Console.ReadLine();

                VueloInternacional nuevoVuelo = new VueloInternacional(numVuelo, destino, duracion, pais);

                listaVuelos.Add(nuevoVuelo);

                Console.WriteLine("Vuelo registrado correctamente.");
            }

            Console.WriteLine("LISTA DE VUELOS");

            foreach (VueloInternacional v in listaVuelos)
            {
                Console.WriteLine("Número de vuelo: " + v.NumVuelo);
                Console.WriteLine("Destino: " + v.Destino);
                Console.WriteLine("Duración: " + v.DuracionVuelo);
                Console.WriteLine("País destino: " + v.PaisDestino);
                Console.WriteLine();
            }

            VueloInternacional mayor = listaVuelos[0];

            foreach (VueloInternacional v in listaVuelos)
            {
                if (v.DuracionVuelo > mayor.DuracionVuelo)
                {
                    mayor = v;
                }
            }

            Console.WriteLine("Vuelo con mayor duración:");
            Console.WriteLine("Número de vuelo: " + mayor.NumVuelo);
            Console.WriteLine("Destino: " + mayor.Destino);
            Console.WriteLine("Duración: " + mayor.DuracionVuelo);
            Console.WriteLine("País destino: " + mayor.PaisDestino);

            Console.ReadKey();
        }
    }
}

