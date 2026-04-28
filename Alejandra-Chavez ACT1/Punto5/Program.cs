using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula
            //multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
            int radio;
            double pi = 3.14;
            double circunferencia, area;
            string linea;

            Console.WriteLine("Ingresa un numero ese numero va a ser el radio de un circulo");
            linea = Console.ReadLine();
            radio = int.Parse(linea);

            circunferencia = 2 * pi * radio;
            area = pi * (radio * 2);
            Console.WriteLine("el area da en total:" + area);
            Console.WriteLine("la circunferencia da en total:" + circunferencia);
        }
    }
}
