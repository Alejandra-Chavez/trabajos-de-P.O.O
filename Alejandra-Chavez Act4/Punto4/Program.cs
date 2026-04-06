using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
 cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
 finalizar al ingresar un valor negativo en el número de cuenta.
 Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
 informe:
 a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
 que:
 Estado de la cuenta:
 ○ “Acreedor” si el saldo es &gt;0.
 ○ “Deudor” si el saldo es &lt;0.
 ○ “Nulo” si el saldo es =0.
 b) La suma total de los saldos acreedores.*/

            int numeroCuenta;
            double saldo;
            double sumaAcreedores = 0;
            string linea;

            do
            {
                Console.Write("Ingrese número de cuenta: ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);

                if (numeroCuenta >= 0)
                {
                    Console.Write("Ingrese saldo: ");
                    linea = Console.ReadLine();
                    saldo = double.Parse(linea);

                    Console.WriteLine("Cuenta: " + numeroCuenta);

                    if (saldo > 0)
                    {
                        Console.WriteLine("Estado: Acreedor");
                        sumaAcreedores = sumaAcreedores + saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Estado: Deudor");
                        }
                        else
                        {
                            Console.WriteLine("Estado: Nulo");
                        }
                    }
                }

            } while (numeroCuenta >= 0);

            Console.WriteLine("Total de saldos acreedores: " + sumaAcreedores);


        }
    }
}
