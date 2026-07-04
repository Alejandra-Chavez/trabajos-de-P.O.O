using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*Actividad 1: Control de horarios en un gimnasio
Problema:
Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
DateTime).
 Implementar un constructor que permita cargar los datos desde consola y otro
que cargue valores por defecto (sobrecarga de constructores).
 Incluir un método para calcular la duración de la clase usando TimeSpan.
 Crear un vector de 3 clases de gimnasio y mostrar:
1. La clase que tenga la mayor duración.
2. El nombre y el horario de inicio de la clase más temprana.*/

    class claseGimnasio
    {
        public string nombreClase;
        public DateTime horaInicio;
        public DateTime horaFin;

        public claseGimnasio()
        {
            nombreClase = "Yoga";
            horaInicio = DateTime.Parse("08:00");
            horaFin = DateTime.Parse("09:00"); 

        }
        public claseGimnasio(int x)
        {
            Console.Write("Ingrese el nombre de la clase: ");
            nombreClase = Console.ReadLine();

            Console.Write("Ingrese la hora de inicio de la clase (HH:mm): ");
            horaInicio = DateTime.Parse(Console.ReadLine());

            Console.Write("Ingrese la hora en que finaliza la clase (HH:mm): ");
            horaFin = DateTime.Parse(Console.ReadLine());
        }
        public TimeSpan CalcularDuracion()
        {
            return horaInicio - horaFin;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            claseGimnasio[] clases = new claseGimnasio[3];

            for (int i = 0; i < clases.Length; i++)
            {
                Console.WriteLine("Clase" + (i + 1));
                clases[i] = new claseGimnasio(1);
            }

            claseGimnasio mayorDuracion = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].CalcularDuracion() > mayorDuracion.CalcularDuracion())
                {
                    mayorDuracion = clases[i];
                }
            }

            claseGimnasio masTemprana = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].horaInicio < masTemprana.horaInicio)
                {
                    masTemprana = clases[i];
                }
            }
            Console.WriteLine(" RESULTADOS ");

            Console.WriteLine("Clase con mayor duración:");
            Console.WriteLine("Nombre: " + ( mayorDuracion.nombreClase));
            Console.WriteLine("Duración: "+ (mayorDuracion.CalcularDuracion()));

            Console.WriteLine("Clase que comienza más temprano:");
            Console.WriteLine("Nombre:" + (masTemprana.nombreClase));
            Console.WriteLine("Hora de inicio: " + masTemprana.horaInicio.ToString("HH:mm"));

            Console.ReadKey();
        }
    }
}

