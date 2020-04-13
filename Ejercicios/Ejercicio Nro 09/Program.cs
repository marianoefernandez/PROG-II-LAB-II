using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_09
{
    class Ejercicio_09
    {
        static void Main()
        {
            int altura;
            int lineaActual;
            int asteriscos;

            Console.Write("Ingrese la altura max: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (lineaActual = 1; lineaActual < altura+1; lineaActual++)
            {
                for (asteriscos = 0; asteriscos < (lineaActual * 2) - 1; asteriscos++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}

