using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DTO
{
    public class ProductoDto
    {
        protected decimal precio;
        protected int cantidadStock;
        protected int cantidadEstandar;
        protected int cantidadVendidos;
        protected int codigo;
        protected string descripcion;

        #region Propiedades

        public decimal Precio
        {
            get
            {
                return this.precio;
            }
            set
            {

                this.precio = value;
                
            }
        }
        public int CantidadStock
        {
            get
            {
                return this.cantidadStock;
            }
            set
            {

                this.cantidadStock = value;
            }
        }

        public int CantidadEstandar
        {
            get
            {
                return this.cantidadEstandar;
            }
            set
            {
                this.cantidadEstandar = value;
            }
        }

        public int CantidadVendidos
        {
            get
            {
                return this.cantidadVendidos;
            }
            set
            {
                this.cantidadVendidos = value;
            }
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        #endregion
    }
}
