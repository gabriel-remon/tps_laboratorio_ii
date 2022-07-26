using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"

        /// <summary>
        /// Inicializa todos los parametos del vehiculo
        /// </summary>
        /// <param name="chasis">Codigo del chasis</param>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="color">Color del vehiculo</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        { }

        #endregion

        #region "Metodos"

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Retorna como un string todos los datos del vehiculo Suv
        /// </summary>
        /// <returns>Todos los datos del objeto</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine((string)this);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
