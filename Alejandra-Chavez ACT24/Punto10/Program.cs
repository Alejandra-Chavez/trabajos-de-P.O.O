using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    /*10-
Un estacionamiento medido administra el ingreso y la salida de los vehículos que
utilizan su playa por orden de llegada.
 Crear la clase Ticket que contenga como atributos privados: patente
(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
constructor que reciba pat y hs.
 Crear la clase GestionEstacionamiento que administre una lista
dinámica de tickets (List).
 Métodos en GestionEstacionamiento:
o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
agregarlo al final de la lista utilizando .Add().
o ProcesarSalida(): Si la lista no está vacía, simular la salida del
primer vehículo de la lista (mostrar sus datos en consola) y
removerlo de la colección mediante .RemoveAt(0). Si está vacía,
advertir que no hay vehículos esperando salida.
o MostrarVehiculosEstacionados(): Listar todos los vehículos
alojados en la playa y la cantidad total de unidades presentes
utilizando la propiedad .Count.*/

    class ticket
    {
        private string patente;
        private int horasEstadia;

        public string Patente
        {
            get { return patente; }
        }

        public int HorasEstadia
        {
            get { return horasEstadia; }
        }

        public ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }

    internal class gestionEstacionamiento
    {
        List<ticket> tickets = new List<ticket>();

        public void registrarIngreso()
        {
            Console.Write("Ingrese la patente del vehículo: ");
            string pat = Console.ReadLine();

            Console.Write("Ingrese las horas de estadía: ");
            string linea = Console.ReadLine();
            int hs = int.Parse(linea);

            ticket nuevo = new ticket(pat, hs);

            tickets.Add(nuevo);
        }

        public void procesarSalida()
        {
            if (tickets.Count > 0)
            {
                ticket t = tickets[0];

                Console.WriteLine("Patente: " + t.Patente);
                Console.WriteLine("Horas de estadía: " + t.HorasEstadia);

                tickets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay vehículos esperando salida.");
            }
        }
        public void mostrarVehiculosEstacionados()
        {
            Console.WriteLine("Vehículos estacionados:");

            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine("Patente: " + tickets[i].Patente);
                Console.WriteLine("Horas de estadía: " + tickets[i].HorasEstadia);
            }

            Console.WriteLine("Cantidad de vehículos: " + tickets.Count);
        }

        static void Main(string[] args)
        {
            gestionEstacionamiento ge = new gestionEstacionamiento();

            ge.registrarIngreso();
            ge.mostrarVehiculosEstacionados();
            ge.procesarSalida();

            Console.ReadKey();
        }
    }
    }
