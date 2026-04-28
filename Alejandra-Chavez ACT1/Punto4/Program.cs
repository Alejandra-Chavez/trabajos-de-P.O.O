using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y
            //la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

            int precio, cantidad;
            int total;
            string linea;
            Console.WriteLine("Ingresa el precio del producto seleccionado");
            linea= Console.ReadLine();
            precio= int.Parse(linea);

            Console.WriteLine("Ingresa cuanto te estas llevando de un mismo producto");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            total = precio * cantidad;
            Console.WriteLine("El toal a abonar es de" + total);
        }
    }
}
