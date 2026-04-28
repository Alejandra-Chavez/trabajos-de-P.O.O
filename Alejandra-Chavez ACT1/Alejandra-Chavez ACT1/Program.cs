using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
            //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            int lado;
            int perimetro;
                string linea;
            Console.WriteLine("Ingresa el lado de un cuadro");
            linea= Console.ReadLine();
            lado = int.Parse(linea);

            perimetro = lado * 4;
            Console.Write("El perimetro es de" + perimetro);

            Console.ReadKey();
        }
    }
}
