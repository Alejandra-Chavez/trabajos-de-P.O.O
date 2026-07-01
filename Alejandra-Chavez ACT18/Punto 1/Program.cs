using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
imprimir estos datos básicos.
Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
En el programa principal (Main):
● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
puede acceder tanto a sus propiedades*/

    class dispositivoEnergia
    {
        private string codigoIdentificador;
        private double generacionKwh;

        public string CodigoIdentificador
        {
            get { return codigoIdentificador; }
            set { codigoIdentificador = value; }
        }

        public double GeneracionKwh
        {
            get { return generacionKwh; }
            set
            {
                if (value >= 0)
                    generacionKwh = value;
                else
                    generacionKwh = 0;
            }
        }

        public void ingresarDatos()
        {
            Console.Write("Ingrese el código identificador: ");
            CodigoIdentificador = Console.ReadLine();

            Console.Write("Ingrese los kilowatts por hora generados: ");
            string linea = Console.ReadLine();
            GeneracionKwh = double.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("Código Identificador: " + CodigoIdentificador);
            Console.WriteLine("Generación Kwh: " + GeneracionKwh);
        }
    }

    internal class panelSolar : dispositivoEnergia
    {

        private double areaMetros;

        public double AreaMetros
        {
            get { return areaMetros; }
            set
            {
                if (value > 0)
                    areaMetros = value;
                else
                    areaMetros = 0;
            }
        }

        public void ingresarDatos()
        {
            Console.Write("Ingrese el código identificador: ");
            CodigoIdentificador = Console.ReadLine();

            Console.Write("Ingrese los kilowatts por hora generados: ");
            string linea = Console.ReadLine();
            GeneracionKwh = double.Parse(linea);

            Console.Write("Ingrese la superficie del panel en metros cuadrados: ");
            linea = Console.ReadLine();
            AreaMetros = double.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("Código Identificador: " + CodigoIdentificador);
            Console.WriteLine("Generación Kwh: " + GeneracionKwh);
            Console.WriteLine("Área del panel: " + AreaMetros);
        }


        static void Main(string[] args)
        {
            dispositivoEnergia D = new dispositivoEnergia();

            Console.WriteLine(" Dispositivo de Energia");
            D.ingresarDatos();
            D.imprimir();

            panelSolar P = new panelSolar();

            Console.WriteLine(" Panel Solar ");
            P.ingresarDatos();
            P.imprimir();

            Console.ReadKey();
        }
    }
}