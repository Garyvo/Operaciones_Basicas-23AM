using System;
using Ejericio1.Clases;

namespace Ejericio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.PedirDatos();
            persona.ImprimirD();
        }
    }
}
