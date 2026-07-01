using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.*/

    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public void ingresarDatos()
        {
            Console.Write("Ingrese el nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            string linea = Console.ReadLine();
            Edad = int.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }

    class Empleado : Persona
    {
        private double sueldo;

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public void ingresarDatosEmpleado()
        {
            ingresarDatos();

            Console.Write("Ingrese el sueldo: ");
            string linea = Console.ReadLine();
            Sueldo = double.Parse(linea);
        }

        public void imprimirEmpleado()
        {
            imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" PERSONA ");

            Persona p = new Persona();
            p.ingresarDatos();
            p.imprimir();

            Console.WriteLine(" EMPLEADO ");

            Empleado e = new Empleado();
            e.ingresarDatosEmpleado();
            e.imprimirEmpleado();

            Console.ReadKey();
        }
    }
}

