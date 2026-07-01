using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*3. Crear una clase base Vehículo que contenga atributos marca y
velocidadMaxima.
Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
una debe tener un constructor que reciba los valores de los atributos base
mediante la palabra clave base, y un atributo propio (cantidadPuertas en
Auto, cilindrada en Moto).
Crear un objeto de cada clase y mostrar todos sus datos por consola.*/

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


class Vehiculo
{
    public string marca;
    public int velocidadMaxima;

    public Vehiculo(string mar, int velocidad)
    {
        marca = mar;
        velocidadMaxima = velocidad;

        Console.WriteLine("Se ejecutó el constructor de Vehículo");
    }
}

class Auto : Vehiculo
{
    public int cantidadPuertas;

    public Auto(string mar, int velocidad, int puertas)
        : base(mar, velocidad)
    {
        cantidadPuertas = puertas;

        Console.WriteLine("Se ejecutó el constructor de Auto");
    }

    public void imprimir()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Velocidad máxima: " + velocidadMaxima);
        Console.WriteLine("Cantidad de puertas: " + cantidadPuertas);
    }
}

class Moto : Vehiculo
{
    public int cilindrada;

    public Moto(string mar, int velocidad, int cil)
        : base(mar, velocidad)
    {
        cilindrada = cil;

        Console.WriteLine("Se ejecutó el constructor de Moto");
    }

    public void imprimir()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Velocidad máxima: " + velocidadMaxima);
        Console.WriteLine("Cilindrada: " + cilindrada);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" AUTO ");

        Auto a = new Auto("Toyota", 220, 4);

        a.imprimir();

        Console.WriteLine(" MOTO ");

        Moto m = new Moto("Honda", 180, 600);

        m.imprimir();

        Console.ReadKey();
    }
}
