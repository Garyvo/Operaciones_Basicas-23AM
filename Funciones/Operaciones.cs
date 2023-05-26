using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1.Funciones
{
    public class Operaciones
    {
        public int num1, num2;

        #region
        /* public void ssuma()
         {
             Console.WriteLine("Ingresa un numero");
             num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingresa otro numero");
             num2 = int.Parse(Console.ReadLine());


             Console.WriteLine($"El resultado es {num1+num2}");
         }
        */

        #endregion

        public int suma(int num1, int num2, int num3, int num4, int num5)
        {
            int total = num1 + num2 + num3 + num4 + num5;
            return total;

        }

        public int resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multi(int num1, int num2)
        {
            return num1 * num2;
        }

        public int dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public double conver(double num1, int v)
        {
            if (v == 2)
            {

                num1 = num1 / 17.50;
                return num1;
            }
            else
            {
                if (v == 1)
                {
                    num1 = num1 * 17.50;
                    return num1;
                }
            }
            return 0;
        }
            

        }
    }


