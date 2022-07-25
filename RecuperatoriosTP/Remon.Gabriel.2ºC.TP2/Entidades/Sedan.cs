using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }

        private ETipo tipo;

        #region "Constructores"

        /// <summary>
        /// Inicializa todos los parametros del vehiculo con los valores
        /// que fueron pasados como parametro
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) 
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Inicializa todos los parametos del vehiculo y define al enumerado 
        /// ETipo como cuatro puestas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
                    : this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// Retorna como un string todos los datos del vehiculo Sedan
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN\n");
            sb.Append((string)this);
            sb.AppendLine($"TIPO : {this.tipo}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
