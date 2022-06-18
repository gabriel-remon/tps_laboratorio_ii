using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DTO
{
    public class FerreteriaDto
    {

        List<Clientedto> clientes;
        List<EmpleadoDto> empleados;
        List<ProductoDto> productosStock;
        List<VentaDto> ventas;
        string nombreFerreteria;
        public FerreteriaDto()
        {
            this.clientes = new List<Clientedto>();
            this.empleados = new List<EmpleadoDto>();
            this.productosStock = new List<ProductoDto>();
            this.ventas= new List<VentaDto>();
        }

        public List<Clientedto> Clientes { get => clientes; set => clientes = value; }
        public List<EmpleadoDto> Empleados { get => empleados; set => empleados = value; }
        public List<ProductoDto> ProductosStock { get => productosStock; set => productosStock = value; }
        public List<VentaDto> Ventas { get => ventas; set => ventas = value; }
        public string NombreFerreteria { get => nombreFerreteria; set => nombreFerreteria = value; }
    }
}
