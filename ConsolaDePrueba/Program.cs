using ConsolaDePrueba.Clases;
using System;

namespace ConsolaDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente { Id = 1, IBS = 2080, Cedula = "04171522117", Nombre = "Juan Aragán" };

            Console.WriteLine("Hola Mundo");
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.Read();
        }
    }
}
