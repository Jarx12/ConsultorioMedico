using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    class Nodo
    {
        //Atributos
        private object o;
        private Nodo? sig;
        //Constructor
        public Nodo(object objeto, Nodo? siguiente)
        {
            this.o = objeto;
            this.sig = siguiente;
        }
        //Metodos
        public Nodo? Getsiguiente()
        {
            return sig;
        }
        public void Setsiguiente(Nodo? siguiente) 
        {
            this.sig = siguiente;
        }
        public object Getobjeto() 
        {
            return o;
        }
        public void Setobjeto(object objeto)
        { 
            this.o = objeto;
        }
    }
}
