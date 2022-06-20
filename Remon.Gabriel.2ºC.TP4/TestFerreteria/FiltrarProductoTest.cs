using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Personas;
using Biblioteca.Productos;
using Biblioteca;
namespace TestFerreteria
{
    [TestClass]
    public class FiltrarProductoTest
    {
        [TestMethod]
        public void BuscarCodigoProductoExistente_EnFerreteria_SeEsperaElProducto()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 3, 1);
            Producto producto2 = new Producto(2, "tuerca", 1, 1, 1);
            Producto producto3 = new Producto(3, "tuerca", 1, 1, 1);
            Producto producto4 = new Producto(4, "tuerca", 1, 1, 1);
            ferreteria.Productos.Add(producto);
            ferreteria.Productos.Add(producto2);
            ferreteria.Productos.Add(producto3);
            ferreteria.Productos.Add(producto4);

            //act
            Producto actual = ferreteria.FiltrarProductos("2")[0];
            Producto expected = producto2;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuscarCodigoProductoInexistente_EnFerreteria_NoSeEsperaElProducto()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 3, 1);
            Producto producto2 = new Producto(2, "tuerca", 1, 1, 1);
            Producto producto3 = new Producto(3, "tuerca", 1, 1, 1);
            Producto producto4 = new Producto(4, "tuerca", 1, 1, 1);
            ferreteria.Productos.Add(producto);
            ferreteria.Productos.Add(producto2);
            ferreteria.Productos.Add(producto3);
            ferreteria.Productos.Add(producto4);

            //act
            int actual = ferreteria.FiltrarProductos("32").Count;
            int expected = 0;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
