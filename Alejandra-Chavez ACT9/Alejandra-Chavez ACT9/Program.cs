using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT9
{
    internal class Notas
    {
        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.*/

        private int[] notas;
        private string[] nombre;
        string linea;

        public void ingresoNotasNombre()
        {
            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = new string[6];
            for(int i =0; i < nombre.Length; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                linea = Console.ReadLine();
                nombre[i] = linea;
            }

            Console.WriteLine("Ingrese las nots del respectivo alumno");
            notas = new int[6];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Notas " + (i + 1) + ": ");
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }

        public void notaMayor()
        {
            int mayor = notas[0];

            
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                }
            }

            Console.WriteLine("Nota más alta: " + mayor);

            int contador = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == mayor)
                {
                    Console.WriteLine("Alumno: " + nombre[i]);
                    contador++;
                }
            }

            
            if (contador > 1)
            {
                Console.WriteLine(contador + "veces se repite la nota mas alta");
            }
        
        }
        public void notaMenor()
        {
            int menor = notas[0];

           
            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            Console.WriteLine("Nota más baja: " + menor);


            int contador = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == menor)
                {
                    Console.WriteLine("Alumno: " + nombre[i]);
                    contador++;
                }
            }

            if (contador > 1)
            {
                Console.WriteLine(contador + "veces se repite la nota mas baja");
            }
        }
        
        static void Main(string[] args)
        {
            Notas N = new Notas();
            N.ingresoNotasNombre();
            N.notaMayor();
            N.notaMenor();
            Console.ReadKey();
        }
    }
}
