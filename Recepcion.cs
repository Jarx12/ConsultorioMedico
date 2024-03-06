using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsultorioMedico
{
    class Recepcion
    {
        //Atributos
        Random akinator = new Random();
        //Constructor
        public Recepcion()
        {

        }
        //Metodos
        public void insertaren(Cola[] filaadultos, Cola[] filapediatria) //Inserta un paciente consultando, nombre y cedula, generando al azar edad y prioridad
        {
            Paciente pac;
            string? nombre, cedula;
            int edad, prioridad;
            nombre = null;
            cedula = null;
            do
            {
                Console.Write("Introduzca el nombre del paciente:");
                try
                {
                    nombre = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Excepcion en la aplicacion " + ex);
                }
            } 
            while (nombre == null);
            Console.WriteLine("");
            do
            {
                Console.Write("Introduzca la cedula del paciente:");
                try
                {
                    cedula = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Excepcion en la aplicacion " + ex);
                }
            }
            while (cedula == null);
            Console.WriteLine("");
            /*
              Criterios de Recepcion 
                Edad<=15 Niño, Edad>15=Adulto 
                Prioridad 0=Accidentes Aparatosos, 1=Infartos, 2=Afecciones Respiratorias, 3=Partos, 4=No es urgencia
            */
            edad = akinator.Next(0, 121);//Rango de generacion de edad establecido entre 0 y 120 años
            prioridad = akinator.Next(0, 5); //Rango de generacion de prioridades establecido de 0 a 4
            pac = new Paciente(nombre, cedula, edad, prioridad);
            if (pac.getedad() > 15) //Cola de Adultos
            {
                Console.WriteLine("Se insertara al paciente adulto");
                Insertar(filaadultos, pac);
            }
            else //Cola de Pediatria
            {
                Console.WriteLine("Se insertara al paciente pediatrico");
                Insertar(filapediatria, pac);
            }
        }
        public void insertarenrandom(Cola[] filaadultos, Cola[] filapediatria) //Inserta un paciente usando datos aleatorios de una lista y generando al azar edad y prioridad
        {
            Paciente pac;
            string? nombre, cedula;
            int edad, prioridad;
            nombre = null;
            cedula = null;
            string[] listan = { "Alejandro", "David", "Javier", "Manuel", "Antonio", "José", "Francisco", "Juan", "Carlos", "Jesús", "Sofía", "María", "Lucía", "Paula", "Daniela", "Carla", "Sara", "Marta", "Claudia", "Elena", "Valentina", "Camila", "Gabriela", "Mariana", "Luciana", "Julieta", "Valentina", "Isabella", "Emilia", "Valeria", "Antonella", "Abril", "Jimena", "Sofía", "Catalina", "Natalia", "Camila", "Florencia", "Mía", "Emma", "Olivia", "Amelia", "Matilde" };
            string[] listanp = { "García", "Rodríguez", "González", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martín", "Jiménez", "Díaz", "Hernández", "Ramírez", "Ruiz", "Alonso", "Navarro", "Bravo", "Castro", "Mendoza", "Ortiz", "Flores", "Ramos", "Cruz", "Moreno", "Romero", "Soria", "Vargas", "Aguilar", "Medina", "León", "Vega", "Gutiérrez", "Fuentes", "Peña", "Ortega", "Serrano", "Blanco", "Nieto", "Molina" };
            string[] listac = { "12345678", "87654321", "43210987", "76543210", "11111111", "22222222", "33333333", "44444444", "912345678", "456789012", "12345678", "87654321", "43210987", "76543210", "98765432", "10000001", "10000002", "10000003", "10000004", "10000005", "11111111", "22222222", "33333333", "44444444", "55555555", "1492", "1789", "1945", "1969", "2001", "912345678", "654321098", "789456123", "456789012", "321098765" };
            Console.WriteLine("");
            nombre = listan[akinator.Next(0, 35)]+ " " + listanp[akinator.Next(0, 35)]; //Escoge un nombre al azar de la lista
            cedula = listac[akinator.Next(0, 35)]; //Escoge una cedula al azar de la lista
            /*
              Criterios de Recepcion 
                Edad<=15 Niño, Edad>15=Adulto 
                Prioridad 0=Accidentes Aparatosos, 1=Infartos, 2=Afecciones Respiratorias, 3=Partos, 4=No es urgencia
            */
            edad = akinator.Next(0, 121);//Rango de generacion de edad establecido entre 0 y 120 años
            prioridad = akinator.Next(0, 5); //Rango de generacion de prioridades establecido de 0 a 4
            pac = new Paciente(nombre, cedula, edad, prioridad);
            if (pac.getedad() > 15) //Cola de Adultos
            {
                Console.WriteLine("Se insertara al paciente adulto");
                Insertar(filaadultos, pac);
            }
            else if (pac.getedad()<=15)//Cola de Pediatria
            {
                Console.WriteLine("Se insertara al paciente pediatrico");
                Insertar(filapediatria, pac);
            }
        }
        private void Insertar(Cola[] fila, Paciente pac) 
        {
            Console.Write("Nombre: " + pac.getnombre());
            Console.WriteLine("");
            Console.Write("Cedula: " + pac.getcedula());
            Console.WriteLine("");
            Console.Write("Edad: " + pac.getedad());
            Console.WriteLine("");
            Console.Write("Prioridad: " + pac.getprioridad());
            Console.WriteLine();
            fila[pac.getprioridad()].Encolar(pac);
        }
        public int Seudob()
        {
            return akinator.Next(0, 2); //Retorna 0 o retorna 1
        }
    }
}
