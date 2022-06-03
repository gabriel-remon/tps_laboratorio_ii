﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Productos
{
    public class producto
    {
        protected decimal precio;
        protected int cantidadStock;
        protected int cantidadVendidos;
        protected int cantidadEstandar;
        protected int codigo;
        protected string descripcion;

        public producto(int codigo, string descripcion, decimal precio, int cantidadStock, int cantidadEstandar)
        {
            this.precio = precio;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.cantidadStock = cantidadStock;
            this.cantidadVendidos = 0;
            this.cantidadEstandar = cantidadEstandar;
        }

        public producto (producto producto, int cantidadVendidos)
            :this(producto.codigo,producto.descripcion,producto.precio,producto.cantidadStock,producto.cantidadEstandar)
        {
            this.cantidadVendidos = cantidadVendidos;
        }

        public decimal SubTotal
        {
            get
            {
                return this.cantidadVendidos * this.precio;
            }
        }

        //public static producto RealizarVenta(producto producto, int cantidadVentas)
        //{
        //    return new producto(producto, cantidadVentas);
        //}
        public override string ToString()
        {
            return $"{codigo}  {descripcion} {precio.ToString("D")} c/u";
        }

        public virtual string MostrarVenta()
        {
            return $"{codigo}  {descripcion} {precio}$ {cantidadVendidos * precio}$ ";
        }

        public static bool operator ==(producto p1, producto p2)
        {
            return p1.codigo == p2.codigo;
        }
        public static bool operator !=(producto p1, producto p2)
        {
            return !(p1 == p2);
        }

    }
}
