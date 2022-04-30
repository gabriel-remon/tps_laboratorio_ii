using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Constructores"

        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) 
            : base(chasis, marca, color) { }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR\n");
            sb.AppendLine((string)this);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
