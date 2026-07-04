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
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingese la hora de inicio de la carrera: ");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de fin de la carrera: ");
            horaFin = DateTime.Parse(Console.ReadLine());
            corredores = new List<Corredor>();
        }
        public Carrera(int codigo, DateTime horaInicio, DateTime horaFin)
        {
            odigo = 0;
            horaInicio = DateTime.Now;
            horaFin = DateTime.Now;
            corredores = new List<Corredor>();
        }
    }
        public TimeSpan CalcularDuracion()
        {
            return horaFin - horaInicio;
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
        this.tiempoTotal = TimeSpan.FromMinutes(minutos);
    }

    public void RegistrarTiempo(int horas, int minutos)
    {
        this.tiempoTotal = new TimeSpan(horas, minutos, 0);
    }
    static void Main(string[] args)
        {

        }
    }
}
