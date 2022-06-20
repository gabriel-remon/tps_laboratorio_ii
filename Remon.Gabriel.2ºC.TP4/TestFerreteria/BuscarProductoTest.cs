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
    public class BuscarProductoTest
    {
        [TestMethod]
        public void BuscarProductoPorId_EnFerreteria_SeEsperaDescripcionDelProducto()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 1, 1);
            ferreteria.AgregarProductoStock(producto);
            //act
            string actual = ferreteria.BuscarProducto(1);
            string expected = producto.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuscarProductoPorId_EnFerreteria_SeEsperaNoExiste()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 1, 1);
            ferreteria.AgregarProductoStock(producto);
            //act
            string actual = ferreteria.BuscarProducto(202020);
            string expected = "No existe un producto con ese codigo";
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
