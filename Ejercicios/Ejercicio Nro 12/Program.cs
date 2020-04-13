using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Realizar un programa que sume números enteros hasta que el usuario lo determine, 
 *  por medio de un mensaje "¿Continuar? (S/N)". En el método estático ValidaS_N(char c) de la clase 
 *  ValidarRespuesta, se validará el ingreso de opciones. El método devolverá un valor de tipo booleano,
 *  TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. 
*/

namespace Ejercicio_Nro_12
{
    class Ejercicio_12
    {
        static void Main()
        {
            int numero;
            int acumulador=0;
            char continuar;
            bool validarContinuar;

            Console.Write("Ingrese un numero: ");
            numero = Int32.Parse(Console.ReadLine());
            acumulador += numero;

            Console.Write("\n¿Desea continuar? (S/N): ");
            continuar = Convert.ToChar(Console.Read());
            Char.ToUpper(continuar);
            validarContinuar = ValidarRespuesta.ValidaS_N(continuar);

            while (validarContinuar == false)
            {
                Console.Write("Ingrese un numero: ");
                numero = Int32.Parse(Console.ReadLine());
                acumulador += numero;

                Console.Write("\n¿Desea continuar? (S/N): ");
                continuar = Convert.ToChar(Console.Read());
                Char.ToUpper(continuar);
                validarContinuar = ValidarRespuesta.ValidaS_N(continuar);
            }

            Console.Write("\nLa suma total es de: {0}", acumulador);
            Console.Read();
        }
    }
}
