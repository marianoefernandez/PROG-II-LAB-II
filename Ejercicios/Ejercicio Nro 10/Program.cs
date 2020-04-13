using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_10
{
    class Ejercicio_10
    {
        static void Main()
        {
            int altura;
            int lineaActual;
            int espacios;
            int asteriscos;

            Console.Write("Ingrese la altura max: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (lineaActual = 1; lineaActual < altura+1; lineaActual++)
            {
                for (espacios = 0; espacios < altura - lineaActual; espacios++)
                {
                    Console.Write(" ");
                }
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
