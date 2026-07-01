using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*2. Plantear una clase Producto y otra clase Inventario.
La clase Producto debe tener como atributos privados el nombre, precio y
stock. Definir propiedades para acceder a estos atributos, asegurando que el
stock no pueda ser negativo y el precio sea mayor a cero.
La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
método para mostrar todos los productos ordenados de menor a mayor en
base al precio, además, mostrar el producto más caro y más barato del
inventario.*/

    class Producto
    {
        private string nombre;
        private double precio;
        private int stock;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
                else
                    precio = 1;
            }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    stock = value;
                else
                    stock = 0;
            }
        }

        public void ingresarDatos()
        {
            Console.Write("Ingrese el nombre del producto: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese el precio: ");
            string linea = Console.ReadLine();
            Precio = double.Parse(linea);

            Console.Write("Ingrese el stock: ");
            linea = Console.ReadLine();
            Stock = int.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: $" + Precio);
            Console.WriteLine("Stock: " + Stock);
        }
    }

    class Inventario
    {
        private Producto[] productos;

        public Inventario()
        {
            productos = new Producto[3];

            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new Producto();

                Console.WriteLine("Producto " + (i + 1));
                productos[i].ingresarDatos();
            }
        }

        public void mostrarProductos()
        {
            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = i + 1; j < productos.Length; j++)
                {
                    if (productos[i].Precio > productos[j].Precio)
                    {
                        Producto aux = productos[i];
                        productos[i] = productos[j];
                        productos[j] = aux;
                    }
                }
            }

            Console.WriteLine(" PRODUCTOS ORDENADOS POR PRECIO ");

            for (int i = 0; i < productos.Length; i++)
            {
                productos[i].imprimir();
            }

            Producto masBarato = productos[0];
            Producto masCaro = productos[0];

            for (int i = 1; i < productos.Length; i++)
            {
                if (productos[i].Precio < masBarato.Precio)
                {
                    masBarato = productos[i];
                }

                if (productos[i].Precio > masCaro.Precio)
                {
                    masCaro = productos[i];
                }
            }

            Console.WriteLine("Producto más barato: " + masBarato.Nombre);
            Console.WriteLine("Precio: $" + masBarato.Precio);
            Console.WriteLine("Producto más caro: " + masCaro.Nombre);
            Console.WriteLine("Precio: $" + masCaro.Precio);
        }

        static void Main(string[] args)
        {
            Inventario I = new Inventario();

            I.mostrarProductos();

            Console.ReadKey();
        }
    }
}
