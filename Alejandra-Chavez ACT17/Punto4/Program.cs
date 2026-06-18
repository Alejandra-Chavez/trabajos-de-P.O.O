using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
herencia: Material, Herramienta y Martillo.
 La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
Plástico).
 La clase Herramienta (que hereda de Material) debe añadir el atributo
FuncionPrincipal.
 La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
(ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).
En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
en cadena de los constructores (desde la raíz hasta la clase derivada).*/
    class material
    {
        public string tipoMaterial;

        public material()
        {
            Console.Write("Ingrese el tipo de material: ");
            tipoMaterial = Console.ReadLine();

            Console.WriteLine("Constructor de la clase Material ejecutado");
        }
    }

    class herramienta : material
    {
        public string funcionPrincipal;

        public herramienta()
        {
            Console.Write("Ingrese la función principal de la herramienta: ");
            funcionPrincipal = Console.ReadLine();

            Console.WriteLine("Constructor de la clase Herramienta ejecutado");
        }
    }

    class martillo : herramienta
    {
        public float pesoGramos;

        public martillo()
        {
            Console.Write("Ingrese el peso en gramos: ");
            string linea = Console.ReadLine();
            pesoGramos = float.Parse(linea);

            Console.WriteLine("Constructor de la clase Martillo ejecutado");
        }

        public void mostrar()
        {
            Console.WriteLine("DATOS DEL MARTILLO");
            Console.WriteLine("Material: " + tipoMaterial);
            Console.WriteLine("Función: " + funcionPrincipal);
            Console.WriteLine("Peso: " + pesoGramos + " gramos");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            martillo M = new martillo();

            M.mostrar();

            Console.ReadKey();
        }
    }
}