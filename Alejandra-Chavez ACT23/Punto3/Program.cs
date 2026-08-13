using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3-
Un centro de conservación marina registra de forma dinámica las especies de
mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
 Crear la clase MonitoreoCostero que contenga como atributo privado
una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
 Métodos en MonitoreoCostero:
1. CargarAvistamientos(): Solicitar por teclado nombres de
especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
&quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
cuando el usuario ingresa la palabra &quot;FIN&quot;.
2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
organizada alfabéticamente de la A a la Z utilizando el método
.Sort().
3. MostrarReporteInvertido(): Imprimir la lista organizada de la
Z a la A combinando .Sort() con el método .Reverse().
4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
animal y, utilizando los métodos de búsqueda de listas, informar si la
especie fue divisada en la costa durante el día.*/

    
    internal class monitoreoCostero
    {
        private List<string>especiesDetectadas = new List<string>();


        public void cargarAvistamiento()
        {
            Console.WriteLine("A continuacion ingrese el nombre de especies marinas");
            Console.WriteLine("Para finalizar escriba fin");

            string especie = Console.ReadLine();

            while (especie != "fin")
            {
                especiesDetectadas.Add(especie);

                Console.Write("Ingrese otra especie: ");
                especie = Console.ReadLine();
            }
        }
        public void mostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();

            Console.WriteLine("Especies avistadas ordenadas alfabéticamente:");

            foreach (string especie in especiesDetectadas)
            {
                Console.WriteLine(especie);
            }
        }
        public void mostrarReporteInvertido()
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();

            Console.WriteLine("Especies avistadas ordenadas de la Z - A:");

            foreach (string especie in especiesDetectadas)
            {
                Console.WriteLine(especie);
            }
        }
        public void buscarEspecie()
        {
            Console.Write("Ingrese el nombre de la especie que desea buscar: ");
            string especie = Console.ReadLine();

            if (especiesDetectadas.Contains(especie))
            {
                Console.WriteLine("La especie fue divisada en la costa.");
            }
            else
            {
                Console.WriteLine("La especie no fue divisada en la costa.");
            }
        }
        static void Main(string[] args)
        {
            monitoreoCostero mc = new monitoreoCostero();

            mc.cargarAvistamiento();

            mc.mostrarReporteOrdenado();

            mc.mostrarReporteInvertido();

            mc.buscarEspecie();

            Console.ReadKey();
        }
    }
}
