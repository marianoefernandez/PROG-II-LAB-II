using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Program
    {
        static void Main()
        {
            Sello.mensaje = "Hola mundo";

            Sello.Imprimir();
           
            //Sello.Borrar();

            Sello.Imprimir();

            Sello.mensaje = "Hola mundo";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.Read();
            
        }
    }
}
