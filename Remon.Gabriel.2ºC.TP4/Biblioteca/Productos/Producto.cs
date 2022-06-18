using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Biblioteca.DTO;

namespace Biblioteca.Productos
{
    [XmlInclude(typeof(Tornillos))]
    [XmlInclude(typeof(Caños))]
    public class Producto
    {
        protected decimal precio;
        protected int cantidadStock;
        protected int cantidadEstandar;
        protected int cantidadVendidos;
        protected int codigo;
        protected string descripcion;

        public Producto()
            :this(0,String.Empty,0,0,0)
        {

        }

        public Producto(int codigo, string descripcion, decimal precio, int cantidadStock, int cantidadEstandar)
        {
            this.precio = precio;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidadStock = cantidadStock;
            //this.cantidadVendidos = 0;
            this.cantidadEstandar = cantidadEstandar;
        }

        public Producto (Producto producto, int cantidadVendidos)
            :this(producto.codigo,producto.descripcion,producto.precio,producto.cantidadStock,producto.cantidadEstandar)
        {
            if(cantidadVendidos > producto.cantidadStock)
            {
                throw new Exception($"No hay stock, hay {producto.cantidadStock} productos");
            }
            this.cantidadVendidos = cantidadVendidos;

        }

        #region Propiedades

        public decimal Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (value > 0)
                {
                    this.precio = value;
                }
                else
                {
                    throw new Exception("Error, Solo se puede ingresar valores positivos");
                }
            }
        }
        public int Stock
        {
            get
            {
                return this.cantidadStock;
            }
            set
            {
                if (value >= 0)
                {
                    this.cantidadStock = value;
                }
                else
                {
                    throw new Exception("Error, Solo se puede ingresar valores positivos");
                }
            }
        }

        public int CantidadEstandar
        {
            get
            {
                return this.cantidadEstandar;
            }
            set
            {
                if(value >= 0)
                    this.cantidadEstandar = value;
            }
        }

        public int StockFaltante
        {
            get
            {
                return  this.cantidadEstandar - this.cantidadStock;
            }
        }

        public int CantidadVendidos
        {
            get
            {
                return this.cantidadVendidos;
            }
        }
        public decimal SubTotal
        {
            get
            {
                return this.cantidadVendidos * this.precio;
            }
            
        }
        public int Id
        {
            get
            {
                return this.codigo;
            }
     
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }

        }

        #endregion
       
        public override string ToString()
        {
            //return $"{codigo.ToString()}  {descripcion}  c/u";
            return $"codigo: {codigo.ToString()}    {descripcion}    {precio.ToString("C")} c/u";
        }

        public virtual string MostrarVenta()
        {
            return $"codigo:{codigo},  {descripcion}   {precio}$c/u --- sub total: {cantidadVendidos * precio}$ ";
        }

        public ProductoDto CrearDto()
        {
            ProductoDto productoDto = new ProductoDto();

            productoDto.Precio = this.precio;
            productoDto.Codigo = this.codigo;
            productoDto.Descripcion = this.descripcion;
            productoDto.CantidadStock = this.cantidadStock;
            productoDto.CantidadVendidos = this.cantidadVendidos;
            productoDto.CantidadEstandar = this.cantidadEstandar;

            return productoDto;
        }

        #region SobrecargaOperadores
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.codigo == p2.codigo;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
