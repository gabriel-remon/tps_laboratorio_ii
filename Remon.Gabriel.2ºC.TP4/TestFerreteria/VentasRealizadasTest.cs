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
    public class VentasRealizadasTest
    {
        [TestMethod]
        public void BuscaListaVentasDeCliente_EnFerreteria_EsperaRecibirListaVentasDeEseCliente()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 3, 1);
            Producto producto2 = new Producto(producto, 1);
            ferreteria.Productos.Add(producto);

            Cliente cliente = new Cliente("", "", DateTime.Now, 1, "1", Cliente.SituacionFiscal.Otros);
            Cliente cliente2 = new Cliente("", "", DateTime.Now, 12, "1", Cliente.SituacionFiscal.Otros);
            Venta venta = new Venta(new List<Producto> { producto2 }, DateTime.Now, cliente, true);
            Venta venta2 = new Venta(new List<Producto> { producto2 }, DateTime.Now, cliente2, true);
            
            //act
            ferreteria.AgregarPedido(venta);
            ferreteria.AgregarPedido(venta2);
            Usuarios actual = ferreteria.VentasRealizadas(cliente)[0].Comprador;
            Usuarios expected = cliente;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuscaListaVentasDeClienteNoExistente_EnFerreteria_EsperaNoRecibirListaVentas()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 3, 1);
            Producto producto2 = new Producto(producto, 1);
            ferreteria.Productos.Add(producto);

            Cliente cliente = new Cliente("", "", DateTime.Now, 1, "1", Cliente.SituacionFiscal.Otros);
            Cliente cliente2 = new Cliente("", "", DateTime.Now, 12, "1", Cliente.SituacionFiscal.Otros);
            Venta venta = new Venta(new List<Producto> { producto2 }, DateTime.Now, cliente, true);
            Venta venta2 = new Venta(new List<Producto> { producto2 }, DateTime.Now, cliente2, true);

            //act
            ferreteria.AgregarPedido(venta);
            int actual = ferreteria.VentasRealizadas(cliente2).Count;
            int expected = 0;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
