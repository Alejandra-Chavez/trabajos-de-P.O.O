using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. El Sistema de Peaje.
Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
La clase Vehiculo debe tener los siguientes atributos privados:
Patente (de tipo string).
Tipo (puede ser "Auto", "Camion" o "Moto").
Tarifa (un valor decimal que representa el costo de su pase).
El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
La clase CabinaPeaje debe tener como atributos privados:
El número o identificador de la cabina.
Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
Un método que muestre la patente del vehículo que pagó la tarifa más cara.
*/
    class vehiculo
    {
        private string patente;
        private string tipoVehiculo;
        private double tarifa;

        public vehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo: ");
            patente = Console.ReadLine();
            Console.Write("Ingrese el que tipo de vehiculo es: ");
            tipoVehiculo = Console.ReadLine();
            Console.Write("Ingrese el monto de su tarifa: ");
            string linea = Console.ReadLine();
            tarifa = double.Parse(linea);
        }

        public string returnPatente()
        {
            return patente;
        }

        public string returnTipoVehiculo()
        {
            return tipoVehiculo;
        }

        public double returnTarifa()
        {
            return tarifa;
        }
    }

    internal class cabinaPeaje
    {
        private int numCabina;
        private vehiculo[] ultimosVehi;

        public cabinaPeaje()
        {
            Console.WriteLine("Ingrese el numero o identificador de la cabina: ");
            numCabina = int.Parse(Console.ReadLine());

            ultimosVehi = new vehiculo[3];
            Console.WriteLine("Carga de vehiculos por cabina: ");
            for (int i = 0; i < ultimosVehi.Length; i++)
            {
                Console.WriteLine("Vehiculo" + (i + 1)); 
                ultimosVehi[i] = new vehiculo();
            }
        } 

        public void imprimir()
        {
            Console.WriteLine("Datos de la cabina N° " + numCabina +);
            for (int i = 0; i < ultimosVehi.Length; i++)
            {
                
                Console.WriteLine("Patente del vehiculo: " + ultimosVehi[i].returnPatente() + " Tipo de vehiculo: " + ultimosVehi[i].returnTipoVehiculo());
            }
        }

        public void totalRecaudado()
        {
            double suma = 0;
            for (int i = 0; i < ultimosVehi.Length; i++)
            {
                suma = suma + ultimosVehi[i].returnTarifa();
            }
            Console.WriteLine("En total se recaudo: " + suma);
        }

        public void tarifaMasAlta()
        {
            int mayor = 0;
            for (int i = 1; i < ultimosVehi.Length; i++)
            {
                if (ultimosVehi[i].returnTarifa() > ultimosVehi[mayor].returnTarifa())
                {
                    mayor = i;
                }
            }
            Console.WriteLine("El vehiculo con la patente: " + ultimosVehi[mayor].returnPatente() + " fue el que mas pago con un total de: " + ultimosVehi[mayor].returnTarifa());
        }

        static void Main(string[] args)
        {
            cabinaPeaje C = new cabinaPeaje();
            C.imprimir();
            C.totalRecaudado();
            C.tarifaMasAlta();

            Console.ReadKey();
        }
    }
}
