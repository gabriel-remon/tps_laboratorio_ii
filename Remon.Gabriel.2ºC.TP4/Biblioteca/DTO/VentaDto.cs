using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Personas;

namespace Biblioteca.DTO
{
    public class VentaDto
    {
        List<ProductoDto> productos;
        DateTime fechaCompra;
        Clientedto comprador;
        bool ventaRealizada;


        #region Propiedades
        public List<ProductoDto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        public Clientedto Comprador
        {
            get
            {
                return this.comprador;
            }
            set
            {
                this.comprador = value;
            }
        }

        public bool VentaRealizada { get => ventaRealizada; set => ventaRealizada = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }

        #endregion


    }
}
