using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    public class Calculadora
    {
        public static float Calcular(float num1, float num2, char operacion)
        {
            float retorno=0; 

            if(operacion == '+')
            {
                retorno = num1 + num2;
            }   
            
            if(operacion == '-')
            {
                retorno = num1 - num2;
            } 
            
            if(operacion == '*')
            {
                retorno = num1 * num2;
            }

            if (operacion == '/')
            {
                if (Validar(num2) == true)
                {
                    retorno = num1 / num2;
                }
                else
                {
                    retorno = -1;
                }   
            }

            return retorno;
        }

        private static bool Validar(float num2)
        {
            bool retorno = false;
            
            if (num2!=0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
