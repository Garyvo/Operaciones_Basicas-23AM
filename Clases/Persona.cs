using Ejericio1.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }


        public void PedirDatos()
        {
            Console.WriteLine("Registra tus datos para hacer las operaciones");

            Console.WriteLine("Ingresa tu Nombre");
            this.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido");
            this.Apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu Carrera");
            this.Carrera = Console.ReadLine();

            Console.WriteLine("Ingresa tu Edad");
            this.Edad = int.Parse(Console.ReadLine());

            Console.Clear();

            if (Edad > 18)
            {
                Menu menu = new Menu();
                menu.Opciones();
            }
            else { Console.WriteLine("No tienes edad suficiente"); }

        }
        public void ImprimirD()
        {
            Console.WriteLine(".......................................................");

            Console.WriteLine("Tu nombres es: " + Nombre);
            Console.WriteLine("Tu apellido es: " + Apellido);
            Console.WriteLine("Tu carrera es: " + Carrera);
            Console.WriteLine("Tu edad es: " + Edad);
        }
    }
}
