using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    class Ejercicio_11
    {
        static void Main()
        {
            int numero;
            int max=0;
            int min=0;
            float promedio;
            int acumulador=0;
            int i;


            for (i=0;i<10;i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = Int32.Parse(Console.ReadLine());
                while (Validacion.Validar(numero,-100,100)==false)
                {
                    Console.Write("ERROR SOLO INGRESE NUMEROS ENTRE -100 y 100 Ingrese un numero nuevamente: ");
                    numero = Console.Read();
                }

                if(i==0)
                {
                    max = numero;
                    min = numero;
                }

                if(numero > max)
                {
                    max = numero;
                }

                if (numero < min)
                {
                    min = numero;
                }

                acumulador += numero;

            }
            promedio = (float)(acumulador / 10.0);

            Console.Write("El maximo es: {0} \nEl minimo es {1} \nEl promedio es {2}", max, min, promedio);

            Console.Read();
        }
    }
}
