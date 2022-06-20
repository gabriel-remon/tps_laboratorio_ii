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
    public class AgregarPedidoTest
    {
        [TestMethod]
        public void AgregarNuevoPedido_SeEspera_DescuentoDelStock()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 3, 1);
            ferreteria.Productos.Add(producto);

            Producto producto2 = new Producto(producto,1);
            Cliente cliente = new Cliente("", "", DateTime.Now, 1, "1", Cliente.SituacionFiscal.Otros);
            Venta venta = new Venta(new List<Producto> { producto2},DateTime.Now,cliente,false);
            //act
            ferreteria.AgregarPedido(venta);
            int actual = ferreteria.Productos[0].Stock;
            int expected = 2;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AgregarNuevoPedido_SeEspera_QueSeHayaAgregadoVenta()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 3, 1);
            ferreteria.AgregarProductoStock(producto);

            Producto producto2 = new Producto(1, "tuerca", 1, 1, 1);
            Cliente cliente = new Cliente("", "", DateTime.Now, 1, "1", Cliente.SituacionFiscal.Otros);
            Venta venta = new Venta(new List<Producto> { producto2 }, DateTime.Now, cliente, false);
            //act
            ferreteria.AgregarPedido(venta);
            bool actual = ferreteria.Ventas[0] == venta ;
            bool expected = true;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
