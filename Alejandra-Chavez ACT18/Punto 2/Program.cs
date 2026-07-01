using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
La clase CriaturaMarina debe tener como atributos privados: Especie (string),
ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
● La profundidad óptima sea estrictamente mayor a cero (0).
● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
nivel de salinidad para sobrevivir.*/

    class criaturaMarina
    {

        private string especie;
        private int profundidadOptima;
        private int nivelSalanidad;

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int ProfundidadOptima
        {
            get { return profundidadOptima; }
            set
            {
                if (value > 0)
                    profundidadOptima = value;
                else
                    profundidadOptima = 1;
            }
        }

        public int NivelSalanidad
        {
            get { return nivelSalanidad; }
            set
            {
                if (value >= 1 && value <= 100)
                    nivelSalanidad = value;
                else
                    nivelSalanidad = 35;
            }
        }

        public void ingresarDatos()
        {
            Console.Write("Ingrese la especie del animal: ");
            Especie = Console.ReadLine();

            Console.Write("Ingrese la profundidad óptima: ");
            string linea = Console.ReadLine();
            ProfundidadOptima = int.Parse(linea);

            Console.Write("Ingrese el nivel de salinidad: ");
            linea = Console.ReadLine();
            NivelSalanidad = int.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("Especie: " + Especie);
            Console.WriteLine("Profundidad Óptima: " + ProfundidadOptima);
            Console.WriteLine("Nivel de Salinidad: " + NivelSalanidad);
            Console.WriteLine();
        }
    }

    internal class habitatAcuatico
        {
        private criaturaMarina[] animalesMarinos;

        public habitatAcuatico()
        {
            animalesMarinos = new criaturaMarina[3];

            for (int i = 0; i < animalesMarinos.Length; i++)
            {
                animalesMarinos[i] = new criaturaMarina();

                Console.WriteLine("Animal acuático " + (i + 1));
                animalesMarinos[i].ingresarDatos();
            }
        }

        public void mostrarAnimales()
        {
         
            for (int i = 0; i < animalesMarinos.Length - 1; i++)
            {
                for (int j = i + 1; j < animalesMarinos.Length; j++)
                {
                    if (animalesMarinos[i].ProfundidadOptima >
                        animalesMarinos[j].ProfundidadOptima)
                    {
                        criaturaMarina aux = animalesMarinos[i];
                        animalesMarinos[i] = animalesMarinos[j];
                        animalesMarinos[j] = aux;
                    }
                }
            }

            Console.WriteLine("Animales marinos ordenados por profundidad óptima: ");

            for (int i = 0; i < animalesMarinos.Length; i++)
            {
                animalesMarinos[i].imprimir();
            }

            criaturaMarina mayorNivelSalanidad = animalesMarinos[0];

            for (int i = 1; i < animalesMarinos.Length; i++)
            {
                if (animalesMarinos[i].NivelSalanidad >
                    mayorNivelSalanidad.NivelSalanidad)
                {
                    mayorNivelSalanidad = animalesMarinos[i];
                }
            }

            Console.WriteLine("La especie que requiere mayor nivel de salinidad es: "
                              + mayorNivelSalanidad.Especie);
        }

        static void Main(string[] args)
        {
            habitatAcuatico H = new habitatAcuatico();

            H.mostrarAnimales();

            Console.ReadKey();
        }
    }
}


