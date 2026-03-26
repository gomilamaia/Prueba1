using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ebrou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hola
            string mensaje = "Hola mundo";



            int op = -1;
            CuentaBancaria NuevaCuenta=null;
            do
            {
                Console.Write("Bienvenidos a ebrou");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1.Crear cuenta");
                Console.WriteLine("2.Depositar");
                Console.WriteLine("3.Extraer");
                Console.WriteLine("4.Ver saldo");
                Console.WriteLine("5.Salir");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        if (NuevaCuenta == null)
                        {
                            NuevaCuenta=CrearCuenta();
                            Console.WriteLine("Cuenta creada con éxito");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La cuenta ya ha sido creada");
                            Console.ReadKey();
                        }
                            break;

                        case 2:
                        Console.Clear();
                        if (NuevaCuenta != null)
                        {
                            Opcion2(NuevaCuenta);
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine("Debe de crear una cuenta");
                            Console.ReadKey();
                        }

                            break;

                        case 3:
                        Console.Clear();
                        if (NuevaCuenta != null)
                        {
                            Opcion3(NuevaCuenta);
                        }
                        else
                        {
                            Console.WriteLine("Debe de crear una cuenta");
                            Console.ReadKey();
                        }
                            break;

                    case 4:
                        Console.Clear();
                        Opcion4(NuevaCuenta);
                        break;

                    default:

                        Console.WriteLine("Gracias por usar ebrou, nos veremos pronto!");
                        Console.ReadKey();

                        break;

                }
            }

            while (op != 5);



           

        }

        static CuentaBancaria CrearCuenta()
        {
           

            Console.WriteLine("Ingrese número de cuenta");
            int numero =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del titular");
            string titular = Console.ReadLine();
            Console.WriteLine("Ingrese saldo");
            decimal saldo = decimal.Parse(Console.ReadLine());
            CuentaBancaria NuevaCuenta = new CuentaBancaria(numero,titular,saldo);
            return NuevaCuenta;
        }

        static void Opcion2(CuentaBancaria NuevaCuenta)
        {
            Console.WriteLine("Ingrese el monto a depositar");
            decimal monto=decimal.Parse(Console.ReadLine());
            NuevaCuenta.Depositar(monto);
        }

        static void Opcion3(CuentaBancaria NuevaCuenta)
        {
            Console.WriteLine("Ingrese el monto a extraer");
            decimal monto=decimal.Parse(Console.ReadLine());

            NuevaCuenta.Extraer(monto);

        }

        static void Opcion4(CuentaBancaria NuevaCuenta)
        {
            Console.WriteLine("El saldo de la cuenta es" + NuevaCuenta.Getsaldo()); 
        }
    }
}
