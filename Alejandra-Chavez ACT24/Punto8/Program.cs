using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    /*8-
Una farmacia controla el nivel de stock de sus medicamentos para evitar el
desabastecimiento de insumos esenciales.
 Crear la clase Medicamento que contenga los atributos privados: nombre
(string) y stock (int). Definir sus propiedades correspondientes. Su
constructor debe recibir nom y stk.
 Crear la clase ControlFarmacia que administre una lista de objetos List.
 Métodos en ControlFarmacia:
o Un constructor que cargue por teclado una lista inicial de 4
medicamentos ingresando sus nombres y stock.
o ListarStock(): Mostrar la lista de medicamentos en pantalla.

o RemoverAgotados(): Recorrer la lista y remover por completo de
la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
o MostrarMedicamentosDisponibles(): Imprimir la lista
actualizada y la cantidad de productos disponibles en el inventario
utilizando la propiedad .Count.*/

    class medicamento
    {
        private string nombre;
        private int stock;

        public string Nombre
        {
            set { nombre = value; }get { return nombre; }
        }
        public int Stock
        {
            set { stock = value; } get { return stock; }
        }
        public medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }
    }
    internal class controlFarmacia
    {
        List<medicamento> medicamentos = new List<medicamento>();
        public controlFarmacia()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Medicamnto°" + (i + 1) + ":");

                Console.Write("Ingresar el nombre del medicamento: ");
                string nom = Console.ReadLine();

                Console.Write("Ingresar la cantidad que queda en stock: ");
                string linea = Console.ReadLine();
                int stk = int.Parse(linea);

                medicamento nuevo = new medicamento(nom, stk);

                medicamentos.Add(nuevo);
            }
        }
        public void listarStock()
        {
            Console.WriteLine("Lista de medicamentos");
            foreach (medicamento M in medicamentos)
            {
                Console.WriteLine("Nombre del medicamento: " + M.Nombre);
                Console.WriteLine("Cantidad en stock: " + M.Stock);
            }
        }
        public void removerAgotados()
        {
            for (int i = medicamentos.Count -1; i >= 0; i--)
            {
                if (medicamentos[i].Stock == 0)
                {
                    medicamentos.Remove(i);
                }
            }
        }
        public void MmstrarMedicamentosDisponibles()
        {
            Console.WriteLine("Medicamntos disponibles: ");
            foreach (medicamento M in medicamentos)
            {
                Console.WriteLine("Nombre del medicamento: " + M.Nombre);
                Console.WriteLine("Cantidad en stock: " + M.Stock);
            }
        }
        static void Main(string[] args)
        {
            controlFarmacia cf = new controlFarmacia();

            cf.listarStock();
            cf.removerAgotados();
            cf.MmstrarMedicamentosDisponibles();

            Console.ReadKey();
        }
    }
}
