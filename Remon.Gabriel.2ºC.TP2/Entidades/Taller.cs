using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor,
            Sedan,
            SUV,
            Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tenemos {taller.vehiculos.Count} lugares ocupados de un " +
                          $"total de {taller.espacioDisponible} disponibles\n");

            foreach (Vehiculo unVehiculo in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Sedan:
                        if (unVehiculo is Sedan)
                            sb.AppendLine(unVehiculo.Mostrar());
                        break;

                    case ETipo.SUV:
                        if (unVehiculo is Suv)
                            sb.AppendLine(unVehiculo.Mostrar());
                        break;

                    case ETipo.Ciclomotor:
                        if (unVehiculo is Ciclomotor)
                            sb.AppendLine(unVehiculo.Mostrar());
                        break;

                    default:
                        sb.AppendLine(unVehiculo.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (taller.vehiculos.Count < taller.espacioDisponible)
            {
                foreach (Vehiculo unVehiculo in taller.vehiculos)
                {
                    if (unVehiculo == vehiculo)
                        return taller;
                }
                taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo unVehiculo in taller.vehiculos)
            {
                if (unVehiculo == vehiculo)
                {
                    taller.vehiculos.Remove(unVehiculo);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
