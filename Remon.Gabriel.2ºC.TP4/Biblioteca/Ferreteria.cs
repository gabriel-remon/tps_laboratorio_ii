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
        List<Usuarios> clientes;
        List<Usuarios> empleados;
        //List<Persona> proveedores;
        List<Producto> productosStock;
        List<Venta> ventas;
        string nombreFerreteria;

        public Ferreteria()
            :this("La Ferreteria")
        {

        }

        public Ferreteria(string nombre)
            :this(new List<Usuarios>(), new List<Usuarios>(), new List<Producto>(), new List<Venta>(),nombre)
        {
        }

        public Ferreteria(List<Usuarios> clientes, List<Usuarios> empleados,
                        List<Producto> productosStock, List<Venta> ventas,string nombre)
        {
            this.clientes = clientes;
            this.empleados = empleados;
            //this.proveedores = proveedores;
            this.productosStock = productosStock;
            this.ventas = ventas;
        }
        #region Propiedades

        public List<Usuarios> Clientes
        {
            get
            {
                return this.clientes;
            }
            
        }
        public List<Usuarios> Empleados
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
        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
            }
            
        }

        public string NombreFerreteria
        {
            get
            {
                return this.nombreFerreteria;
            }
            set
            {
                this.nombreFerreteria = value;
            }

        }

        #endregion


        #region Metodos

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
        public List<Usuarios> FiltrarClientes(string codigo)
        {
            List<Usuarios> listFiltrada = new List<Usuarios>();

            foreach (Usuarios unaPersona in this.clientes)
            {
                
                if ((Convert.ToString(unaPersona.Dni)).Contains(codigo))
                    listFiltrada.Add(unaPersona);
            }

            return listFiltrada;
        }


        public void AgregarPedido(Venta venta)
        {
            if(venta is not null && venta.Productos.Count>0)
            {
                DescontarStock(venta);
                this.ventas.Add(venta);
            }
            else
            {
                throw new Exception("Error al realizar la venta");
            }
        }

        private void DescontarStock(Venta venta)
        {
            Producto aux;

            foreach(Producto unProducto in this.productosStock)
            {
                aux = venta.BuscarProducto(unProducto);
                if (aux is not null)
                {
                    unProducto.Stock -= aux.CantidadVendidos;
                }
            }
        }

        public  bool Realizarventa (Venta venta)
        {
            foreach(Venta unaVenta in this.ventas)
            {
                if(unaVenta == venta)
                {
                    Venta.RealizarVenta(venta);

                    return true;
                }
            }

            throw new Exception("No se encontro la venta");
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

        public string RealizarPedidoDistribuidora()
        {
            StringBuilder sb = new StringBuilder();

            if(this.productosStock.Count == 0)
            {
                throw new Exception("Error, no hay productos cargados");
            }

            sb.AppendLine($"Pedidos de la ferreteria: {this.nombreFerreteria}");
            foreach(Producto unProducto in this.productosStock)
            {
                if(unProducto.StockFaltante > 0)
                {
                    sb.AppendLine($"Cantidad: {unProducto.StockFaltante}  - codigo: {unProducto.Id}  descripcion del producto{unProducto.Descripcion}");
                }
            }

            return sb.ToString();
        }

        #endregion


        #region sobrecargaOperadores
        public static Ferreteria  operator +(Ferreteria ferreteria, Empleado empleado)
        {
            if(ferreteria != empleado)
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

        

        public static bool operator ==(Ferreteria ferreteria, Usuarios cliente)
        {
            List<Usuarios> aux = ferreteria.clientes;

            if(cliente is Empleado)
            {
                aux = ferreteria.empleados;
            }

            foreach (Usuarios uncliente in aux)
            {
                if (uncliente == cliente)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Ferreteria ferreteria, Usuarios cliente)
        {
            return !(ferreteria == cliente);
        }
        #endregion
    }
}
