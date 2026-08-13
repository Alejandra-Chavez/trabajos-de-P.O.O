using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Punto1
{
    /*1-
En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
llegada.
 Crear la clase Documento que contenga como atributos privados:
nombreArchivo (string) y cantidadPaginas (int). Definir sus
propiedades de solo lectura y un constructor que reciba los parámetros nom
y pag.
 Crear la clase ServidorImpresion que administre una lista dinámica de
documentos (List&lt;Documento&gt;).
 Métodos en ServidorImpresion:
1. AgregarDocumento(): Solicitar por teclado los datos de un
documento y agregarlo al final de la lista utilizando .Add().
2. ImprimirSiguiente(): Si la lista no está vacía, simular la
impresión del primer documento de la lista (mostrar sus datos en
consola) y removerlo de la colección mediante .RemoveAt(0). Si está
vacía, advertir que no hay trabajos pendientes.
3. MostrarColaPendiente(): Listar todos los documentos que
están esperando ser impresos y la cantidad total de páginas
acumuladas en la cola de espera utilizando .Count.*/

    class documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;
        public string NombreArchivo
        {
            get { return nombreArchivo; }
        }

        public int CantidadPaginas
        {
            get { return cantidadPaginas; }
        }

        public documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }
    internal class servidorImpresion
    {
        List<documento> documentos = new List<documento>();
        public void agregarDocumento()
        {
            Console.Write("ingrese el nombre del archivo");
            string nom = Console.ReadLine();
            Console.Write("Ingrese la cantidad de paginas del documento: ");
            string linea = Console.ReadLine();
            int pag = int.Parse(linea);

            documento nuevo = new documento(nom, pag);
            documentos.Add(nuevo);
        }
        public void imprimirSiguiente()
        {
            if (documentos.Count > 0)
            {
                documento doc = documentos[0];

                Console.WriteLine("Imprimiendo documento...");
                Console.WriteLine("Archivo: " + doc.NombreArchivo);
                Console.WriteLine("Páginas: " + doc.CantidadPaginas);

                documentos.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay trabajos pendientes.");
            }
        }

        public void mostrarColaPendiente()
        {
            int totalPaginas = 0;

            for (int i = 0; i < documentos.Count; i++)
            {
                Console.WriteLine("Archivo: " + documentos[i].NombreArchivo);

                Console.WriteLine("Páginas: " + documentos[i].CantidadPaginas);

                totalPaginas = totalPaginas + documentos[i].CantidadPaginas;
            }

            Console.WriteLine("Cantidad de documentos: " + documentos.Count);

            Console.WriteLine("Total de páginas pendientes: " + totalPaginas);
        }


        static void Main(string[] args)
        {
            servidorImpresion S = new servidorImpresion();

            S.agregarDocumento();
            S.imprimirSiguiente();
            S.mostrarColaPendiente();

            Console.ReadKey();
        }
    }
}
