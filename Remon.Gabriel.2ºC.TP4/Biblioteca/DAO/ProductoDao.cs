using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Productos;
using Biblioteca.DTO;


namespace Biblioteca.DAO
{
    public class ProductoDao
    {
        public static Producto CrearOriginal(ProductoDto productoDto)
        {
            Producto cliente = new Producto( new Producto(codigo: productoDto.Codigo
                                          , descripcion: productoDto.Descripcion
                                          , precio: productoDto.Precio
                                          , cantidadStock: productoDto.CantidadStock
                                          , cantidadEstandar: productoDto.CantidadEstandar)
                                          , cantidadVendidos:productoDto.CantidadVendidos);

            return cliente;
        }

        public static List<Producto> CrearOriginal(List<ProductoDto> productosDto)
        {
            List<Producto> productoList = new List<Producto>();

            foreach (ProductoDto item in productosDto)
            {
                productoList.Add(ProductoDao.CrearOriginal(item));
            }

            return productoList;
        }
    }
}
