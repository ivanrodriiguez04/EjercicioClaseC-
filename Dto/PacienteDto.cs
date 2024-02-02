using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase.Dto
{
    /// <summary>
    /// Clase donde se van a almacenar toda la informacion del paciente
    /// irodhan -> 30/01/2024 
    /// </summary>
    internal class PacienteDto
    {
        //Atributos
        long idPaciente;
        string dniPaciente = "aaaaa";
        string nombrePaciente = "aaaaa";
        string apellidosPaciente = "aaaaa";
        string nombreCompletoPaciente = "aaaaa";
        int edadPaciente = 0;
        string fechAltaPaciente = "31/12/9999 11:59:59";

        //Constructores
        public PacienteDto()
        {
        }

        public PacienteDto(long idPaciente, string dniPaciente, string nombrePaciente, string apellidosPaciente, string nombreCompletoPaciente, int edadPaciente, string fechAltaPaciente)
        {
            this.idPaciente = idPaciente;
            this.dniPaciente = dniPaciente;
            this.nombrePaciente = nombrePaciente;
            this.apellidosPaciente = apellidosPaciente;
            this.nombreCompletoPaciente = nombreCompletoPaciente;
            this.edadPaciente = edadPaciente;
            this.fechAltaPaciente = fechAltaPaciente;
        }



        //Getters & Setters
        public long IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string ApellidosPaciente { get => apellidosPaciente; set => apellidosPaciente = value; }
        public string NombreCompletoPaciente { get => nombreCompletoPaciente; set => nombreCompletoPaciente = value; }
        public int EdadPaciente { get => edadPaciente; set => edadPaciente = value; }
        public string FechAltaPaciente { get => fechAltaPaciente; set => fechAltaPaciente = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }

        //Metodo ToString
        override
        public string ToString() 
        {
            nombreCompletoPaciente = nombrePaciente + " " + apellidosPaciente;
            string concatenacion= "Nombre completo: "+this.NombreCompletoPaciente+"\tDNI:"+this.DniPaciente+
                "\tEdad: "+this.EdadPaciente+"\tFecha del alta: "+this.FechAltaPaciente;
            return concatenacion;
        }


    }
}
