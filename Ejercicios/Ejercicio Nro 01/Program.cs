using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_01
{
	class Ejercicio_01
	{
		static void Main()
		{
			int numero;
			float promedio;
			int acumulador=0;
			int min=0;
			int max=0;
			int i;

			for (i = 0; i < 5; i++)
			{
				Console.Write("\nIngrese un numero: ");

				numero =  Int32.Parse(Console.ReadLine());

				if (i==0)
				{
					min = numero;
					max = numero;
				}

				if (numero < min)
				{
					min = numero;
				}

				if (numero > max)
				{
					max = numero;
				}

				acumulador += numero;
			}

			promedio = (float)(acumulador / 5.0);

			Console.Write("El maximo es: {0} \nEl minimo es {1} \nEl promedio es {2}", max, min, promedio);

			Console.ReadLine();
		}
	}
}
