using System.Globalization;
using System.Runtime.CompilerServices;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string opText = "";
                string num1Text = "";
                string num2Text = "";
                int op = 0;
                int num1 = 0;
                int num2 = 0;

                do
                {
                    Console.WriteLine("****************");
                    Console.WriteLine("***Seleccione una opcion***");
                    Console.WriteLine("1- Sumar");
                    Console.WriteLine("2- Restar");
                    Console.WriteLine("3- Multiplicar");
                    Console.WriteLine("4- Dividir");
                    Console.WriteLine("5- Calcular el resto");
                    Console.WriteLine("6- Salir");
                    Console.WriteLine("****************");
                    opText = Console.ReadLine();
                    try
                    {
                        op = Int32.Parse(opText);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Formato no valido");
                        //throw;
                    }
                }
                while (op < 1 || op > 6);
                try
                {
                    if (op != 6)
                    {
                        Console.WriteLine("Numero1: ");
                        num1Text = Console.ReadLine();
                        Console.WriteLine("Numero2: ");
                        num2Text = Console.ReadLine();
                        num1 = Int32.Parse(num1Text);
                        num2 = Int32.Parse(num2Text);
                    }
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Suma de " + num1 + " y " + num2 + ":");
                            Console.WriteLine(num1 + num2);
                            break;
                        case 2:
                            Console.WriteLine("Resta de " + num1 + " y " + num2 + ":");
                            Console.WriteLine(num1 - num2);
                            break;
                        case 3:
                            Console.WriteLine("Multiplicación de " + num1 + " y " + num2 + ":");
                            Console.WriteLine(num1 * num2);
                            break;
                        case 4:
                            Console.WriteLine("División de " + num1 + " y " + num2 + ":");
                            Console.WriteLine(num1 / num2);
                            break;
                        case 5:
                            Console.WriteLine("Resto de " + num1 + " y " + num2 + ":");
                            Console.WriteLine(num1 % num2);
                            break;
                        case 6:
                            Console.WriteLine("Muchas gracias por usar esta calculadora:");
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Se ha producido un error");
                    //throw;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Se ha producido un error");
                //throw
            }
        }
    }
}