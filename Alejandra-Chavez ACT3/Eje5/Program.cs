using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores
            //enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho
            //punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 
            int x, y;


            Console.Write("Ingrese el valor de x: ");
            string linea = Console.ReadLine();
             x = int.Parse(linea);

            Console.Write("Ingrese el valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Está en el 1º cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Está en el 2º cuadrante");
            }
        }
    }
}
