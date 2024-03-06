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
        string[] prioridades = { "Accidente Aparatoso", "Infarto", "Afeccion Respiratoria", "Parto", "No es urgente" };
        //Constructor
        public Consultorio() 
        {

        }
        //Metodos
        public void Atendera(Cola[] filaadultos) //Se recorre el arreglo de colas desde la mas prioritario (0) hasta la menos prioritaria (4) hasta atender 1 paciente
        {
            Console.WriteLine("Modulo de Atencion para Adultos");
            Atender(filaadultos);
        }
        public void Atenderp(Cola[] filapediatria)
        {
            Console.WriteLine("Modulo de Atencion Pediatrico");
            Atender(filapediatria);
        }
        private void Atender(Cola[] fila) 
        {
            for (int i = 0; i < fila.Length; i++)
            {
                if (!fila[i].Vacia())
                {
                    Paciente? persona;
                    persona = (Paciente?)fila[i].Desencolar();
                    if (persona != null)
                    {
                        Console.WriteLine("Se atendera al siguiente paciente");
                        Console.WriteLine("Nombre: " + persona.getnombre());
                        Console.WriteLine("Cedula: " + persona.getcedula());
                        Console.WriteLine("Edad: " + persona.getedad());
                        Console.WriteLine("Prioridad: " + persona.getprioridad() + " (" + prioridades[persona.getprioridad()] + ")");
                    }
                    break;
                }
                else
                    Console.WriteLine("No hay nadie en la cola " + i + " para atender");
            }
        }
    }
}
