using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    /*Actividad 5: Gestión de Carreras Deportivas
Consigna:
Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
Se pide:
1. Crear una clase Carrera con:
o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
definidos.
o Dos constructores (uno por defecto y otro con parámetros).
o Método para calcular la duración de la carrera usando TimeSpan.
2. Crear una clase Corredor con:
o Atributos: nombre, número de dorsal y tiempo total.
o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
horas y minutos).

3. Mostrar en consola (usando Console.SetCursorPosition()):
o La carrera con mayor duración.
o El corredor más rápido.
4. Utilizar this en los constructores o métodos donde corresponda.*/

    class Carrera 
    {
        int codigo;
        DateTime horaInicio;
        DateTime horaFin;

        List<Corredor> corredores;

        public Carrera()
        {
            Console.WriteLine("Ingrese el codigo de la carrera: ");
            string linea = Console.ReadLine();
            codigo = int.Parse(linea);
            Console.WriteLine("Ingese la hora de inicio de la carrera: ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de fin de la carrera: ");
            horaFin = DateTime.Parse(Console.ReadLine());
            corredores = new List<Corredor>();
        }
        public Carrera(int codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            corredores = new List<Corredor>();
        }
        public TimeSpan CalcularDuracion()
        {
            return horaFin - horaInicio;
        }
        public void AgregarCorredor(Corredor c)
        {
            corredores.Add(c);
        }

        public Corredor CorredorMasRapido()
        {
            Corredor rapido = corredores[0];

            foreach (Corredor c in corredores)
            {
                if (c.tiempoTotal < rapido.tiempoTotal)
                {
                    rapido = c;
                }
            }

            return rapido;
        }

        public int ObtenerCodigo()
        {
            return codigo;
        }
    }
    internal class Corredor 
    {

    public string nombre;
    public int dorsal;
    public TimeSpan tiempoTotal;

    public Corredor()
    {
        nombre = "";
        dorsal = 0;
        tiempoTotal = TimeSpan.Zero;
    }

    public Corredor(string nombre, int dorsal)
    {
        this.nombre = nombre;
        this.dorsal = dorsal;
        tiempoTotal = TimeSpan.Zero;
    }

        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = new TimeSpan(0, minutos, 0);
        }

        public void RegistrarTiempo(int horas, int minutos)
    {
        this.tiempoTotal = new TimeSpan(horas, minutos, 0);
    }
    static void Main(string[] args)
        {
            List<Carrera> carreras = new List<Carrera>();

            Carrera carrera1 = new Carrera(101,
                DateTime.Parse("08:00"),
                DateTime.Parse("09:30"));

            Corredor c1 = new Corredor("Pepe", 10);
            c1.RegistrarTiempo(55);

            Corredor c2 = new Corredor("Rivadavia", 15);
            c2.RegistrarTiempo(1, 5);

            carrera1.AgregarCorredor(c1);
            carrera1.AgregarCorredor(c2);

            carreras.Add(carrera1);

            Carrera carrera2 = new Carrera(102,
                DateTime.Parse("10:00"),
                DateTime.Parse("12:00"));

            Corredor c3 = new Corredor("Berni", 20);
            c3.RegistrarTiempo(1, 20);

            Corredor c4 = new Corredor("Lucia", 25);
            c4.RegistrarTiempo(70);

            carrera2.AgregarCorredor(c3);
            carrera2.AgregarCorredor(c4);

            carreras.Add(carrera2);

            Carrera mayor = carreras[0];

            foreach (Carrera c in carreras)
            {
                if (c.CalcularDuracion() > mayor.CalcularDuracion())
                {
                    mayor = c;
                }
            }


            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Carrera con mayor duración");

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Código: " + mayor.ObtenerCodigo());

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Duración: " + mayor.CalcularDuracion());

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Corredor más rápido de la carrera más larga");

            Corredor rapido = mayor.CorredorMasRapido();

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Nombre: " + rapido.nombre);

            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Dorsal: " + rapido.dorsal);

            Console.SetCursorPosition(0, 7);
            Console.WriteLine("Tiempo: " + rapido.tiempoTotal);

            Console.ReadKey();
        }
    }
}