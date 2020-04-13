using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_06
{
    /*
     * Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
     * trabajadas en el mes de N empleados de una fábrica.  
        Se pide calcular el importe a cobrar teniendo en cuenta que el total
        (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
        hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
        y al total de todas esas operaciones restarle el 13% en concepto de descuentos. 
        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
        el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de
        todos los empleados ingresados. Nota: Utilizar estructuras repetitivas y selectivas. 
 
    */
    class Ejercicio_06
    {
        static void Main()
        {
            int anio;

            Console.Write("\nIngrese un año: ");

            anio = Int32.Parse(Console.ReadLine());

            if (anio==2020)
            {
                Console.Write("El año actual el 2020 es año bisiesto");
            }


            if ((anio % 4 == 0) && ((anio % 100 != 0) || (anio % 400 == 0)))
            {
                if (anio<2020)
                {
                    Console.Write("El año {0} fue año bisiesto", anio);
                }
                else if (anio!=2020)
                {
                    Console.Write("El año {0} va a ser año bisiesto", anio);
                }
            }
            else
            {
                if (anio < 2020)
                {
                    Console.Write("El año {0} no fue año bisiesto", anio);
                }
                else
                {
                    Console.Write("El año {0} no va a ser año bisiesto", anio);
                }
            }

            Console.Read();

        }
    }
}
