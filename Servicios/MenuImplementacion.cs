using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// irodhan -> 30/01/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|                Menú               |");
            Console.WriteLine("|___________________________________|");
            Console.WriteLine("| 0. Cerrar menu                    |");
            Console.WriteLine("| 1. Agregar un nuevo paciente      |");
            Console.WriteLine("| 2. Borrar un paciente             |");
            Console.WriteLine("| 3. Mostrar pacientes              |");
            Console.WriteLine("|___________________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada;");
            opcion= Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
