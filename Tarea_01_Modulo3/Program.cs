using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01_Modulo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pide la fecha de nacimiento al usuario
            Console.WriteLine("Por favor, ingresa tu fecha de nacimiento (formato: dd/mm/yyyy):");
            string input = Console.ReadLine();

            // Intenta convertir la entrada a una fecha
            DateTime fechaNacimiento;
            bool esValido = DateTime.TryParse(input, out fechaNacimiento);

            if (esValido)
            {
                // Muestra el día de la semana correspondiente
                Console.WriteLine("El día de la semana en que naciste fue: " + fechaNacimiento.DayOfWeek);
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Asegúrate de usar el formato correcto.");
            }

            Console.Read();
        }
    }
}
