using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Productos
{
    public class Producto
    {
        protected decimal precio;
        protected int cantidadStock;
        protected int cantidadVendidos;
        protected int cantidadEstandar;
        protected int codigo;
        protected string descripcion;

        public Producto(int codigo, string descripcion, decimal precio, int cantidadStock, int cantidadEstandar)
        {
            this.precio = precio;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidadStock = cantidadStock;
            this.cantidadVendidos = 0;
            this.cantidadEstandar = cantidadEstandar;
        }

        public Producto (Producto producto, int cantidadVendidos)
            :this(producto.codigo,producto.descripcion,producto.precio,producto.cantidadStock,producto.cantidadEstandar)
        {
            this.cantidadVendidos = cantidadVendidos;
        }

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

        //public static producto RealizarVenta(producto producto, int cantidadVentas)
        //{
        //    return new producto(producto, cantidadVentas);
        //}

     
        public override string ToString()
        {
            //return $"{codigo.ToString()}  {descripcion}  c/u";
            return $"codigo: {codigo.ToString()}    {descripcion}    {precio.ToString("C")} c/u";
        }

        public virtual string MostrarVenta()
        {
            return $"{codigo}  {descripcion} {precio}$ {cantidadVendidos * precio}$ ";
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.codigo == p2.codigo;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
