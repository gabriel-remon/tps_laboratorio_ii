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
        List<producto> productosStock;
        List<producto> productosVendidos;

        public Ferreteria()
        {
            this.clientes = new List<Persona>();
            this.proveedores = new List<Persona>();
            this.productosStock = new List<producto>();
            this.productosVendidos = new List<producto>();
            this.empleados = new List<Persona>();
        }

        public Ferreteria(List<Persona> clientes, List<Persona> empleados, List<Persona> proveedores,
                        List<producto> productosStock, List<producto> productosVendidos)
        {
            this.clientes = clientes;
            this.empleados = empleados;
            this.proveedores = proveedores;
            this.productosStock = productosStock;
            this.productosVendidos = productosVendidos;
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

        //public static bool operator ==(Ferreteria ferreteria, Empleado empleado)
        //{
        //    foreach(Persona unEmpleado in ferreteria.empleados)
        //    {
        //        if(unEmpleado==empleado)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public static bool operator !=(Ferreteria ferreteria, Empleado empleado)
        //{
        //    return !(ferreteria == empleado);
        //}


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

        public static bool operator ==(Ferreteria ferreteria, Persona cliente)
        {
            foreach (Persona uncliente in ferreteria.clientes)
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
