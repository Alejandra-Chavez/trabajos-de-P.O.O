using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Control de Vuelos
Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada
uno de los 4 pasajeros.
Agregar los siguientes métodos en la clase Vuelo:
Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
*/
    class pasajero
    {
        private string nombre;
        private int DNI;
        private float pesoEquipaje;

        public pasajero()
        {
            Console.Write("Ingresa el nombre del pasajero: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa el DNI del pasajero: ");
            string linea = Console.ReadLine();
            DNI = int.Parse(linea);
            Console.Write("Por ultimo, por favor ingrese el peso de su equipaje: ");
            linea = Console.ReadLine();
            pesoEquipaje = float.Parse(linea);
        }
        public string returnNombre()
        {
            return nombre;
        }
        public int returnDNI()
        {
            return DNI;
        }
        public float returnPesoEquipaje()
        {
            return pesoEquipaje;
        }
    }
       class vuelo
    {
        private pasajero[] pasajeros;
        public vuelo()
        {
            pasajeros = new pasajero[4];
            Console.WriteLine("Complete la informacion de cada pasajero: ");
            for (int i = 0; i < pasajeros.Length; i++)
            {
                Console.WriteLine("Pasajero" + (i + 1));
            pasajeros[i] = new pasajero();

        }
        }
        public void imprimir()
        {
            Console.WriteLine("Listado de los pasajeros: ");
            for (int i = 0; i < pasajeros.Length; i++)
            {

                Console.WriteLine("Nombre: " + pasajeros[i].returnNombre());
                Console.WriteLine(" DNI: " + pasajeros[i].returnDNI());
                Console.WriteLine("Peso del Equipaje: " + pasajeros[i].returnPesoEquipaje());
                Console.WriteLine("-----------------------------------");
            }
        }
        public void pesoTotal()
        {
            float suma = 0;
            for(int i = 0; i < pasajeros.Length; i++)
            {
                suma = suma + pasajeros[i].returnPesoEquipaje();
            }
            Console.WriteLine("El peso total del de equipajes en el avion es de " + suma + "Kg");
        }
        public void limitePeso()
        {
            for (int i = 0; i < pasajeros.Length; i++)
            {
                if (pasajeros[i].returnPesoEquipaje() > 23)
                {
                    Console.WriteLine("El pasajer@ " + pasajeros[i].returnNombre() + "con el DNI " + pasajeros[i].returnDNI() +"excede con el limite de peso");
                }
            }
        }
        static void Main(string[] args)
        {
            vuelo V = new vuelo();
            V.imprimir();
            V.pesoTotal();
            V.limitePeso();

            Console.ReadKey();
        }
    }
}
