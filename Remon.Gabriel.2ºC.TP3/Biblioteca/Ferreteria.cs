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

        public Ferreteria(List<Persona> empleados)
        {
            this.clientes = new List<Persona>();
            this.proveedores = new List<Persona>();
            this.productosStock = new List<producto>();
            this.productosVendidos = new List<producto>();
            this.empleados = empleados;
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

        public static Ferreteria  operator +(Ferreteria ferreteria, Empleado empleado)
        {
            if(ferreteria !=empleado)
            {
                ferreteria.empleados.Add(empleado);
            }
            return ferreteria;
        }

        public static bool operator ==(Ferreteria ferreteria, Empleado empleado)
        {
            foreach(Persona unEmpleado in ferreteria.empleados)
            {
                if(unEmpleado==empleado)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Ferreteria ferreteria, Empleado empleado)
        {
            return !(ferreteria == empleado);
        }
    }
}
