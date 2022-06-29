using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionTDA
{
    internal class ListaSimple : IListaSimple
    {
        private Nodo PrimerElemento;
        private Nodo UltimoElemento;
        private int CantidadDeElementos;

        public ListaSimple()
        {
            PrimerElemento = null;
            UltimoElemento = null;
            CantidadDeElementos = 0;
        }

        public void ActualizarElemento(Nodo nodo, int posicion)
        {
            int numeroElemento = 1;
            Nodo Actual = PrimerElemento;

            while (Actual != null)
            {
                if (numeroElemento == posicion)
                {
                    Actual.SetDato(nodo.GetDato());
                }
                numeroElemento++;
                Actual = Actual.GetElementoSiguiente();
            }
        }

        //Ejemplo
        //Elementos por agregar 24, 36, 40, 60
        //      Primero                                                             Ultimo                                                           
        //       Nodo1 = 24            Nodo2 = 36              Nodo3 = 40           Nodo4 = 60
        //       Nodo1.Sig = Nodo2      Nodo2.Sig = Nodo3        Nodo3.Sig = Nodo4     Nodo4.Sig = null

        //       primero = Nodo1          ultimo = Nodo4
        //       primero.sig = Nodo2       ultimo.sig = null    



        public void AgregarElemento(Nodo nodo)
        {
            if (EstaVacia())
            {
                PrimerElemento = nodo;
                PrimerElemento.SetDatoElementoSiguiente(null);
                UltimoElemento = nodo;             
            }
            else
            {

                UltimoElemento.SetDatoElementoSiguiente(nodo);
                nodo.SetDatoElementoSiguiente(null);
                UltimoElemento= nodo;
            }
            CantidadDeElementos++;
        }

        public void EliminarElemento(int posicion)
        {
            if(posicion == 1)
            {
                PrimerElemento = PrimerElemento.GetElementoSiguiente();
            } 
            else if(posicion == CantidadDeElementos)
            {
                int numeroElemento = 1;
                Nodo Actual = PrimerElemento;

                while (Actual != null)
                {
                    if (numeroElemento == posicion-1)
                    {
                        Actual.SetDatoElementoSiguiente(null);
                    }
                    numeroElemento++;
                    Actual = Actual.GetElementoSiguiente();
                }
            }
            else
            {
                int numeroElemento = 1;
                Nodo Actual = PrimerElemento;

                while (Actual != null)
                {
                    if (numeroElemento == posicion-1)
                    {
                        Nodo Siguiente = Actual.GetElementoSiguiente();
                        Actual.SetDatoElementoSiguiente(Siguiente.GetElementoSiguiente());
                    }
                    numeroElemento++;
                    Actual = Actual.GetElementoSiguiente();
                }
            }

            CantidadDeElementos--;
        }

        public int ObtenerTamanio()
        {
            return CantidadDeElementos;
        }

        public Nodo RecuperarElemento(int posicion)
        {
            int numeroElemento = 1;
            Nodo Actual = PrimerElemento;

            while (Actual != null)
            {
                if (numeroElemento == posicion)
                {
                    return Actual;
                }
                numeroElemento++;
                Actual = Actual.GetElementoSiguiente();
            }
            return null;
        }
        

        private bool EstaVacia()
        {
            return CantidadDeElementos == 0;
        }
    }
}
