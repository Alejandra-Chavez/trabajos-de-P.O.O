using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Operaciones
    {
        /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
constructor, calcular su suma, resta, multiplicación y división, cada una en un
método, imprimir dichos resultados.*/
        private int valor1;
        private int valor2;
        public Operaciones()
        {
            string linea;
            Console.Write("ingresa un numero: ");
            linea = Console.ReadLine();
            valor1= int.Parse(linea);
            Console.Write("Ingresa otro numero: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }
        public void suma()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("Suma:" + suma);
        }
        public void resta()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("Resta:" + resta);
        }
        public void multiplicacion()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("Multiplicacion:" + multiplicacion);
        }
        public void division()
        {
            int division = valor1 / valor2;
            Console.WriteLine("Division: " + division);
        }
        static void Main(string[] args)
        {
            Operaciones O = new Operaciones();
            O.suma();
            O.resta();
            O.multiplicacion();
            O.division();

            Console.ReadKey();
        }
    }
}
