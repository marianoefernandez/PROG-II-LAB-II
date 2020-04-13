using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {

            MiClase.estatico = 15;

            MiClase obj;
            MiClase obj2;


            obj = new MiClase();

            obj.noEstatico = 55;

            obj2 = new MiClase();

            obj2.noEstatico = 88;

            MiClase.estatico = 77;

            obj.cambiarValorEstatico(9);

            obj2.cambiarValorEstatico(8);

            MiClase obj3;

            obj3 = obj;

            obj3.noEstatico = 44;

            MiClase.MostrarEstatico(obj);

            Console.Read();

            



        }
    }
}
