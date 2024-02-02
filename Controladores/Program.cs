using EjercicioClase.Dto;
using EjercicioClase.Servicios;

namespace EjercicioClase.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion 
    /// irodhan -> 30/01/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicacion 
        /// irodhan -> 30/01/2024
        /// </summary>
        static void Main(string[] args)
        {
            //LIstas
            List<PacienteDto> listaPacientes = new List<PacienteDto>();

            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            OperacionalesInterfaz oL = new OperacionalesImplementacion();
            //Atributos
            int opcionSeleccionada = 0;
            bool cerrarMenu=false;

            while (!cerrarMenu) 
            {
                opcionSeleccionada=mI.mostrarMenuYSeleccion();
                
                switch (opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion cerrar menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion agregar un nuevo paciente");
                        oL.agregarPaciente(listaPacientes);
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion de borrar un paciente");
                        oL.borrarPaciente(listaPacientes);
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion mostrar clientes");
                        oL.mostrarPacientes(listaPacientes);
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;
                }
            }

        }
    }
}
