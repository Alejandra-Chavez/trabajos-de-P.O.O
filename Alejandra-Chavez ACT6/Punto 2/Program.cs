using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        { }
            /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/

            class Cuadrado
        {
            private int lado;
            private int superficie;
            private int perimetro;
            string linea;


            // Método para cargar el valor del lado
            public void CargarValor()
            {
                Console.Write("Ingrese el valor del lado: ");
                linea = Console.ReadLine();
                lado = int.Parse(linea);
            }

            public void ImprimirPerimetro()
            {
                perimetro = lado * 4;
                Console.WriteLine("El perímetro es: " + perimetro);
            }

            public void ImprimirSuperficie()
            {
                superficie = lado * lado;
                Console.WriteLine("La superficie es: " + superficie);
            }

            static void Main(string[] args)
            {
                Cuadrado c = new Cuadrado();
                c.CargarValor();
                c.ImprimirPerimetro();
                c.ImprimirSuperficie();
            }
        }
    }
    
}
