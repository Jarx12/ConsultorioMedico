using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    class Consultorio
    {
        //Atributos

        //Constructor
        public Consultorio() 
        {

        }
        //Metodos
        public void Atendera(Cola[] filaadultos) //Se recorre el arreglo de colas desde la mas prioritario (0) hasta la menos prioritaria (4) hasta atender 1 paciente
        {
            Console.WriteLine("Modulo de Atencion para Adultos");
            for (int i = 0; i < filaadultos.Length; i++)
            {
                if (!filaadultos[i].Vacia())
                {
                    Paciente? persona;
                    persona = (Paciente?)filaadultos[i].Desencolar();
                    if (persona != null)
                    {
                        Console.WriteLine("Se atendera al siguiente paciente");
                        Console.WriteLine("Nombre: " + persona.getnombre());
                        Console.WriteLine("Cedula: " + persona.getcedula());
                        Console.WriteLine("Edad: " + persona.getedad());
                        Console.WriteLine("Prioridad: " + persona.getprioridad());
                    }
                    break;
                }
                else
                    Console.WriteLine("No hay nadie en la cola " + i + " para atender");
            }
        }
        public void Atenderp(Cola[] filapediatria)
        {
            Console.WriteLine("Modulo de Atencion Pediatrico");
            for (int i = 0; i < filapediatria.Length; i++)
            {
                if (!filapediatria[i].Vacia())
                {
                    Paciente? persona;
                    persona = (Paciente?)filapediatria[i].Desencolar();
                    if (persona != null) 
                    {
                        Console.WriteLine("Se atendera al siguiente paciente");
                        Console.WriteLine("Nombre: " + persona.getnombre());
                        Console.WriteLine("Cedula: " + persona.getcedula());
                        Console.WriteLine("Edad: " + persona.getedad());
                        Console.WriteLine("Prioridad: " + persona.getprioridad());
                    }
                    break;
                }
                else
                    Console.WriteLine("No hay nadie en la cola " + i + " para atender");
            }
        }

    }
}
