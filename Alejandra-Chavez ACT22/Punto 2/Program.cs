using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*Actividad 2: Posicionamiento de elementos en consola
Problema:
Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
 Implementar propiedades y un constructor que cargue valores.
 Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
nombre en pantalla y Console.CursorVisible para ocultar el cursor.
 Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
consola.*/
    class elementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public elementoPantalla(string nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.posX = posX;
            this.posY = posY;
        }

        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(posX, posY);
            Console.Write(nombre);
        }
    
        static void Main(string[] args)
        {
            elementoPantalla[] E = new elementoPantalla[4];

            E[0] = new elementoPantalla("Marte", 10, 2);
            E[1] = new elementoPantalla("Saturno", 30, 5);
            E[2] = new elementoPantalla("Jupiter", 15, 10);
            E[3] = new elementoPantalla("Mercurio", 40, 15);

            for (int i = 0; i < E.Length; i++)
            {
                E[i].Mostrar();
            }

            Console.SetCursorPosition(0, 20);
            Console.CursorVisible = true;

            Console.ReadKey();
        }
    }
}
