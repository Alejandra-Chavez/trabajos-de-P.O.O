using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    /*4. Armar tres clases: Animal, Mamífero y Perro.
La clase Animal debe tener un atributo especie.
La clase Mamífero, que hereda de Animal, debe tener un atributo
tipoAlimentacion.
La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
Cada clase debe tener un constructor que reciba los datos correspondientes
y los imprima indicando a qué clase pertenecen. Los datos deben ser
asignados previamente
Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
constructores.*/
    class Animal
    {
        public string especie;

        public Animal(string esp)
        {
            especie = esp;

            Console.WriteLine("Constructor de Animal");
            Console.WriteLine("Especie: " + especie);
        }
    }

    class Mamifero : Animal
    {
        public string tipoAlimentacion;

        public Mamifero(string esp, string alimentacion)
            : base(esp)
        {
            tipoAlimentacion = alimentacion;

            Console.WriteLine("Constructor de Mamífero");
            Console.WriteLine("Tipo de alimentación: " + tipoAlimentacion);
        }
    }

    class Perro : Mamifero
    {
        public string nombre;

        public Perro(string esp, string alimentacion, string nom)
            : base(esp, alimentacion)
        {
            nombre = nom;

            Console.WriteLine("Constructor de Perro");
            Console.WriteLine("Nombre: " + nombre);
        }

        static void Main(string[] args)
        {
            Perro p = new Perro("Canino", "Carnívoro", "Firulais");

            Console.ReadKey();
        }
    }
}
