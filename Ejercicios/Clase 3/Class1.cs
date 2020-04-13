using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class MiClase
    {
        public static int estatico;
        public int noEstatico;

        public MiClase()
        {
            this.noEstatico = 7;
        }

        public void cambiarValorEstatico(int valor) //No es estatico este modulo
        {
            MiClase.estatico = valor;

            this.noEstatico = valor;
        }

        public static void MostrarEstatico(MiClase param)
        {
            Console.WriteLine(MiClase.estatico);

            Console.WriteLine(param.noEstatico);//Desde un metodo estatico no puedo mostrar no estaticos
        }
    }
}
