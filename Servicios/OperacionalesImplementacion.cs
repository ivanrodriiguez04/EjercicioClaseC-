using EjercicioClase.Dto;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la lista
    /// irodhan -> 31/01/2024
    /// </summary>
    internal class OperacionalesImplementacion : OperacionalesInterfaz
    {
        public void agregarPaciente(List<PacienteDto> listaPacientesAntigua)
        {
            PacienteDto nuevoPaciente = crearPaciente();
            listaPacientesAntigua.Add(nuevoPaciente);
        }
        /// <summary>
        /// Metodo que pide al usuario la informacion necesaria del paciente
        /// irodhan -> 30/01/2024
        /// </summary>
        /// <returns></returns>
        private PacienteDto crearPaciente() 
        { 
            PacienteDto paciente = new PacienteDto();
            Console.WriteLine("Introduzca el id del paciente:");
            paciente.IdPaciente=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el dni del paciente:");
            paciente.DniPaciente = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del paciente:");
            paciente.NombrePaciente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del paciente:");
            paciente.ApellidosPaciente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del paciente:");
            paciente.EdadPaciente=Convert.ToInt32(Console.ReadLine());
            DateTime fechaActual=DateTime.Now;
            fechaActual.ToString("yy - MM - ddThh:mm: ss.ms");
            paciente.FechAltaPaciente=fechaActual.ToString();
            return paciente;
        }

        public void borrarPaciente(List<PacienteDto> listaPacientesAntigua)
        {
            string dni = pedirDNI();
            PacienteDto pacienteBuscado = new PacienteDto();
            foreach (PacienteDto paciente in listaPacientesAntigua) 
            {
                if (paciente.DniPaciente.Equals(dni))
                {
                    Console.WriteLine("[INFO] - El dni ha sido encontrado");
                    pacienteBuscado = paciente;
                    break;
                }
                else 
                {
                    Console.WriteLine("[INFO] - El dni no ha sido encontrado");
                }
            }
            listaPacientesAntigua.Remove(pacienteBuscado);
        }
        /// <summary>
        /// Metodo que pide el dni para poder borrarlo de la lista
        /// irodhan -> 30/01/2024
        /// </summary>
        /// <returns></returns>
        private string pedirDNI() 
        {
            Console.WriteLine("Intrduzca el dni del paciente que desea borrar:");
            string dni=Console.ReadLine();
            return dni;
        }
        public void mostrarPacientes(List<PacienteDto> listaPacientesAntigua)
        {
            foreach (PacienteDto paciente in listaPacientesAntigua) 
            {
                 Console.WriteLine(paciente.ToString());
            }
        }
    }
}
