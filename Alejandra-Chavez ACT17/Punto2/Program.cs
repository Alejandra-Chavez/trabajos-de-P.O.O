using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Catálogo de Películas (Encapsulación, Validación y Composición)
Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del
catálogo.*/

    class Pelicula
    {
        private string titulo;
        private float duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            get 
            {
                return titulo; 
            }
            set 
            {
                titulo = value;
            }
        }

        public float DuracionMinutos
        {
            get 
            { 
                return duracionMinutos;
            }
            set
            {
                if (value > 0)
                    duracionMinutos = value;
            }
        }

        public int Calificacion
        {
            get 
            { 
                return calificacion; 
            }
            set
            {
                if (value >= 1 && value <= 5)
                    calificacion = value;
                else
                    calificacion = 1;
            }
        }

        public void IngresarDatos()
        {
            Console.Write("Ingrese el título de la película: ");
            Titulo = Console.ReadLine();

            Console.Write("Ingrese la duración en minutos: ");
            string lineaa = Console.ReadLine();
            DuracionMinutos = float.Parse(lineaa);

            Console.Write("Ingrese la calificación (1 a 5): ");
            lineaa = Console.ReadLine();
            Calificacion = int.Parse(lineaa);
        }

        public void Mostrar()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Duración: " + DuracionMinutos + " minutos");
            Console.WriteLine("Calificación: " + Calificacion);
        }
    }

    class Catalogo
    {
        private Pelicula[] peliculas;

        public Catalogo()
        {
            peliculas = new Pelicula[3];

            for (int i = 0; i < peliculas.Length; i++)
            {
                peliculas[i] = new Pelicula();

                Console.WriteLine("Película " + (i + 1));
                peliculas[i].IngresarDatos();
            }
        }

        public void MostrarCatalogo()
        {
            for (int i = 0; i < peliculas.Length - 1; i++)
            {
                for (int j = i + 1; j < peliculas.Length; j++)
                {
                    if (peliculas[i].DuracionMinutos < peliculas[j].DuracionMinutos)
                    {
                        Pelicula aux = peliculas[i];
                        peliculas[i] = peliculas[j];
                        peliculas[j] = aux;
                    }
                }
            }

            Console.WriteLine("PELÍCULAS ORDENADAS POR DURACIÓN");
           
            for (int i = 0; i < peliculas.Length; i++)
            {
                peliculas[i].Mostrar();
            }

            Pelicula mejorCalificada = peliculas[0];

            for (int i = 1; i < peliculas.Length; i++)
            {
                if (peliculas[i].Calificacion > mejorCalificada.Calificacion)
                {
                    mejorCalificada = peliculas[i];
                }
            }

            Pelicula masCorta = peliculas[0];

            for (int i = 1; i < peliculas.Length; i++)
            {
                if (peliculas[i].DuracionMinutos < masCorta.DuracionMinutos)
                {
                    masCorta = peliculas[i];
                }
            }

            Console.WriteLine("Película mejor calificada: " + mejorCalificada.Titulo);
            Console.WriteLine("Película más corta: " + masCorta.Titulo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();

            catalogo.MostrarCatalogo();

            Console.ReadKey();
        }
    }
}
