using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*Actividad 3: Registro de entrenamientos
Problema:
Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
 Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
1. Uno que reciba horas y minutos y los convierta a minutos.
2. Otro que reciba directamente los minutos.
 Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
más corto.*/

    class entrenamiento
    {
        public string deportista;
        public int duracion;

        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = (horas * 60) + minutos;
        }

        public void RegistrarDuracion(int minutos)
        {
            duracion = minutos;
        }

        static void Main(string[] args)
        {
            List<entrenamiento> Entrenamientos = new List<entrenamiento>();

            entrenamiento e1 = new entrenamiento();
            e1.deportista = "Juan";
            e1.RegistrarDuracion(1, 30); 
            Entrenamientos.Add(e1);

            entrenamiento e2 = new entrenamiento();
            e2.deportista = "María";
            e2.RegistrarDuracion(120); 
            Entrenamientos.Add(e2);

            entrenamiento e3 = new entrenamiento();
            e3.deportista = "Pedro";
            e3.RegistrarDuracion(2, 15);
            Entrenamientos.Add(e3);

            entrenamiento e4 = new entrenamiento();
            e4.deportista = "Lucía";
            e4.RegistrarDuracion(45); 
            Entrenamientos.Add(e4);

            entrenamiento e5 = new entrenamiento();
            e5.deportista = "Carlos";
            e5.RegistrarDuracion(3, 0); 
            Entrenamientos.Add(e5);

            entrenamiento mayor = Entrenamientos[0];

            for (int i = 1; i < Entrenamientos.Count; i++)
            {
                if (Entrenamientos[i].duracion > mayor.duracion)
                {
                    mayor = Entrenamientos[i];
                }
            }
            Console.WriteLine("Entrenamiento más largo:");
            Console.WriteLine("Deportista: " + mayor.deportista);
            Console.WriteLine("Duración: " + mayor.duracion + " minutos");

            entrenamiento menor = Entrenamientos[0];

            for (int i = 1; i < Entrenamientos.Count; i++)
            {
                if (Entrenamientos[i].duracion < menor.duracion)
                {
                    menor = Entrenamientos[i];
                }
            }

            Console.WriteLine("Entrenamiento más corto:");
            Console.WriteLine("Deportista: " + menor.deportista);
            Console.WriteLine("Duración: " + menor.duracion + " minutos");

            Console.ReadKey();
        }
    }
}