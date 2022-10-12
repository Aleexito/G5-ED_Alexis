using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class Lista
    {
        private Nodo inicio = new Nodo();
        private Nodo final = new Nodo();

        public Lista()
        {
            inicio = null;
            final = null;
        }

        public void agregarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato al nuevo Nodo: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = null;
                inicio.Anterior = null;
                final = inicio;
            }
            else
            {
                final.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = final;
                final = nuevo;
            }
            Console.WriteLine("\nNodo ingresado correctamente.");
        }

        public void mostrarListaIF()
        {
            Nodo actual = new Nodo();
            actual = inicio;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Siguiente;
            }
        }

        public void mostrarListaFI()
        {
            Nodo actual = new Nodo();
            actual = final;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Anterior;
            }
        }
    }
}
