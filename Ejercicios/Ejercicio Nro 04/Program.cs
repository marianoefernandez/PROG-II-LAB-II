    using System;

    namespace Ejercicio_Nro_04
{
    class Ejercicio_04
    {
        static void Main()
        {
            int acumuladorResto;
            int j;
            int i;

            for (i = 1; i <= 2147483647; i++)
            {
                acumuladorResto = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        acumuladorResto += j;
                    }
                }
                if (acumuladorResto == i)
                    Console.WriteLine("El numero {0} es perfecto", i);
            }
            Console.ReadKey();
        }
    }
}
