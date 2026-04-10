using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alejandra_Chavez_ACT6
{
    internal class Punto
  
            /*1. Desarrollar una clase que represente un punto en el plano y tenga los
siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
positivas, si x < ;0 e y > 0 segundo cuadrante, etc.)*/

            
            private int x;
            private int y;
            string linea;
            public void CargarValores()
            {
                Console.Write("Ingrese valor de x: ");
                linea = Console.ReadLine();
                x = int.Parse(linea);

                Console.Write("Ingrese valor de y: ");
                linea = Console.ReadLine();
                y = int.Parse(linea);
            }

            public void ImprimirCuadrante()
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primer cuadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo cuadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Tercer cuadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Cuarto cuadrante");
                }

            }

            static void Main(string[] args)
            {
                Punto p = new Punto();
                p.CargarValores();
                p.ImprimirCuadrante();

        Console.ReadKey();
            }
        }
      }
    }

