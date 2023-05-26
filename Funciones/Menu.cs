using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ejericio1.Funciones
{
    public class Menu
    {

       public void Opciones()
        {
            Console.WriteLine("Ingresa una de las opciones");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Conversion divisas");
            int opcion= int.Parse(Console.ReadLine());

            Console.Clear();


            Operaciones operacion = new Operaciones();

            switch (opcion)
            {

                case 1:
                    {
                        Console.WriteLine("Ingresa el primer valor");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el tercer valor");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el cuarto valor");
                        int num4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el quinto valor");
                        int num5 = int.Parse(Console.ReadLine());

                        int total = operacion.suma(num1, num2, num3, num4, num5);

                        Console.Clear();

                        Console.WriteLine("El resultado de tu suma es: " + total);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Ingresa el primer valor");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor");
                        int num2 = int.Parse(Console.ReadLine());

                        int total = operacion.resta(num1, num2);

                        Console.Clear();

                        Console.WriteLine("El resultado de tu resta es: " + total);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Ingresa el primer valor");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor");
                        int num2 = int.Parse(Console.ReadLine());

                        int total = operacion.multi(num1, num2);

                        Console.Clear();

                        Console.WriteLine("El resultado de tu multiplicacion es: " + total);
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Ingresa el primer valor");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor");
                        int num2 = int.Parse(Console.ReadLine());

                        int total = operacion.dividir(num1, num2);

                        Console.Clear();

                        Console.WriteLine("El resultado de tu division es: " + total);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("(1)Dolar a pesos");
                        Console.WriteLine("(2)Pesos a dolar");
                        int v = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el monto");
                        double num1 = int.Parse(Console.ReadLine());
                        double total = operacion.conver(num1, v);

                        Console.Clear();

                        Console.WriteLine("El resultado de tu conversion es: " + total);
                    }
                    break;

                default:
                    Console.WriteLine("No valido");
                    break;
            }

        }

        
    }
}
