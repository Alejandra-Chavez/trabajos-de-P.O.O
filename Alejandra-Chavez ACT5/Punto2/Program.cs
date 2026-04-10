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
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
b) Cantidad de triángulos de cada tipo.
c) Tipo de triángulo que posee menor cantidad.*/

            int num;
            int equilateros = 0;
            int isosceles = 0;
            int escalenos = 0;
            int lado1, lado2, lado3;
            string linea;

            Console.Write("Ingrese la cantidad de triángulos: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Triángulo " + i);

                Console.Write("Lado 1: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.Write("Lado 2: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.Write("Lado 3: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2)
                {
                    if (lado1 == lado3)
                    {
                        Console.WriteLine("Equilátero");
                        equilateros++;
                    }
                    else
                    {
                        Console.WriteLine("Isósceles");
                        isosceles++;
                    }
                }
                else
                {
                    if (lado1 == lado3)
                    {
                        Console.WriteLine("Isósceles");
                        isosceles++;
                    }
                    else
                    {
                        if (lado2 == lado3)
                        {
                            Console.WriteLine("Isósceles");
                            isosceles++;
                        }
                        else
                        {
                            Console.WriteLine("Escaleno");
                            escalenos++;
                        }
                    }
                }
            }

            Console.WriteLine("Cantidad de equiláteros: " + equilateros);
            Console.WriteLine("Cantidad de isósceles: " + isosceles);
            Console.WriteLine("Cantidad de escalenos: " + escalenos);


            if (equilateros < escalenos)
            {
                Console.WriteLine("El tipo con menor cantidad es: Equilátero");
            }
            else if (isosceles < escalenos)
            {
                Console.WriteLine("El tipo con menor cantidad es: Isósceles");
            }
            else
            {
                Console.WriteLine("El tipo con menor cantidad es: Escaleno");
            }
        
            Console.ReadKey();
        }
    }
}
