using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    /*6-
Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
para organizar la consulta de ejemplares por parte de los lectores.
 Crear la clase Libro que contenga como atributos privados: titulo
(string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
un constructor que reciba tit y anio.
 Crear la clase BibliotecaCentral que administre una lista de objetos
List.
 Métodos en BibliotecaCentral:
1. CargarCatalogo(): Solicitar por teclado títulos y años de
publicación para agregar libros a la lista mediante .Add(). La carga
finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
junto a la cantidad total de obras registradas mediante la propiedad
.Count.
3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
imprimir en consola únicamente aquellos libros cuyo año de
publicación sea menor a dicho valor.
4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
los métodos de búsqueda y remoción de listas, eliminarlo de la
colección si se encuentra presente.*/

    class libro
    {
        private string titulo;
        private int anioPublicacion;

        public string Titulo
        {
            get { return titulo; }
        }

        public int AnioPublicacion
        {
            get { return anioPublicacion; }
        }

        public libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }
    }

    internal class bibliotecaCentral
    {
        List<libro> biblioteca = new List<libro>();

        public void cargarCatalogo()
        {
            Console.WriteLine("A continuación ingrese diferentes libros para llenar el catálogo.");
            Console.WriteLine("Para finalizar la carga escriba FIN");

            Console.Write("Ingrese el título del libro: ");
            string tit = Console.ReadLine();

            while (tit != "FIN")
            {
                Console.Write("Ingrese el año de publicación: ");
                string linea = Console.ReadLine();
                int anio = int.Parse(linea);

                libro nuevo = new libro(tit, anio);

                biblioteca.Add(nuevo);

                Console.Write("Ingrese otro libro: ");
                tit = Console.ReadLine();
            }
        }

        public void listarCatalogo()
        {
            Console.WriteLine("Catálogo de libros:");

            foreach (libro l in biblioteca)
            {
                Console.WriteLine("Título: " + l.Titulo);
                Console.WriteLine("Año de publicación: " + l.AnioPublicacion);
            }

            Console.WriteLine("Cantidad total de obras: " + biblioteca.Count);
        }

        public void filtrarPorAnio()
        {
            Console.Write("Ingrese un año: ");
            string linea = Console.ReadLine();
            int anioElegido = int.Parse(linea);

            Console.WriteLine("Libros publicados antes de " + anioElegido + ":");

            foreach (libro l in biblioteca)
            {
                if (l.AnioPublicacion < anioElegido)
                {
                    Console.WriteLine("Título: " + l.Titulo);
                    Console.WriteLine("Año de publicación: " + l.AnioPublicacion);
                }
            }
        }

        public void removerLibro()
        {
            Console.Write("Ingrese el título del libro que desea eliminar: ");
            string tituloEliminar = Console.ReadLine();

            for (int i = 0; i < biblioteca.Count; i++)
            {
                if (biblioteca[i].Titulo == tituloEliminar)
                {
                    biblioteca.Remove(biblioteca[i]);

                    Console.WriteLine("El libro fue eliminado correctamente.");

                    return;
                }
            }

            Console.WriteLine("No se encontró el libro.");
        }

        static void Main(string[] args)
        {
            bibliotecaCentral b = new bibliotecaCentral();

            b.cargarCatalogo();
            b.listarCatalogo();
            b.filtrarPorAnio();
            b.removerLibro();

            Console.ReadKey();
        }
    }
}
