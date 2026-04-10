using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_Act4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
$500, realizar un programa que lea los sueldos que cobra cada empleado e
informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
de $300. Además el programa deberá informar el importe que gasta la empresa
en sueldos al personal.*/

            int empleados = 1;
            int entre100y300 = 0;
            int mas300 = 0;
            int totalSueldos = 0;
            int sueldo;
            string linea;

            while (empleados <= 5)
            {
                Console.Write("Ingrese el sueldo: ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);

                if (sueldo >= 100)
                {
                    if (sueldo <= 300)
                    {
                        entre100y300++;
                    }
                    else
                    {
                        mas300++;
                    }
                }
                totalSueldos = totalSueldos + sueldo;

                empleados++;
            }

            Console.WriteLine("Empleados que cobran entre 100 y 300: " + entre100y300);
            Console.WriteLine("Empleados que cobran más de 300: " + mas300);
            Console.WriteLine("Total que gasta la empresa: " + totalSueldos);

            Console.ReadKey();
        }
    }
}
