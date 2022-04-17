using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
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
