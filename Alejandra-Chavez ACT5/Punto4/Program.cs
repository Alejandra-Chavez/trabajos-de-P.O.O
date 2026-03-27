using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*4. Se cuenta con la siguiente información:
● Las edades de 20 estudiantes del turno mañana.
● Las edades de 30 estudiantes del turno tarde.
● Las edades de 15 estudiantes del turno noche.
Las edades de cada estudiante deben ingresarse por teclado.
a) Obtener el promedio de las edades de cada turno (tres promedios)
b) Imprimir dichos promedios (promedio de cada turno)
c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
promedio de edades menor.*/


            int sumaManana = 0;
            int sumaTarde = 0;
            int sumaNoche = 0;
            int edad;
            string linea;
            int promManana, promTarde, promNoche;



            for (int i = 1; i <= 20; i++)
            {
                Console.Write(" ingresa la edad de los 20 almnos del turno mañana: ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                sumaManana = sumaManana + edad;
            }
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Ingresa la edada de los 30 alumnos del turno tarde: ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                sumaTarde = sumaTarde + edad;
            }
            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Ingresa la edad de los 15 alumnos del turno noche: ");
                edad = int.Parse(Console.ReadLine());
                sumaNoche = sumaNoche + edad;
            }

             promManana = sumaManana / 20;
             promTarde = sumaTarde / 30;
             promNoche =sumaNoche / 15;

            Console.WriteLine("Promedio turno mañana: " + promManana);
            Console.WriteLine("Promedio turno tarde: " + promTarde);
            Console.WriteLine("Promedio turno noche: " + promNoche);

            if (promManana < promTarde)
            {
                if (promManana < promNoche)
                {
                    Console.WriteLine("El turno mañana tiene el menor promedio");
                }
                else
                {
                    Console.WriteLine("El turno nohe tiene el menor promedio");
                }
            }
            else
            {
                if (promTarde < promNoche)
                {
                    Console.WriteLine("El turno tarde tiene el menor promedio");
                }
                else
                {
                    Console.WriteLine("El turno noche tiene el menor promedio");
                }
            }
            Console.ReadKey();
            }
    }
}
