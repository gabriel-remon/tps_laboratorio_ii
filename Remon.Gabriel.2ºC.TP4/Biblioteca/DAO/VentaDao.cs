using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DTO;

namespace Biblioteca.DAO
{
    public class VentaDao
    {
        public static Venta CrearOriginal(VentaDto ventaDto)
        {
            Venta cliente = new Venta(productos: ProductoDao.CrearOriginal(ventaDto.Productos)
                                    , fechaCompra: ventaDto.FechaCompra
                                    , comprador: ClienteDao.CrearOriginal(ventaDto.Comprador)
                                    , ventaRealizada: ventaDto.VentaRealizada);

            return cliente;
        }

        public static List<Venta> CrearOriginal(List<VentaDto> ventasDto)
        {
            List<Venta> ventasList = new List<Venta>();

            foreach (VentaDto item in ventasDto)
            {
                ventasList.Add(VentaDao.CrearOriginal(item));
            }

            return ventasList;
        }
    }
}
