using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// setea el parametro numero pasando por valor un string
        /// y tambien verifica que el string pueda convertirse en un double
        /// </summary>
        private string Numero
        {
            set
            {
                numero= ValidarOperando(value);
            }
        }

        /// <summary>
        /// covierte un numero binario a un decima y de no ser posible retorna "Valor Invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna un string el cual contiene un decimal o un "Valor invalido" (string)</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            double decimalAux = 0;
            int posicion = binario.Length;

            if(EsBinario(binario))
            {
                foreach(var digito in binario)
                {
                    posicion--;
                    if(digito == '1')
                    {
                        decimalAux = decimalAux + Math.Pow(2, posicion);
                    }

                }
                retorno = Convert.ToString(decimalAux);
            }

            return  retorno;
        }

        /// <summary>
        /// transforma un numero decimal a un numero binario y de no se posible
        /// retorna "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna un numero binario en forma de string o "Valor invalido"(string)</returns>
        public string DecimalBinario(double numero)
        {
            string retorno = string.Empty;

            numero = (ulong) Math.Abs(numero);

            do
            {
                if((numero % 2 )== 0)
                {
                    retorno = "0" + retorno;
                }
                else
                {
                    retorno = "1" + retorno;
                    numero--;
                }
                numero = numero / 2;

            } while (numero != 0);

            return retorno;
        }

        /// <summary>
        /// transforma un numero decimal a un numero binario y de no se posible
        /// retorna "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna un numero binario en forma de string o "Valor invalido"(string)</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";

            double numeroAux;

            if(double.TryParse(numero,out numeroAux))
            {
                retorno = DecimalBinario(numeroAux); 
            }

            return retorno;
        }

        /// <summary>
        /// valida que el string ingresado corresponda a un numero bianrio
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> true, si es binario  y false, si no es binario</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach(var digito in binario)
            {
                if(digito != '1' && digito != '0' )
                {
                    retorno = false;
                    break; 
                }
            }

            return retorno;
        }

        /// <summary>
        /// constructor del objeto operandor inicializa el campo numero en 0
        /// </summary>
        public Operando() : this(0)
        {
            
        }

        /// <summary>
        /// constructor del objeto Operandor, inicializa el campo numero con el parametro ingresado
        /// </summary>
        /// <param name="numero">parametro que sera cargado en el campo Operandor.Numero</param>
        public Operando( double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// constructor del objeto Operando, transforma el string ingresado a double y lo guarda en 
        /// Operando.numero de no ser posible guarda el valor 0 en Operando.numero
        /// </summary>
        /// <param name="strNumero">string del numero que se desea guardar</param>
        public Operando(string strNumero): this()
        {
            double.TryParse(strNumero, out numero);
        }

        /// <summary>
        /// sobrecarga el operador "-" para que reste los dos campos numeros de dos objetos
        /// tipo Operando y retorna el resultado
        /// </summary>
        /// <param name="n1">primer objeto</param>
        /// <param name="n2">segundo objeto</param>
        /// <returns>retorna el resustado de la operacion en forma de double </returns>
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga el operador "*" para que multplique los dos campos numeros de dos objetos
        /// tipo Operando y retorna el resultado
        /// </summary>
        /// <param name="n1">primer objeto</param>
        /// <param name="n2">segundo objeto</param>
        /// <returns>retorna el resustado de la operacion en forma de double </returns>
        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// sobrecarga el operador "/" para que divide los dos campos numeros de dos objetos
        /// tipo Operando y retorna el resultado. si el n2.numero=0 retorna double.MinValue
        /// </summary>
        /// <param name="n1">primer objeto</param>
        /// <param name="n2">segundo objeto</param>
        /// <returns>retorna el resustado de la operacion en forma de double </returns>
        public static double operator / (Operando n1, Operando n2)
        {
            double retorno = double.MinValue;

            if(n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }

            return retorno;
        }

        /// <summary>
        /// sobrecarga el operador "+" para que sume los dos campos numeros de dos objetos
        /// tipo Operando y retorna el resultado.
        /// </summary>
        /// <param name="n1">primer objeto</param>
        /// <param name="n2">segundo objeto</param>
        /// <returns>retorna el resustado de la operacion en forma de double </returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// valida que el string ingresado se pueda transformar a un elemento double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> 0 si no se puede convertir y sino el numero convertido </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);

            return retorno;
        }

    }
}
