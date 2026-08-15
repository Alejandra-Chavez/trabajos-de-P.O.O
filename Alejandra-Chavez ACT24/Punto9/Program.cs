using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    /*9-
Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
realizar el seguimiento académico de sus materias.
 Crear la clase Estudiante que contenga como atributos privados:
nombreCompleto (string) y calificacion (double). Definir sus propiedades
de solo lectura y un constructor que reciba nom y cal.
 Crear la clase GestionAcademica que administre una lista de objetos
List.
 Métodos en GestionAcademica:
o CargarEstudiantes(): Solicitar por teclado nombres y
calificaciones para agregar estudiantes a la lista mediante .Add(). La
carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
nombre.
o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
junto a la cantidad total de inscriptos mediante la propiedad .Count.
o FiltrarAprobados(): Recorrer la lista e imprimir en consola
únicamente aquellos estudiantes cuya calificación sea mayor o igual
a 6.0.
o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
utilizando los métodos de búsqueda y remoción de listas, eliminarlo
de la colección si se encuentra presente.*/
    class estudiante
    {
        private string nombreCompleto;
        private double calificaciones;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public double Calificaciones
        {
            get { return calificaciones; }
        }
        public estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificaciones = cal;
        }
    }
    internal class gestionAcademica
    {
        List<estudiante> estudiantes  = new List<estudiante>();
        public void cargarEstudiante()
        {
            Console.WriteLine("Ingrese el nombre y la calificacion del alumno");
            Console.WriteLine("Para finalizar escribir en nombre FIN");
            Console.Write("Ingrese el nombre del alumno: ");
            string nom = Console.ReadLine();

            while (nom != "FIN")
            {
                Console.Write("Ingrese la calificacion del alumno: ");
                string linea = Console.ReadLine();
                double cal = double.Parse(linea);

                estudiante nuevo = new estudiante(nom,cal);

                estudiantes.Add(nuevo);

                Console.Write("Ingrese otro alumno: ");
                nom = Console.ReadLine();
            }
        }
        public void listarEstudiantes()
        {
            Console.WriteLine("Lista estudiantes");
            foreach (estudiante E in estudiantes)
            {
                Console.WriteLine("Nombre del medicamento: " + E.NombreCompleto);
                Console.WriteLine("Calificacion: " + E.Calificaciones);
            }
            Console.WriteLine("Cantidad total de inscriptos: " + estudiantes.Count);
        }
        public void filtrarAprobados()
        {
            Console.WriteLine("Estudiantes aprobados:");

            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Calificaciones >= 6.0)
                {
                    Console.WriteLine("Nombre: " + estudiantes[i].NombreCompleto);
                    Console.WriteLine("Calificación: " + estudiantes[i].Calificaciones);
                }
            }
        }
        public void darDeBaja()
        {
            Console.WriteLine("Ingrese el nombre del alumno que quiera dar de baja: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].NombreCompleto == nombre)
                {
                    estudiantes.Remove(estudiantes[i]);

                    Console.WriteLine("Estudiante dado de baja correctamente.");

                }
               
            }
            Console.WriteLine("No se encontró al estudiante.");
        }

        static void Main(string[] args)
        {
            gestionAcademica G = new gestionAcademica();
            G.cargarEstudiante();
            G.listarEstudiantes();
            G.filtrarAprobados();
            G.darDeBaja();

            Console.ReadKey();
        }
    }
}
