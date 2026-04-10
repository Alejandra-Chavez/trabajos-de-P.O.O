using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Operaciones
    {
            /*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
calcular su suma, resta, multiplicación y división, cada una en un método,
imprimir dichos resultados.*/

            private int valor1;
            private int valor2;
            private int suma;
            private int resta;
            private int multiplicacion;
            private int division;
            string linea;
            public void CargarValores()
            {
                Console.Write("Ingrese el primer valor: "); 
                linea = Console.ReadLine();
                valor1 = int.Parse(linea);

                Console.Write("Ingrese el segundo valor: ");
                linea += Console.ReadLine();
                valor2 = int.Parse(linea);
            }

            
            public void Sumar()
            {
                suma = valor1 + valor2;
                Console.WriteLine("Suma: " + suma);
            }

            public void Restar()
            {
               resta = valor1 - valor2;
                Console.WriteLine("Resta: " + resta);
            }

            public void Multiplicar()
            {
                 multiplicacion = valor1 * valor2;
                Console.WriteLine("Multiplicación: " + multiplicacion);
            }

            public void Dividir()
            {
                
                    division = valor1 / valor2;
                Console.WriteLine("division: " + division);
            }

            static void Main(string[] args)
            {
                Operaciones op = new Operaciones();
                op.CargarValores();
                op.Sumar();
                op.Restar();
                op.Multiplicar();
                op.Dividir();

            Console.ReadKey();
            }
        }

    }
}
