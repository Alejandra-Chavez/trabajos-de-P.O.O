using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Plantear una clase Club y otra clase Socio.
La clase Socio debe tener los siguientes atributos privados: nombre y la
antigüedad en el club (en años). En el constructor pedir la carga del nombre y
su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
antigüedad en el club.*/
    using System;

    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese el nombre del socio: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la antigüedad en el club: ");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }

        public string RetornarNombre()
        {
            return nombre;
        }
    }

    class club
    {
        private Socio socio1;
        private Socio socio2;
        private Socio socio3;

        public club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void MayorAntiguedad()
        {
            Socio mayor = socio1;

            if (socio2.RetornarAntiguedad() > mayor.RetornarAntiguedad())
            {
                mayor = socio2;
            }

            if (socio3.RetornarAntiguedad() > mayor.RetornarAntiguedad())
            {
                mayor = socio3;
            }

            Console.WriteLine("El socio con mayor antigüedad es: " + mayor.RetornarNombre());
        }
        static void Main(string[] args)
        {
            club C = new club();

            C.MayorAntiguedad();

            Console.ReadKey();
        }
    }  
}
    