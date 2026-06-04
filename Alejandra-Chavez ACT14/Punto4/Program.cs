using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Inventario de Sucursales 
Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
Implementar en la clase Sucursal los siguientes métodos:
Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
Un método que busque y muestre el nombre del artículo más caro del local.
Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
*/
    class Articulo
    {
        private string nombreArticulo;
        private double precio;
        private int stockActual;

        public Articulo()
        {
            Console.Write("Ingrese el nombre del articulo ");
            nombreArticulo = Console.ReadLine();
            Console.Write("Ingrese el precio de dicho articulo ");
            string linea = Console.ReadLine();
                precio = double.Parse(linea);
            Console.Write("E ingrese la cantidad que hay en stock ");
            linea = Console.ReadLine();
            stockActual = int.Parse(linea);
        }
        public string returnNombreProducto()
        {
            return nombreArticulo;
        }
        public double returnPrecio()
        {
            return precio;
        }
        public int returnStock()
        {
            return stockActual;
        }
    }
    class Sucursal
    {
        private int numSucursal;
        private Articulo[] articulos;

        public Sucursal()
        {
            Console.WriteLine("Ingrese el numero o identificador de la sucursal: ");
            string linea = Console.ReadLine();
            numSucursal = int.Parse(linea);

            articulos = new Articulo[3];
            Console.WriteLine("Carga de articulos por sucursal: ");
            for (int i = 0; i < articulos.Length; i++)
            {
                Console.WriteLine("Articulo" + (i + 1));
            articulos[i] = new Articulo();
            }
        }
    

    public void imprimir()
        {
            double valorTotal = 0;

            Console.WriteLine("Datos de la sucursal N° " + numSucursal );
            for (int i = 0; i < articulos.Length; i++)
            {
                valorTotal = articulos[i].returnPrecio() * articulos[i].returnStock();

                Console.WriteLine("Nombre del articulo: " + articulos[i].returnNombreProducto + " Precio total " + valorTotal);
            }
        }
        public void articuloMayorPrecio()
        {
            double mayor = 0;
            for(int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].returnPrecio > articulos[i].returnPrecio)
                {
                    mayor = i;
                }
                Console.WriteLine("El articulo " + articulos[i].returnNombreProducto + "es el mas caro del local con un precio de " + articulos[i].returnPrecio());
            }
        }
        public void menorCantidadArticulo()
        {
            for (int i = 0; i < articulos.Length ; i++)
            {
                if (articulos[i].returnStock < 5)
                {
                    Console.WriteLine("El articulo " + articulos[i].returnNombreProducto() + "requiere reposición urgente");
                }
            }
        }
        static void Main(string[] args)
        {
            Sucursal S = new Sucursal();
            S.imprimir();
            S.articuloMayorPrecio();
            S.menorCantidadArticulo();

            Console.ReadKey();
        }
    }
}
