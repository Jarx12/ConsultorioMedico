using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    class SeUDO
    {
        //Atributos
        Paciente? persona;
        Recepcion guachiman;
        Infgen pasante;
        Consultorio medico;
        //10 Colas, 5 para adultos, 5 para niños, c/u con 4 colas para las emergencias
        Cola cp0a, cp1a, cp2a, cp3a, cp4a, cp0n, cp1n, cp2n, cp3n, cp4n;
        Cola[] filaadultos;
        Cola[] filapediatria;
        //Constructor
        public SeUDO() 
        {
            guachiman = new Recepcion();
            pasante = new Infgen();
            medico = new Consultorio();
            cp0a = new Cola(); 
            cp1a = new Cola();
            cp2a = new Cola();
            cp3a = new Cola();
            cp4a = new Cola();
            cp0n = new Cola();
            cp1n = new Cola();
            cp2n = new Cola();
            cp3n = new Cola();
            cp4n = new Cola();
            filaadultos = new Cola[] { cp0a, cp1a, cp2a, cp3a, cp4a };
            filapediatria = new Cola[] { cp0n, cp1n, cp2n, cp3n, cp4n };
        }
        //Metodos
        public void roger() 
        {
            int i=0;
            bool salir = false;
            Console.WriteLine("Bienvenido");
            while (!salir)
            {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Seleccione la Opcion que desea");
            Console.WriteLine("1: Insertar Paciente en Cola");
            Console.WriteLine("2: Atender Paciente");
            Console.WriteLine("3: Reporte de Colas");
            Console.WriteLine("4: Insertar Paciente en Cola (Nombre y Cedula Random)");
            Console.WriteLine("5: Salir del Sistema");
                try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Excepcion en la aplicacion " + ex);
            }
            Console.WriteLine("Se escribio " + i);
            Console.Clear();

                switch (i)
                {
                    case 1: //Se insertara un paciente, su edad y prioridad seran generadas al azar durante el proceso
                        guachiman.insertaren(filaadultos, filapediatria);
                        break;
                    case 2: //Se atendera a una cola de niño o a una de adultos al azar
                        if (guachiman.Seudob() == 1)
                            medico.Atendera(filaadultos);
                        else
                            medico.Atenderp(filapediatria);
                        break;
                    case 3: //Se generara un reporte de todas las colas y sus pacientes
                        pasante.Generarreporte(filaadultos, filapediatria);
                        break;
                    case 4: //Insertar seleccionando al azar todos los datos del paciente (para hacer pruebas rapido)
                        guachiman.insertarenrandom(filaadultos, filapediatria);
                        break;
                    case 5://Autoevidente
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Usted ha introducido una opcion invalida, verifique e intente nuevamente");
                        break;
                }
            }
            
        }
    }
}
