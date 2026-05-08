using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT11
{
    internal class Temperatura
    {
        /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
dato las temperaturas medias mensuales de dichos paises.
Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
memoria.
a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
mismas.
c. Calcular la temperatura media trimestral de cada país.
d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/
        
        private string[] paises;
        private double[,] temperaturas;
        string linea;

        public void cargar()
        {
            paises = new string[4];
            temperaturas = new double[4, 3];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el nombre del pais: ");
                paises[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingresa la temperatura del pais: ");
                    linea= Console.ReadLine();
                    temperaturas[i, j] = double.Parse(linea);
                }
            }
        }

        public void imprimir()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(paises[i] + ": ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(temperaturas[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public void temperaturaMedia()
        {
            double promedio;
            double suma;
            double mayor = 0;
            string paisMayor = "";

            for (int i = 0; i < 4; i++)
            {
                suma = 0;

                for (int j = 0; j < 3; j++)
                {
                    suma += temperaturas[i, j];
                }

                promedio = suma / 3;

                Console.WriteLine(
                    "Temperatura media de " +
                    paises[i] + ": " + promedio);

                if (promedio > mayor)
                {
                    mayor = promedio;
                    paisMayor = paises[i];
                }
            }

            Console.WriteLine(
                "Pais con mayor temperatura media: " +
                paisMayor);
        }

        static void Main(string[] args)
        {
            Temperatura t = new Temperatura();
            t.cargar();
            t.imprimir();
            t.temperaturaMedia();
            Console.ReadKey();
        }
    }
}
