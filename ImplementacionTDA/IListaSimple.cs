using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionTDA
{
    internal interface IListaSimple
    {
        //a) Agregar elemento 
        void AgregarElemento(Nodo nodo);

        //b) Modificar elemento 
        void ActualizarElemento(Nodo nodo, int posicion);


        //c) Recuperar elemento
        Nodo RecuperarElemento(int posicion);


        //d) Eliminar elemento
        void EliminarElemento(int posicion);


        //e) Obtener la cantidad de elementos
        int ObtenerTamanio();
    }
}
