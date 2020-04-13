using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
 * string DecimalBinario(double). Convierte un número de entero a binario. 
 * double BinarioDecimal(string). Convierte un número binario a entero. 
*/

namespace Ejercicio_Nro_13
{
    class Ejercicio_13
    {
        static void Main()
        {
            int numero=137;
            string binario= "10001101";
            string num1;
            int num2;

            num1 = Conversor.DecimalBinario(numero);
            num2 = Conversor.BinarioDecimal(binario);

            Console.WriteLine("{0} Decimal equivale a {1} binario", numero, num1);
            Console.WriteLine("{0} Binario equivale a {1} decimal", binario, num2);

            Console.Read();

        }
    }
}
