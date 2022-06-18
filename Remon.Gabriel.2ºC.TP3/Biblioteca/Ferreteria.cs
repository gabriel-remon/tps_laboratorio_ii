using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Personas;
using Biblioteca.Productos;


namespace Biblioteca
{
    public class Ferreteria
    {
        List<Persona> clientes;
        List<Persona> empleados;
        List<Persona> proveedores;
        List<Producto> productosStock;
        List<Venta> ventas;

        public Ferreteria()
        {
            this.clientes = new List<Persona>();
            this.proveedores = new List<Persona>();
            this.productosStock = new List<Producto>();
            this.ventas = new List<Venta>();
            this.empleados = new List<Persona>();
        }

        public Ferreteria(List<Persona> clientes, List<Persona> empleados, List<Persona> proveedores,
                        List<Producto> productosStock, List<Venta> ventas)
        {
            this.clientes = clientes;
            this.empleados = empleados;
            this.proveedores = proveedores;
            this.productosStock = productosStock;
            this.ventas = ventas;
        } 

        public bool AgregarProductoStock(Producto producto)
        {
            if(this != producto)
            {
                this.productosStock.Add(producto);
                return true;
            }

            return false;
        }

        public string BuscarProducto(int codigo)
        {
           foreach(Producto producto in this.productosStock)
           {
                if(producto.Id == codigo)
                {
                    return producto.ToString();
                }
           }

            return "No existe un producto con ese codigo";
        }

        public List<Producto> FiltrarProductos(string codigo)
        {
            List<Producto> listFiltrada = new List<Producto>();

            foreach(Producto producto in this.productosStock)
            {

                if(producto.Id.ToString().Contains(codigo) )
                     listFiltrada.Add(producto);
            }

            return listFiltrada;
        }
        public List<Persona> FiltrarClientes(string codigo)
        {
            List<Persona> listFiltrada = new List<Persona>();

            foreach (Persona unaPersona in this.clientes)
            {

                if (unaPersona.Dni.ToString().Contains(codigo))
                    listFiltrada.Add(unaPersona);
            }

            return listFiltrada;
        }


        public List<Persona> Clientes
        {
            get
            {
                return this.clientes;
            }
        }
        public List<Persona> Empleados
        {
            get
            {
                return this.empleados;
            }
        }
        public List<Producto> Productos
        {
            get
            {
                return this.productosStock;
            }
        }

        public string MostrarClientes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cliente unEmpleado in this.clientes)
            {
                sb.AppendLine(unEmpleado.Mostrar());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string MostrarEmpleados()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Empleado unEmpleado in this.empleados)
            {
                sb.AppendLine(unEmpleado.Mostrar());
                sb.AppendLine();
            }

            return sb.ToString();
        }


        public static Ferreteria  operator +(Ferreteria ferreteria, Empleado empleado)
        {
            if(ferreteria !=empleado)
            {
                ferreteria.empleados.Add(empleado);
            }
            else
            {
                throw new ArgumentException("Ya existe un empleado con ese DNI");
            }
            return ferreteria;
        }
        public static Ferreteria operator +(Ferreteria ferreteria, Cliente cliente)
        {
            if (ferreteria != cliente)
            {
                ferreteria.clientes.Add(cliente);
            }
            else
            {
                throw new ArgumentException("Ya existe un cliente con ese DNI");
            }
            return ferreteria;
        }
        public static bool operator ==(Ferreteria ferreteria, Producto producto)
        {
            foreach(Producto unProducto in ferreteria.productosStock)
            {
                if (unProducto == producto)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Ferreteria ferreteria, Producto producto)
        {
            return !(ferreteria == producto);
        }

        //public static Ferreteria operator +(Ferreteria ferreteria, Empleado empleado)
        //{
        //    if (ferreteria != empleado)
        //    {
        //        ferreteria.clientes.Add(empleado);
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Ya existe un cliente con ese DNI");
        //    }
        //    return ferreteria;
        //}

        public static bool operator ==(Ferreteria ferreteria, Persona cliente)
        {
            List<Persona> aux = ferreteria.clientes;

            if(cliente is Empleado)
            {
                aux = ferreteria.empleados;
            }

            foreach (Persona uncliente in aux)
            {
                if (uncliente == cliente)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Ferreteria ferreteria, Persona cliente)
        {
            return !(ferreteria == cliente);
        }
    }
}
