using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionTDA
{
    internal class Consola
    {
        public static void Main(string[] args)
        {
            //TAD = Tipo Abstracto de Datos
            Console.WriteLine("Implementación de Estructura Lista Simple en un TAD IListaSimple");
            IListaSimple ListaSimple = new ListaSimple();
            Nodo nuevoNodo1 = new Nodo(24);
            Nodo nuevoNodo2 = new Nodo(36);
            Nodo nuevoNodo3 = new Nodo(40);
            Nodo nuevoNodo4 = new Nodo(60);
            ListaSimple.AgregarElemento(nuevoNodo1);
            ListaSimple.AgregarElemento(nuevoNodo2);
            ListaSimple.AgregarElemento(nuevoNodo3);
            ListaSimple.AgregarElemento(nuevoNodo4);

            int CantidadLista = ListaSimple.ObtenerTamanio();
            for (int i = 0; i < CantidadLista; i++)
            {
                Console.WriteLine(ListaSimple.RecuperarElemento(i+1).GetDato().ToString());
            }

            Nodo nuevoNodo = new Nodo(125);
            ListaSimple.ActualizarElemento(nuevoNodo, 4);
            Console.WriteLine("Actualizamos el elemento 4");

            for (int i = 0; i < CantidadLista; i++)
            {
                Console.WriteLine(ListaSimple.RecuperarElemento(i + 1).GetDato().ToString());
            }

            ListaSimple.EliminarElemento(3);
            Console.WriteLine("Eliminamos el elemento 3");

            CantidadLista = ListaSimple.ObtenerTamanio();
            for (int i = 0; i < CantidadLista; i++)
            {
                Console.WriteLine(ListaSimple.RecuperarElemento(i + 1).GetDato().ToString());
            }


            Console.ReadLine();        
        }
    }
}
