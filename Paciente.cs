using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    class Paciente
    {
        //Atributos
        string nombre, cedula;
        int edad, prioridad; 
        //Constructor
        public Paciente(string nick, string dni, int años, int pri) 
        {
            this.nombre = nick;
            this.cedula = dni;
            this.edad = años;
            this.prioridad = pri;
        }
        //Metodos
        public void setnombre(string apodo) 
        {
            this.nombre = apodo;
        }
        public void setcedula(string codigo) 
        {
            this.cedula = codigo;
        }
        public void setedad(int hist)
        {
            this.edad = hist;
        }
        public void setpriordad(int emerg) 
        {
            this.prioridad = emerg;
        }
        public string getnombre()
        {
            return nombre;
        }
        public string getcedula() 
        {
            return cedula;
        }
        public int getedad() 
        {
            return edad;
        }
        public int getprioridad() 
        {
            return prioridad;
        }
    }
}
