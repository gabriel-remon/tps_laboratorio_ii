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
    public class FiltrarClientesTest
    {
        [TestMethod]
        public void AlIngregarDniCliente_EnFerreteria_SeEsperaListaConClienteIgualAlDniEnviado()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Cliente cliente = new Cliente("", "", DateTime.Now, 101, "1", Cliente.SituacionFiscal.Otros);
            Cliente cliente2 = new Cliente("", "", DateTime.Now, 100, "1", Cliente.SituacionFiscal.Otros);
            Cliente cliente3 = new Cliente("", "", DateTime.Now, 111, "1", Cliente.SituacionFiscal.Otros);
            ferreteria.Clientes.Add(cliente);
            ferreteria.Clientes.Add(cliente2);
            ferreteria.Clientes.Add(cliente3);

            //act
            Usuarios actual = ferreteria.FiltrarClientes("111")[0];
            Usuarios expected = cliente3;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AlIngregarDniClienteNoExistente_EnFerreteria_SeEsperaListaVacia()
        {
            //arranq
            Ferreteria ferreteria = new Ferreteria();
            Cliente cliente = new Cliente("", "", DateTime.Now, 1, "101", Cliente.SituacionFiscal.Otros);
            Cliente cliente2 = new Cliente("", "", DateTime.Now, 1, "10", Cliente.SituacionFiscal.Otros);
            Cliente cliente3 = new Cliente("", "", DateTime.Now, 1, "111", Cliente.SituacionFiscal.Otros);

            //act
            int actual = ferreteria.FiltrarClientes("1111").Count;
            int expected = 0;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
