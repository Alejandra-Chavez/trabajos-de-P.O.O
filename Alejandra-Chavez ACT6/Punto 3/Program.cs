using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Empleado
    {
        /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
sus datos y por último uno que imprima un mensaje si debe pagar impuestos
(si el sueldo supera a 3000).*/

            private int nombre;
            private int sueldo;
            string linea;
            public void CargarDatos()
            {
                Console.Write("Ingrese el nombre del empleado: ");
                linea = Console.ReadLine();
                nombre = int.Parse(linea);

                Console.Write("Ingrese el) sueldo: ");
                linea += Console.ReadLine();
                sueldo = int.Parse(linea);
            }

            public void ImprimirDatos()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Sueldo: " + sueldo);
            }

           
            public void PagaImpuestos()
            {
                if (sueldo > 3000) 
                {
                    Console.WriteLine("Debe pagar impuestos");
                }
                
            }

            static void Main(string[] args)
            {
                Empleado emp = new Empleado();
                emp.CargarDatos();
                emp.ImprimirDatos();
                emp.PagaImpuestos();

            Console.ReadKey();
            }
        }

    }
    
}
