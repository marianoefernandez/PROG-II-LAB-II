using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno;

            Char.ToUpper(c);


            if (c == 'S')
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
