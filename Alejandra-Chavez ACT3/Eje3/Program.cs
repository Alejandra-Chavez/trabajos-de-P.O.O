using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje3
{
    internal class Eje3
    {
        static void Main(string[] args)
        {

            // 3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"
            int num1, num2, num3;

            Console.Write("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("todos los numeros son menores a 10");
            }
        }
    }
}
