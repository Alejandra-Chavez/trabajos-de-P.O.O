using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*5-
Un taller mecánico automatizado administra la recepción y egreso de automóviles
que se encuentran en el sector de reparaciones.
 Crear la clase Vehiculo que contenga como atributos privados: patente
(string) y costoReparacion (double). Definir sus propiedades
correspondientes y un constructor que reciba pat y costo.
 Crear la clase GestionTaller que administre una lista de objetos List.
 Métodos en GestionTaller:
o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
reparación de un vehículo para agregarlo a la lista mediante .Add().
o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
recorriendo la lista, informar si el vehículo está en el taller y mostrar
su costo asociado.
o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
vehículo en la lista y, si existe, removerlo de la colección mediante
.Remove() confirmando la entrega del automóvil.

o CalcularRecaudacionPendiente(): Listar los vehículos
actualmente en reparación, la cantidad total de unidades alojadas en
el taller mediante la propiedad .Count y la suma total acumulada por
cobrar.*/
    class vehiculo
    {
        private string patente;
        private double costoReparacion;

        public string Patente
        {
            set { patente = value; } 
            get { return patente; }
        }
        public double CostoReparacion
        {
            set { costoReparacion = value; }
            get { return costoReparacion; }
        }

        public vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo; 
        }
    }

    internal class gestionTaller
    {
        private List<vehiculo> listaVehiculos = new List<vehiculo>();
        public void ingresarVehiculo()
        {
            Console.WriteLine("Ingrese la patente del vehiculo");
            string patente = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de reparacion del vehiculo");
            string linea = Console.ReadLine();
            double costoReparacion = double.Parse(linea);
            vehiculo nuevo = new vehiculo(patente, costoReparacion);

            listaVehiculos.Add(nuevo);
        }
        public void buscarVehiculo()
        {
            Console.Write("Ingrese la patente a buscar: ");
            string patente = Console.ReadLine();

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos[i].Patente == patente)
                {
                    Console.WriteLine("Vehículo encontrado.");
                    Console.WriteLine("Patente: " + listaVehiculos[i].Patente);
                    Console.WriteLine("Costo: " + listaVehiculos[i].CostoReparacion);
                }
            }
        }
        public void entregarVehiculo()
        {
            Console.Write("Ingrese la patente del vehículo a entregar: ");
            string patente = Console.ReadLine();

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos[i].Patente == patente)
                {
                    vehiculo patenteEncontrada = listaVehiculos[i];

                    listaVehiculos.Remove(patenteEncontrada);

                    Console.WriteLine("Vehículo entregado.");

                    return;
                }
            }

            Console.WriteLine("El vehículo que busca no se encuentra.");
        }
        public void calcularRecaudacionPendiente() 
        {
            double total = 0;

            Console.WriteLine("Vehículos en reparacion:");

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                Console.WriteLine("Patente: " + listaVehiculos[i].Patente);
                Console.WriteLine("Costo de reparación: " + listaVehiculos[i].CostoReparacion);

                total += listaVehiculos[i].CostoReparacion;
            }

            Console.WriteLine("Cantidad de vehículos: " + listaVehiculos.Count);
            Console.WriteLine("Total pendiente de cobro: " + total);
        }

        static void Main(string[] args)
        {
            gestionTaller gt = new gestionTaller();

            gt.ingresarVehiculo();
            gt.buscarVehiculo();
            gt.entregarVehiculo();
            gt.calcularRecaudacionPendiente();

            Console.ReadKey();
        }
    }
}
