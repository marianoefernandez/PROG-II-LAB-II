using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_03
{
    class Ejercicio_03
    {
        static void Main()
        {
            int numero;
            byte flag = 0;
            int j;
            int i;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Los primos son: ");
            if (numero > 1)
            {
                for (i = 2; i <= numero; i++)
                {
                    for (j = i; j >= 1; j--)
                    {
                        if (i % j == 0)
                        {
                            flag++;
                        }
                    }
                    if (flag == 2)
                    {
                        Console.Write("\n{0}", i);
                    }
                    flag = 0;
                }
            }
            Console.Read();
        }
    }
}