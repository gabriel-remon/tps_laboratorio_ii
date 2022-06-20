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
    public class AgregarProductoStockTest
    {
        [TestMethod]
        public void AgregarProductoNuevo_EnFerreteria_SeEsperaQueSeAgregue()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1,"tuerca",1,1,1);
            //act
            ferreteria.AgregarProductoStock(producto);
            bool expecter = true;
            bool actual = ferreteria == producto;
            //assert
            Assert.AreEqual(expecter, actual);
        }
        [TestMethod]
        public void AgregarProductoExistente_EnFerreteria_SeEsperaQuNoeSeAgregue()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Producto producto = new Producto(1, "tuerca", 1, 1, 1);
            //act
            ferreteria.AgregarProductoStock(producto);
            ferreteria.AgregarProductoStock(producto);
            int expecter = 2;
            int actual = ferreteria.Productos.Count;
            //assert
            Assert.AreNotEqual(expecter, actual);
        }
    }
}
//arranq
//act
//assert