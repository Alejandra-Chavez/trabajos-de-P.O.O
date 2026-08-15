using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto7
{
    /*7-
Un restaurante automatizado procesa la comanda de una mesa para controlar la
preparación y el cobro de los platos pedidos.
 Crear la clase Plato que contenga como atributos privados: nombrePlato
(string) y precio (double). Definir sus propiedades correspondientes y un
constructor que reciba nom y pre.
 Crear la clase GestionComandas que administre una lista de objetos List.
 Métodos en GestionComandas:
o AgregarPlato():Solicitar por teclado los datos de un plato y
agregarlo a la lista utilizando .Add().
o MostrarComanda(): Listar todos los platos agregados hasta el
momento junto a la cantidad total de ítems pedidos utilizando la
propiedad .Count.
o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
total a cobrar sumando los precios de la lista.
o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
se encuentra en la lista, removerlo mediante .Remove() para
actualizar la comanda.*/
    class plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            set {  nombrePlato = value;} get { return nombrePlato; }
        }
        public double Precio
        {
            set { precio = value; } get { return precio; }
        }

        public plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }
    }
    internal class gestionComandas
    {
        List<plato> platos = new List<plato>();
        public void agregarPlato()
        {
            string respuesta;

            do
            {
                Console.WriteLine("A continuación ingrese un platillo a elección");

                Console.Write("Nombre del plato: ");
                string nom = Console.ReadLine();

                Console.Write("Precio: ");
                string linea = Console.ReadLine();
                double pre = double.Parse(linea);

                plato nuevo = new plato(nom, pre);
                platos.Add(nuevo);

                Console.Write("¿Desea agregar otro plato? (si/no): ");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
        }
        public void mostrarComanda()
        {
            Console.WriteLine("Comanda: ");
            foreach (plato P in platos)
            {
                Console.WriteLine("Nombre plato: " + P.NombrePlato);
                Console.WriteLine("Precio: " + P.Precio);
            }

            Console.WriteLine("Cantidad total de platos: " + platos.Count);
        }
        public void calcularTotalMesa()
        {
            double total = 0;

            for (int i = 0; i < platos.Count; i++)
            {
                total = total + platos[i].Precio;
            }

            Console.WriteLine("Total: " + total);
        }
        public void cancelarPlato()
        {
            Console.Write("Ingrese el nombre del plato que desea cancelar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < platos.Count; i++)
            {
                if (platos[i].NombrePlato == nombre)
                {
                    platos.Remove(platos[i]);

                    Console.WriteLine("Plato cancelado correctamente.");

                }
            }
        }

        static void Main(string[] args)
        {
            gestionComandas gc = new gestionComandas();
            gc.agregarPlato();
            gc.mostrarComanda();
            gc.calcularTotalMesa();
            gc.cancelarPlato();

            Console.ReadKey();
        }
    }
}
