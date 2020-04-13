using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    public class Sello
    {
        public static string mensaje;

        public static ConsoleColor color;


        public static string Imprimir()
        {
            ArmarFormatoMensaje();
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            ArmarFormatoMensaje();
            Console.ForegroundColor = color;
        }

        private static string ArmarFormatoMensaje()
        {
            int i;

            Console.Write("\n");

            for (i=0;i< Sello.mensaje.Length+2; i++) 
            {
                Console.Write("*");
            }

            Console.Write("\n*{0}*\n", Sello.mensaje);

            for (i = 0; i < Sello.mensaje.Length + 2; i++)
            {
                Console.Write("*");
            }

            return Sello.mensaje;
        }
    }
}
