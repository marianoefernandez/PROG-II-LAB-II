using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_05
{
    class Ejercicio_05
    {
        static void Main()
        {
            int contNumeros = 1;
            int numero;
            int i;

            Console.Write("\nIngrese un numero: ");

            numero = Int32.Parse(Console.ReadLine());


            bool flag = true;

            while (flag)
            {

                for (i = 2; i <= contNumeros; i++)
                {

                    if ((2 * (i * i)) == ((contNumeros * contNumeros) + contNumeros))
                    {

                        if (i > numero)
                        {

                            flag = false;
                            break;

                        }
                        else
                        {

                            Console.Write("\nEntre 1 y {0} el centro numerico es {1}", contNumeros, i);

                        }

                    }

                }
                contNumeros++;

            }

            if (numero < 6)
            {
                Console.Write("\nNo hay centros númericos con numeros menores al 6");
            }

            Console.Read();
        }
    }
}
