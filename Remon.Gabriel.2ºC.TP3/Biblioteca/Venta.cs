using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Productos;
using Biblioteca.Personas;

namespace Biblioteca
{
    public class Venta
    {
        List<Producto> productos;
        DateTime fechaCompra;
        Cliente comprador;
        bool ventaRealizada;

        private Venta()
        {
            productos = new List<Producto>();
            fechaCompra = DateTime.Now;
            ventaRealizada = false;
        }

        public Venta(Cliente comprador)
            :this()
        {
            //this.productos = new List<Producto>();
            this.comprador = comprador;
        }
        public Cliente Comprador
        {
            get
            {
                return this.comprador;
            }
        }

        public static void RealizarVenta(Venta venta)
        {
            venta.ventaRealizada=true;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de la compra: {fechaCompra.ToString("d")}");
            foreach (Producto unProducto in productos)
            {
                sb.AppendLine(unProducto.MostrarVenta());
            }
            sb.AppendLine($"Total de la venta: {this.Total()}");

            return sb.ToString();            
        }

        private string Total()
        {
            decimal total = 0;

            foreach(Producto unProducto in productos)
            {
                total = +unProducto.SubTotal;
            }

            return total.ToString();
        }

        public static bool operator == (Venta venta , Persona persona)
        {
            return venta.comprador == persona;
        }

        public static bool operator !=(Venta venta, Persona persona)
        {
            return !(venta.comprador == persona);
        }

        public static Venta operator +(Venta v, Producto p)
        {
            if(p is not null)
            {
               
                v.productos.Add(p);
            }
            return v;
        }
        public static bool operator ==(Venta v, Producto p)
        {
            foreach(Producto unProducto in v.productos)
            {
                if(unProducto == p)
                {

                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Venta v, Producto p)
        {
            return !(v==p);
        }
    }
}
