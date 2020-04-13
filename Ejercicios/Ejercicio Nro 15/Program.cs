using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Realizar un programa que permita realizar operaciones matemáticas simples 
 * (suma, resta, multiplicación y división). Para ello se le debe pedir al usuario 
 * que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * ó /). 
 * El usuario decidirá cuándo finalizar el programa.
 * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
 * a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número 
 * y la operación matemática. El método devolverá el resultado de la operación.
 * b. Validar (privado): Recibirá como parámetro el segundo número. 
 * Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
 * Este método devolverá TRUE si el número es distinto de CERO. 
 
*/

namespace Ejercicio_Nro_15
{
    class Program
    {
        static void Main()
        {
            float numero1;
            float numero2;
            float resultado;
            char operacion;
            char continuar;

            while(continuar != 'S')
            {
                Console.Write("\nIngrese el primer numero: ");

                numero1 = Int32.Parse(Console.ReadLine()); 
                
                Console.Write("\nIngrese el segundo numero: ");

                numero2 = Int32.Parse(Console.ReadLine());

                Console.Write("\nIngrese la operación(+ - * /): ");

                operacion = Convert.ToChar(Console.Read());

                while (Calculadora.Calcular(numero1,numero2,operacion))
                {

                }
                        
            }
        }
    }
}
