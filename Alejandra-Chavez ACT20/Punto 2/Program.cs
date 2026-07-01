using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*Actividad 2: Administración de entregas logísticas
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/

    class paquete
    {
        private int codigo;
        private float peso;
        private string destino;

        public paquete(int cod, float pes, string dest)
        {
            codigo = cod;
            peso = pes;
            destino = dest;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public float Peso
        {
            get { return peso; }
        }

        public string Destino
        {
            get { return destino; }
        }
    }

    class despachador
    {
        private List<paquete> listaPaquetes = new List<paquete>();

        public void registrarPaquete(paquete p)
        {
            listaPaquetes.Add(p);
        }

        public void mostrarPaquetes()
        {
            Console.WriteLine("PAQUETES REGISTRADOS: ");

            foreach (paquete p in listaPaquetes)
            {
                Console.WriteLine("Código: " + p.Codigo);
                Console.WriteLine("Peso: " + p.Peso);
                Console.WriteLine("Destino: " + p.Destino);
                Console.WriteLine();
            }
        }

        public void contarPesados()
        {
            int mayorPeso = 0;

            foreach (paquete p in listaPaquetes)
            {
                if (p.Peso > 10)
                    mayorPeso++;
            }

            Console.WriteLine("Paquetes que superan los 10 kg: " + mayorPeso);
        }

        public void contarNacionales()
        {
            int nacional = 0;

            foreach (paquete p in listaPaquetes)
            {
                if (p.Destino == "argentina")
                    nacional++;
            }

            Console.WriteLine("Paquetes con destino nacional: " + nacional);
        }

        static void Main(string[] args)
        {
            despachador d = new despachador();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Paquete " + (i + 1));

                Console.Write("Código: ");
                int cod = int.Parse(Console.ReadLine());

                Console.Write("Peso: ");
                float pes = float.Parse(Console.ReadLine());

                Console.Write("Destino: ");
                string dest = Console.ReadLine();

                paquete p = new paquete(cod, pes, dest);
                d.registrarPaquete(p);

                Console.WriteLine();
            }

            d.mostrarPaquetes();
            d.contarPesados();
            d.contarNacionales();

            Console.ReadKey();
        }
    }
}

