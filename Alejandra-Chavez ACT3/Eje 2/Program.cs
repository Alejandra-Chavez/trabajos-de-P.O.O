using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje_2
{
    internal class Eje2
    {
        static void Main(string[] args)
        {
            //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero
            //con el segundo y a este resultado se lo multiplica por el tercero.

            int num1,num2,num3;
            int suma;
            int producto;

            Console.Write("Ingrese un numero: ");
            string linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese un numero: ");
           linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese un numero: ");
             linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 == num2 && num1 == num3)
            {
                suma = num1 + num2;
                Console.Write("El resultado de la suma de los primeros numeros da: ");
                Console.Write(suma);

                producto = suma * num3;

                Console.Write("El resultado de la suma multiplicado por el tercer numero da:");
                Console.Write(producto);


            }


        }
    }
}
