using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_07
{
    /*
     * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule 
     * el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now). Nota:
     * Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. 
     */
    class Ejercicio_07
    {
        static void Main()
        {
            DateTime fechaFinal = DateTime.Now;
            DateTime fechaInicio;
            string fechaInicioStr;
            TimeSpan lapso;
            int diasPasados;

            Console.Write("Ingrese la fecha de nacimiento: ");

            fechaInicioStr = Console.ReadLine();

            while (!DateTime.TryParseExact(fechaInicioStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaInicio))
            {
                Console.WriteLine("Fecha invalida intentelo nuevamente: ");
                fechaInicioStr = Console.ReadLine();
            }

            lapso = fechaFinal - fechaInicio;
            diasPasados = lapso.Days;

            Console.Write("Pasaron {0} días entre el {1:dd/MM/yyyy} y el {2:dd/MM/yyyy}", diasPasados, fechaInicio, fechaFinal);

            Console.Read();
        }
    }
}
