using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos)
 * que realicen el cálculo del área que corresponda:
 * a. double CalcularCuadrado(double) 
 * b. double CalcularTriangulo(double, double) 
 * c. double CalcularCirculo(double)
 * El ingreso de los datos como la visualización se deberán realizar desde el método Main(). 
*/

namespace Ejercicio_Nro_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double trianguloBase;
            double trianguloAltura;
            double areaTriangulo;
            double cuadradoLado;
            double areaCuadrado;
            double radioCirculo;
            double areaCirculo;

            Console.Write("\nIngrese un lado del cuadrado(cm): ");
            cuadradoLado = Double.Parse(Console.ReadLine());

            Console.Write("\nIngrese la base del triagulo(cm): ");
            trianguloBase = Double.Parse(Console.ReadLine());

            Console.Write("\nIngrese la altura del triagulo(cm): ");
            trianguloAltura = Double.Parse(Console.ReadLine());

            Console.Write("\nIngrese el radio del circulo(cm): ");
            radioCirculo = Double.Parse(Console.ReadLine());

            areaCuadrado = CalculoDeArea.CalcularCuadrado(cuadradoLado);
            areaTriangulo = CalculoDeArea.CalcularTriangulo(trianguloBase, trianguloAltura);
            areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);

            Console.Write("\nEl area del cuadrado es de {0} cm", areaCuadrado);
            Console.Write("\nEl area del triangulo es de {0} cm", areaTriangulo);
            Console.Write("\nEl area del circulo es de {0:.##} cm", areaCirculo);
            Console.Read();

        }
    }
}
