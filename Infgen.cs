using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    internal class Infgen
    {
        //Atributos

        //Constructor
        public Infgen() 
        {

        }
        //Metodos
        public void Generarreporte(Cola[] filaadulto, Cola[] filapediatrica) 
        {
            Console.WriteLine("Modulo de Reporte");
            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
            Console.WriteLine("");
            Console.WriteLine("Colas de Adultos");
            Reporta(filaadulto);
            Console.WriteLine("");
            Console.WriteLine("--- Fin de Colas de Adultos ---");
            Console.WriteLine("");
            Console.WriteLine("Colas de Niños");
            Reporta(filapediatrica);
            Console.WriteLine("");
            Console.WriteLine("--- Fin de Colas de Niños ---");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
            Console.WriteLine("--- Fin de Modulo de Reporte ---");
        }
        private void Reporta(Cola[] fila) //Reporte de colas bajo los principios de las colas usando cola auxiliar
        {
            Cola aux = new Cola();
            Paciente? persaux = null;
            for (int i = 0; i < fila.Length; i++) //Controlando la prioridad por proceso
            {
                while (fila[i].getTamano() > 0) //Mientras no se haya vaciado la cola desencolar, leer y encolar en una cola auxiliar
                {
                    persaux = (Paciente?)fila[i].Desencolar();
                    if (persaux != null)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Paciente Nº: " + (aux.getTamano() + 1) +" de la cola "+ i);
                        Console.WriteLine("Nombre: " + persaux.getnombre());
                        Console.WriteLine("Cedula: " + persaux.getcedula());
                        Console.WriteLine("Edad: " + persaux.getedad());
                        Console.WriteLine("Prioridad: " + persaux.getprioridad());
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("");
                        aux.Encolar(persaux);
                    }
                }
                while (aux.getTamano() > 0) //Mientras la cola auxiliar no se haya vaciado desencolar y encolar en la cola origina
                {
                    persaux = (Paciente?)aux.Desencolar();
                    if (persaux != null)
                        fila[i].Encolar(persaux);
                }
            }
        }
    }
}
