using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
realice su asignación.
Luego, definir dos clases derivadas de la clase base:
● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
soportada en atmósferas).
● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
clase SondaExploradora mediante el uso explícito de la palabra clave base.
En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
parámetros unificados por consola.*/

    class sondaExploradora
    {
        public string modelo;
        public int autonomiaMinutos;

        public sondaExploradora(string mod, int autoMin)
        {
            modelo = mod;
            autonomiaMinutos = autoMin;

            Console.WriteLine("Se ejecutó el constructor de SondaExploradora");
        }
    }

    class sondaSubmarina : sondaExploradora
    {
        public int presionMaximaAtm;

        public sondaSubmarina(string mod, int autoMin, int presion)
            : base(mod, autoMin)
        {
            presionMaximaAtm = presion;

            Console.WriteLine("Se ejecutó el constructor de SondaSubmarina");
        }

        public void imprimir()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Autonomía (minutos): " + autonomiaMinutos);
            Console.WriteLine("Presión máxima (atm): " + presionMaximaAtm);
        }
    }

    class roverTerrestre : sondaExploradora
    {
        public int cantidadRuedas;

        public roverTerrestre(string mod, int autoMin, int ruedas)
            : base(mod, autoMin)
        {
            cantidadRuedas = ruedas;

            Console.WriteLine("Se ejecutó el constructor de RoverTerrestre");
        }

        public void imprimir()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Autonomía (minutos): " + autonomiaMinutos);
            Console.WriteLine("Cantidad de ruedas: " + cantidadRuedas);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" SONDA SUBMARINA ");

            sondaSubmarina s = new sondaSubmarina("", 180, 250);

            s.imprimir();

            Console.WriteLine();

            Console.WriteLine(" ROVER TERRESTRE ");

            roverTerrestre r = new roverTerrestre("", 360, 6);

            r.imprimir();

            Console.ReadKey();
        }
    }
}