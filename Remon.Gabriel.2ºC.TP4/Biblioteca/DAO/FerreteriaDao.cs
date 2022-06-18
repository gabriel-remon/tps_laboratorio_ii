using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DTO;
using Biblioteca.Personas;

namespace Biblioteca.DAO
{
    public class FerreteriaDao
    {
        //FerreteriaDto ferreteriaDto;

        public static FerreteriaDto CrearFerreteriaDto(Ferreteria ferreteria)
        {
            FerreteriaDto ferreteriaDto = new FerreteriaDto();

            foreach(Cliente item in ferreteria.Clientes)
            {
                ferreteriaDto.Clientes.Add(item.CrearDto());
            }

            foreach (Empleado item in ferreteria.Empleados)
            {
                ferreteriaDto.Empleados.Add(item.CrearDto());
            }

            foreach (Productos.Producto item in ferreteria.Productos)
            {
                ferreteriaDto.ProductosStock.Add(item.CrearDto());
            }

            foreach (Venta item in ferreteria.Ventas)
            {
                ferreteriaDto.Ventas.Add(item.CrearDto());
            }

            return ferreteriaDto;
        }

        public static Ferreteria CrearOriginal(FerreteriaDto ferreteriaDto)
        {
            Ferreteria ferreteria = new Ferreteria(clientes: ClienteDao.CrearOriginal(ferreteriaDto.Clientes)
                                                   ,empleados: EmpleadoDao.CrearOriginal(ferreteriaDto.Empleados)
                                                   ,productosStock: ProductoDao.CrearOriginal(ferreteriaDto.ProductosStock)
                                                   ,ventas: VentaDao.CrearOriginal(ferreteriaDto.Ventas)
                                                   ,nombre: ferreteriaDto.NombreFerreteria);

            return ferreteria;
        }

    }
}
