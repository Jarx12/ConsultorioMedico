using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    class Cola
    {
        //Atributos
        protected const int max = 20;
        protected Nodo? frente, final;
        protected int tamano;
        //Constructor
        public Cola()
        {
            final = null;
            frente = null;
            tamano = 0;
        }
        //Metodos
        public bool Vacia()
        {
            return (frente == null);
        }
        public void Encolar(object o) //Recibe un objeto lo encapsula en un nodo y lo integra a la cola
        {
            if (tamano<max) 
            { 
                Nodo nuevonodo; 
                nuevonodo = new Nodo(o,null);
                if(Vacia()) 
                {
                    frente = nuevonodo;
                    final = nuevonodo;
                    tamano++;
                }
                else
                {
                    final?.Setsiguiente(nuevonodo); //Final no deberia ser null llegado a este else pero por si llegara a serlo se declara el '?'
                    final = nuevonodo;
                    tamano++;
                }
            }
            else 
            {
                Console.WriteLine("ERROR CAPACIDAD MAXIMA DE LA COLA ALCANZADA");
            }
        }
        public object? Desencolar() //Desencapsula un objeto de un nodo, lo retorna y saca a dicho nodo de la cola
        {
            if (Vacia())
            {
                Console.WriteLine("Error, Cola Vacia");
                Console.ReadLine();
                return null;
            }
            else 
            {
                object? postback=null;
                if (frente!=null && frente == final) //Si hay un solo elemento; Frente no deberia ser null pero por prevencion
                {
                    postback = frente.Getobjeto();
                    frente = null;
                    final = null;
                    tamano--;
                    return postback;
                }
                else
                {
                    if(frente!=null) //Mas de un elemento en la cola; Frente no deberia ser null pero para evitar warnings
                    {
                        postback = frente.Getobjeto();
                        frente = frente.Getsiguiente();
                    }
                tamano--;                
                return postback;
                }
            }

        }
        public int getTamano()
        {
            return tamano;
        }       
    }
}
