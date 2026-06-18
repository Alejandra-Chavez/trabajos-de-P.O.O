using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Fábrica de Computadoras (Herencia y Constructores con base)
Crear una clase base llamada Computadora que contenga los atributos Marca y
MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
Luego, definir dos clases derivadas de la clase base:
 Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
 Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/

    class Computadora
    {
        public string Marca;
        public int MemoriaRAM;
    }

    class Notebook : Computadora
    {
        public float TamanoPantalla;

        public Notebook(string marca, int memoriaRAM, float tamanoPantalla)
        {
            Marca = marca;
            MemoriaRAM = memoriaRAM;
            TamanoPantalla = tamanoPantalla;
        }

        public void Mostrar()
        {
            Console.WriteLine("NOTEBOOK");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("RAM: " + MemoriaRAM + " GB");
            Console.WriteLine("Pantalla: " + TamanoPantalla );
        }
    }

    class Escritorio : Computadora
    {
        public int PotenciaFuente;

        public Escritorio(string marca, int memoriaRAM, int potenciaFuente)
        {
            Marca = marca;
            MemoriaRAM = memoriaRAM;
            PotenciaFuente = potenciaFuente;
        }

        public void Mostrar()
        {
            Console.WriteLine("ESCRITORIO");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("RAM: " + MemoriaRAM + " GB");
            Console.WriteLine("Fuente: " + PotenciaFuente + " W");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Apple", 24, 15.6f);

            Escritorio escritorio = new Escritorio("HP", 16, 650);

            notebook.Mostrar();

            Console.WriteLine();

            escritorio.Mostrar();

            Console.ReadKey();
        }
    }
}