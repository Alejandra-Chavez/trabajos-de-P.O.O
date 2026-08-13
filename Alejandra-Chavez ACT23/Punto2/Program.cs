using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2-
Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
drones de entrega en vuelo de regreso a la base.
 Crear la clase Dron que contenga los atributos privados: codigo (string) y
nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
Su constructor debe recibir cod y bat.
 Crear la clase CentroControl que administre una lista de objetos
List&lt;Dron&gt;.
 Métodos en CentroControl:

1. Un constructor que cargue por teclado una lista inicial de 4 drones
ingresando sus códigos y baterías.
2. ListarFlota(): Mostrar la lista de drones en pantalla.
3. RemoverDronesBajos(): Recorrer la lista y remover por
completo de la flota a todos aquellos drones cuyo nivel de batería
sea menor o igual al 15% (ya que requieren mantenimiento
automático urgente).
4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
cantidad de drones operativos utilizando la propiedad .Count.*/

    class dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            set { codigo = value; } get { return codigo; }
        }
        public int NivelBateria
        {
            set
            {
                if (value >= 0 && value <= 100)
                    nivelBateria = value;
                else
                    nivelBateria = 0;
            }
            get { return nivelBateria; }
        }
        public dron(string cod, int bat)
        {
            codigo = cod;
            NivelBateria = bat;
        }
    }
    internal class centroControl
    {
       private List<dron> listaDrones = new List<dron>();

        public centroControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Dron N°" + (i + 1) + ":");

                Console.Write("Ingrese el codigo del dron: ");
                string cod = Console.ReadLine();

                Console.Write("Ingrese el nivel de bateria del dron: ");
                int bat = int.Parse(Console.ReadLine());

                dron nuevo = new dron(cod, bat);

                listaDrones.Add(nuevo);
            }
        }

        public void listarFlota()
        {
            Console.WriteLine("Lista de drones:");

            foreach (dron dr in listaDrones)
            {
                Console.WriteLine("Código: " + dr.Codigo);
                Console.WriteLine("Nivel de bateria: " + dr.NivelBateria);
                Console.WriteLine();
            }
        }
        public void removerDronesBajos()
        {
            for (int i = listaDrones.Count - 1; i >= 0; i--)
            {
                if (listaDrones[i].NivelBateria <= 15)
                {
                    listaDrones.RemoveAt(i);
                }
            }
        }

        public void mostrarDronesRestantes()
        {
            Console.WriteLine("Drones restantes:");

            foreach (dron dr in listaDrones)
            {
                Console.WriteLine("Código: " + dr.Codigo);
                Console.WriteLine("Nivel de bateria: " + dr.NivelBateria);
                Console.WriteLine();
            }

            Console.WriteLine("Cantidad de drones operativos: " + listaDrones.Count);
        }

        static void Main(string[] args)
        {
            centroControl cc = new centroControl();

            cc.listarFlota();
            cc.removerDronesBajos();
            cc.mostrarDronesRestantes();

            Console.ReadKey();
        }
    }
}
