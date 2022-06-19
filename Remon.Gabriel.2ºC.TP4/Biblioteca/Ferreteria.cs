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

        /// <summary>
        /// agrega un producto a la lista de productos validadndo que no 
        /// se encuentre otro producto con su mismo id
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool AgregarProductoStock(Producto producto)
        {
            if(this != producto)
            {
                this.productosStock.Add(producto);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Busca un producto por su id y retorna las especificaciones del producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public string BuscarProducto(int idIngreso)
        {
           foreach(Producto producto in this.productosStock)
           {
                if(producto.Id == idIngreso)
                {
                    return producto.ToString();
                }
           }

            return "No existe un producto con ese codigo";
        }

        /// <summary>
        /// Retorna una lista de productos que contenga el parametro "codigo"
        /// dentro de su atributo ID
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retorna una lista de personas que contenga el parametro "codigo"
        /// dentro de su atributo DNI
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// agrega una venta a la lista de ventas, validando lo necesario
        /// </summary>
        /// <param name="venta"></param>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Descuenta la cantidad de productos que estan en el objeto venta
        /// del la lista de productos en stock de la ferreteria
        /// </summary>
        /// <param name="venta"></param>
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
        /// <summary>
        /// valida si el producto esta en la lista de ventas de la ferreteria
        /// y si esta cambia su estado de venta realizada a true
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Retorna un string con todas las caracteristicas de los usuarios 
        /// enviados como parametro
        /// </summary>
        /// <param name="usuarios"></param>
        /// <returns></returns>
        public static string Mostrar(List<Usuarios> usuarios)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuarios unEmpleado in usuarios)
            {
                sb.AppendLine(unEmpleado.Mostrar());
                sb.AppendLine();
            }

            return sb.ToString();
        }
        /// <summary>
        /// retorna un string con los productos que se deven pedir.
        /// estos se calculan tomando en cuenta la cantidad actual y la estandar
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Retorna una lista de las ventas realizadas y un cliente en especifico
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public List<Venta> VentasRealizadas(Cliente cliente)
        {
            List<Venta> ventas = new List<Venta>();

            foreach(Venta unaVenta in this.ventas)
            {
                if(unaVenta.VentaRealizada && unaVenta == cliente)
                {
                    ventas.Add(unaVenta);
                }
            }

            return ventas;
        }

        /// <summary>
        /// Retorna una lista de todas las ventas realizadas en la ferreteria
        /// </summary>
        /// <returns></returns>
        public List<Venta> VentasRealizadas()
        {
            List<Venta> ventas = new List<Venta>();

            foreach (Venta unaVenta in this.ventas)
            {
                if (unaVenta.VentaRealizada)
                {
                    ventas.Add(unaVenta);
                }
            }

            return ventas;
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
