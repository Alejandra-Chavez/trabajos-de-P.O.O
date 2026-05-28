using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class empleado
    {
        /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. En el constructor cargar los atributos y luego en otro
método imprimir sus datos y por último uno que imprima un mensaje si debe
pagar impuestos (si el sueldo supera a 3000)*/

        private string nombre;
        private int sueldo;

        public empleado()
        {
            string linea;
            Console.Write("Ingresa el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void imprimir()
        {
            Console.WriteLine("Nombre empleado:" + nombre);
            Console.WriteLine("Sueldo:" + sueldo);
        }
        public void pagaImpuestos()
        {
            if (sueldo >= 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            empleado E = new empleado();
            E.imprimir();
            E.pagaImpuestos();

            Console.ReadKey();
        }
    }
}
