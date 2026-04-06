using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"*/

            int n1, n2, n3, n4, n5, n6;

            Console.Write("Ingrese nota 1: ");
            string linea = Console.ReadLine();
            n1 = int.Parse(linea);

            Console.Write("Ingrese nota 2: ");
            linea = Console.ReadLine();
            n2 = int.Parse(linea);

            Console.Write("Ingrese nota 3: ");
            linea = Console.ReadLine();
            n3 = int.Parse(linea);

            Console.Write("Ingrese nota 4: ");
            linea = Console.ReadLine();
            n4 = int.Parse(linea);

            Console.Write("Ingrese nota 5: ");
            linea = Console.ReadLine();
            n5 = int.Parse(linea);

            Console.Write("Ingrese nota 6: ");
            linea = Console.ReadLine();
            n6 = int.Parse(linea);

            int promedio = (n1 + n2 + n3 + n4 + n5 + n6) / 6;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
        }
    }
}


