using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT3
{
    internal class Eje1
    {
        static void Main(string[] args)
        {

            // 1. Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            int dia, mes;

            Console.Write("Ingrese el día: ");
            string linea = Console.ReadLine();
            dia = int.Parse(linea);

            Console.Write("Ingrese el numero de mes: ");
             linea = Console.ReadLine();
            mes= int.Parse(linea);

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("ES NAVIDAD 🎄");
            }
            


        }
    }
}
