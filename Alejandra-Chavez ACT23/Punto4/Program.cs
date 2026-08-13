using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4-

Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
vinculados a una red hogareña.
 Crear la clase DispositivoInteligente que contenga como atributos
privados: nombreDispositivo (string) y consumoWatts (double). Definir
sus propiedades y un constructor que reciba nom y watts.
 Crear la clase colaboradora PanelDomotico que administre un objeto
List&lt;DispositivoInteligente&gt;.
 Métodos en PanelDomotico:
1. Un constructor que permita al usuario cargar dinámicamente
dispositivos por teclado. El sistema preguntará después de cada
carga si se desea agregar otro dispositivo.
2. MostrarDispositivos(): Listar todos los dispositivos
configurados junto a sus consumos.
3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
Watts totales que consume la casa sumando los valores de la lista.
4. DesconectarDispositivo(): Solicitar al usuario el nombre de
un dispositivo y, si existe en la lista, removerlo de forma dinámica
para simular su apagado remoto.*/

    class dispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            set { nombreDispositivo = value; }
            get { return nombreDispositivo; }
        }

        public double ConsumoWatts
        {
            set { consumoWatts = value; }
            get { return consumoWatts; }
        }

        public dispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }

    class panelDomotico
    {
        private List<dispositivoInteligente> dispositivos = new List<dispositivoInteligente>();

        public panelDomotico()
        {
            string respuesta;

            do
            {
                Console.Write("Ingrese el nombre del dispositivo: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el consumo en Watts: ");
                double watts = double.Parse(Console.ReadLine());

                dispositivoInteligente nuevo = new dispositivoInteligente(nombre, watts);

                dispositivos.Add(nuevo);

                Console.Write("¿Desea agregar otro dispositivo? (si/no): ");
                respuesta = Console.ReadLine();

            } while (respuesta.ToLower() == "si");
        }

        public void MostrarDispositivos()
        {
            Console.WriteLine("Dispositivos configurados:");

            foreach (dispositivoInteligente dispositivo in dispositivos)
            {
                Console.WriteLine("Dispositivo: " + dispositivo.NombreDispositivo);

                Console.WriteLine("Consumo: " + dispositivo.ConsumoWatts + " Watts");

                Console.WriteLine();
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;

            foreach (dispositivoInteligente dispositivo in dispositivos)
            {
                total += dispositivo.ConsumoWatts;
            }

            Console.WriteLine("Consumo total: " + total + " Watts");
        }

        public void DesconectarDispositivo()
        {
            Console.Write("Ingrese el nombre del dispositivo a desconectar: ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < dispositivos.Count; i++)
            {
                if (dispositivos[i].NombreDispositivo == nombre)
                {
                    dispositivos.RemoveAt(i);

                    Console.WriteLine("Dispositivo desconectado.");
                    return;
                }
            }

            Console.WriteLine("El dispositivo no existe.");
        }

        static void Main(string[] args)
        {
            panelDomotico pd = new panelDomotico();

            pd.MostrarDispositivos();

            pd.CalcularConsumoTotal();

            pd.DesconectarDispositivo();

            pd.MostrarDispositivos();

            pd.CalcularConsumoTotal();

            Console.ReadKey();

        }
    }
}
