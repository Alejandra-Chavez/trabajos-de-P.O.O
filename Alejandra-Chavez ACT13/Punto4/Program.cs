using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
alumno y sus 4 calificaciones.
Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
Alumno.
Agregar los siguientes métodos:
a) Un método que imprima el nombre de cada alumno y su promedio.
b) Un método que muestre el nombre del alumno con el promedio más
alto.
c) Un método que indique qué alumnos tienen al menos una nota
desaprobada (nota menor a 6)*/

    class Alumno
    {
        private string nombre;
        private int[] notas;

        public Alumno()
        {
            notas = new int[4];
            Console.Write("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingrese la " + (i + 1) + "° nota del alumno:  " );
                string linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }
        public string retornarNombre()
        {
            return nombre;
        }
        public int retornarPromedio()
        {
            int suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            int promedio = (suma / 4);

            return promedio;
        }

        public int[] retornarNotas()
        {
            return notas;
        }

    }
    class Curso
    {
        private Alumno[] alumno;

        public Curso()
        {
            alumno = new Alumno[3];
            for (int i = 0; i < alumno.Length; i++)
            {
                alumno[i] = new Alumno();
            }
        }
        public void imprimir()
        {

            for (int i = 0; i < alumno.Length; i++)
            {
                Console.WriteLine("Nombre: " + alumno[i].retornarNombre() + " Promedio: " + alumno[i].retornarPromedio());
            } 
    }
        public void promedioAlto()
        {
           int mayor = alumno[0].retornarPromedio();
            string nombre = alumno[0].retornarNombre();

            for (int i = 0; i < alumno.Length; i++)
            {
                if (mayor < alumno[i].retornarPromedio())
                {
                    mayor = alumno[i].retornarPromedio();
                    nombre = alumno[i].retornarNombre();
                }
            }

            Console.WriteLine("El alumno con el mejor promedio es: " + nombre + " con un promedio de: " + mayor);

        }
        public void notaDesaprobada()
        {
            for (int i = 0; i < alumno.Length; i++)
            {

                int [] notas = alumno[i].retornarNotas();

                for (int j = 0; j < notas.Length; j++)
                {
                    if (notas[j] >= 6)
                    {
                        Console.WriteLine("El alumno " + alumno[i].retornarNombre() + " esta APROBADO");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El alumno " + alumno[i].retornarNombre() + " esta DESAPROBADO");
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Curso c = new Curso();
            c.imprimir();
            c.promedioAlto();
            c.notaDesaprobada();

            Console.ReadKey();
        }
    }
}
