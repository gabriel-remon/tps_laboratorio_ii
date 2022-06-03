using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Productos;

namespace Biblioteca
{
    public static class Venta
    {
        public static producto RealizarVenta(producto producto, int cantidadVentas)
        {
            return new producto(producto, cantidadVentas);
        }

        public static Caños RealizarVenta(Caños producto, int cantidadVentas)
        {
            return new Caños(producto, cantidadVentas);
        }
    }
}
