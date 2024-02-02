using EjercicioClase.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase.Servicios
{
    /// <summary>
    /// Interfaz de las metodos de la aplicacion
    /// irodhan -> 30/01/2024
    /// </summary>
    internal interface OperacionalesInterfaz
    {
        /// <summary>
        /// Metodo que agrega un nuevo cliente a la lista
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <param name="listaClientesAntigua"></param>
        public void agregarPaciente(List<PacienteDto> listaPacientesAntigua);

        /// <summary>
        /// Metodo que borra al paciente deseado de la lista
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <param name="listaPacientesAtigua"></param>
        public void borrarPaciente(List<PacienteDto> listaPacientesAntigua);

        /// <summary>
        /// Metodo que muestra a todos los clientes de la lista
        /// irodhan -> 31/01/2024
        /// </summary>
        /// <param name="listaPacientesAtigua"></param>
        public void mostrarPacientes(List<PacienteDto> listaPacientesAntigua);
    }
}
