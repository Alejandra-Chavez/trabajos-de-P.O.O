using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Competencia de Atletismo
Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
Definir los siguientes métodos en la clase Carrera:
Un constructor que cargue los datos de los 3 atletas de la carrera.
Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
Un método que calcule e imprima el tiempo promedio de la carrera.
Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
Un método que muestre a los atletas que superaron el promedio.
*/
    using System;

    class atleta
    {
        private string nombre;
        private double tiempo;

        public atleta()
        {
            Console.Write("Ingrese el nombre del atleta: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el tiempo en segundos: ");
            string linea = Console.ReadLine();
            tiempo = double.Parse(linea);
        }
        public string retornarNombre()
        {
            return nombre;
        }

        public double retornarTiempo()
        {
            return tiempo;
        }
        public void Imprimir()
        {
            Console.WriteLine(nombre + " - " + tiempo + " segundos");
        }
    }

    class carrera
    {
        private atleta[] atletas;

        public Carrera()
        {
            atletas = new Atleta[3];

            for (int i = 0; i < atletas.Length; i++)
            {
                Console.WriteLine("Atleta " + (i + 1));
                atletas[i] = new atleta();
            }
        }
        public void imprimirAtletas()
        {
            Console.WriteLine("Listado de atletas:");
            for (int i = 0; i < atletas.Length; i++)
            {
                atletas[i].Imprimir();
            }
        }
        public void tiempoPromedio()
        {
            double suma ;
            double promedio;

            for (int i = 0; i < atletas.Length; i++)
            {
               suma = suma + atletas[i].retornarTiempo();
            }

            promedio = suma / atletas.Length;

            Console.WriteLine("Tiempo promedio: " + promedio + " segundos");
        }
        public double calcularPromedio()
        {
            double suma ;

            for (int i = 0; i < atletas.Length; i++)
            {
                suma = suma + atletas[i].retornarTiempo();
            }

            return suma / atletas.Length;
        }
        public void ganador()
        {
            double menorTiempo = atletas[0].retornarTiempo();
            string ganador = atletas[0].retornarNombre();

            for (int i = 1; i < atletas.Length; i++)
            {
                if (atletas[i].retornarTiempo() < menorTiempo)
                {
                    menorTiempo = atletas[i].retornarTiempo();
                    ganador = atletas[i].retornarNombre();
                }
            }

            Console.WriteLine("Ganador de la carrera: " + ganador);
        }
        public void superaronPromedio()
        {
            double promedio = calcularPromedio();

            Console.WriteLine("Atletas que superaron el promedio:");

            for (int i = 0; i < atletas.Length; i++)
            {
                if (atletas[i].retornarTiempo() > promedio)
                {
                    Console.WriteLine(atletas[i].retornarNombre());
                }
            }
        }
        static void Main(string[] args)
        {
            carrera C = new Carrera();

            C.imprimirAtletas();
            C.tiempoPromedio();
            C.ganador();
            C.superaronPromedio();

            Console.ReadKey();
        }
    }
}
