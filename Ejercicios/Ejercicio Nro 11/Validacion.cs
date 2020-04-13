namespace Ejercicio_Nro_11
{
    public class Validacion
    {
        public static bool Validar(int valor,int min,int max)
        {
            bool retorno;

            if (valor > max || valor < min)
            {
                retorno = false;
            }
            else
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
