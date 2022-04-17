using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion matematica de del objeto num1 y num2 tomando en cuenta el
        /// campo operador como el operador matematico y si el caracter operador es distinto a 
        ///  + - / * entonces suma por defecto
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns> retorna el resultado de la operacion (double)</returns>
        public static double Operar (Operando num1, Operando num2, char operador)
        {
            double retorno = 0;

            switch(Calculadora.ValidarOperador(operador))
            {
                case '+':
                    retorno = num1 + num2;
                    break;

                case '-':
                    retorno = num1 - num2;
                    break;

                case '*':
                    retorno = num1 * num2;
                    break;

                case '/':
                    retorno = num1 / num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// valia el operador y si es invalido retorna +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>char del operador </returns>
       private static char ValidarOperador( char operador)
        {
            char retorno = operador;

            if(operador != '*'  && operador != '/' && operador != '-')
            {
                retorno = '+';
            }

            return retorno;
                
        }

    }
}
