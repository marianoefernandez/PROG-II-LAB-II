using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_02
{
	class Ejercicio_02
	{
		static void Main()
		{
			int numero;

			Console.Write("\nIngrese un numero: ");

			numero = Int32.Parse(Console.ReadLine());

			while (numero <= 0)
			{
				Console.Write("\nERROR. ¡Reingresar número!: ");

				numero = Int32.Parse(Console.ReadLine());
			}
			Console.Write("El cuadrado es: {0} \nEl cubo es: {1}", Math.Pow(numero,2), Math.Pow(numero,3));

			Console.ReadLine();
		}
	}
}
