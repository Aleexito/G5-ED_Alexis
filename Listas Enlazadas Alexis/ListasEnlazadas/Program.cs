using ListasEnlazadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista L1 = new Lista();
            L1.agregarNodo();
            L1.agregarNodo();
            L1.agregarNodo();
            L1.agregarNodo();
            L1.agregarNodo();
            Console.Clear();
            Console.WriteLine("Los datos ingresados son:");
            Console.WriteLine("\n Del inicio al final");
            L1.mostrarListaIF();

            Console.WriteLine("\n Del final al inicio)");
            L1.mostrarListaFI();
            Console.ReadLine();
        }
    }
}