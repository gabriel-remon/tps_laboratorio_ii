using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Productos;
using Biblioteca.Personas;
using Biblioteca.DTO;

namespace Biblioteca
{
    public class Venta
    {
        List<Producto> productos;
        DateTime fechaCompra;
        Cliente comprador;
        bool ventaRealizada;

        public  Venta()
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

        public Venta(List<Producto> productos, DateTime fechaCompra, Cliente comprador, bool ventaRealizada)
        {
            this.productos = productos;
            this.fechaCompra = fechaCompra;
            this.comprador = comprador;
            this.ventaRealizada = ventaRealizada;
        }



        #region Propiedades
        public Cliente Comprador
        {
            get
            {
                return this.comprador;
            }
            set
            {
                this.comprador= value;
            }

        }
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
        }

        #endregion

        public static void RealizarVenta(Venta venta)
        {
            venta.ventaRealizada=true;
        }

        public static List<Venta> VentasPendiente(List<Venta> ventas)
        {
            List<Venta> listaFiltrada = new List<Venta>();

            foreach(Venta unaVenta in ventas)
            {
                if(unaVenta.ventaRealizada==false)
                    listaFiltrada.Add(unaVenta);
            }

            return listaFiltrada;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de la compra: {fechaCompra.ToString("d")}");
            foreach (Producto unProducto in this.productos)
            {
                sb.AppendLine(unProducto.MostrarVenta());
            }
            sb.AppendLine($"Total de la venta: {this.Total()}");

            return sb.ToString();            
        }

        public string Total()
        {
            decimal total = 0;

            foreach(Producto unProducto in productos)
            {
                total  +=unProducto.SubTotal;
            }

            return total.ToString();
        }

        public VentaDto CrearDto()
        {
            VentaDto ventaDto = new VentaDto();
            List<ProductoDto>  productosDto = new List<ProductoDto>();

            ventaDto.Comprador = this.comprador.CrearDto();
            ventaDto.FechaCompra = this.fechaCompra;
            ventaDto.VentaRealizada = this.ventaRealizada;
            
            foreach(Producto unProducto in this.productos)
            {
                productosDto.Add(unProducto.CrearDto());
            }
            ventaDto.Productos = productosDto;

            return ventaDto;
        }

        public Producto BuscarProducto(Producto producto)
        {
            foreach(Producto item in this.productos)
            {
                if(producto==item)
                {
                    return item;
                }
            }
            return null;
        }

        #region SobrecargaOperadores
        public static bool operator == (Venta venta , Usuarios persona)
        {
            return venta.comprador == persona;
        }

        public static bool operator !=(Venta venta, Usuarios persona)
        {
            return !(venta.comprador == persona);
        }

        public static Venta operator +(Venta v, Producto p)
        {
            if(p is not null)
            {
                if(v==p)
                {
                    v.productos.Remove(v.BuscarProducto(p));
                }
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

        public override string ToString()
        {
            return $"Cliente: {this.comprador}  -- total venta: {this.Total()}";
        }

        #endregion
    }
}
