using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionTDA
{
    internal class Nodo
    {
        private int Dato;
        private Nodo ElementoSiguiente;

        public Nodo(int dato, Nodo elementoSiguiente)
        {
            Dato = dato;
            ElementoSiguiente = elementoSiguiente;
        }

        public Nodo(int dato)
        {
            Dato = dato;
            ElementoSiguiente = null;
        }

        public void SetDato(int Dato)
        {
            this.Dato = Dato;
        }

        public int GetDato()
        {
            return Dato;
        }

        public void SetDatoElementoSiguiente(Nodo ElementoSiguiente)
        {
            this.ElementoSiguiente = ElementoSiguiente;
        }

        public Nodo GetElementoSiguiente()
        {
            return ElementoSiguiente;
        }


    }
}
