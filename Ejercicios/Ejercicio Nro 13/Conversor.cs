using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string cadena = "";

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
            }
            else
            {
                cadena = "No se admiten numeros menores a cero";
            }

            return cadena;
        }

        static public int BinarioDecimal(string numero)
        {
            char[] cadena = numero.ToCharArray();
            // Reverse since 16-8-4-2-1 not 1-2-4-8-16. 
            Array.Reverse(cadena);
            /*
             * [0] = 1
             * [1] = 2
             * [2] = 4
             * etc
             */
            int suma = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    {
                        suma += 1;
                    }
                    else
                    {
                        suma += (int)Math.Pow(2, i);
                    }
                }

            }

            return suma;
        }
    }
}
