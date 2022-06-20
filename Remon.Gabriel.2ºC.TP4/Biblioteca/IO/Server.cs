using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Productos;
using Biblioteca.DTO;
using Biblioteca.Personas;
using System.Data;

namespace Biblioteca.IO
{
    public static class Server
    {
        static string coneccionSting;
        static SqlCommand comand;
        static SqlConnection conection;

        static Server()
        {
            coneccionSting = @"Server = DESKTOP-F6HDDRU; Database = Ferreteria; Trusted_Connection = True";
            comand = new SqlCommand();
            conection = new SqlConnection(coneccionSting);
            comand.CommandType = System.Data.CommandType.Text;
            comand.Connection = conection;
        }

       

        public static void Guardar(List<Producto> productos)
        {
            try
            {
                comand.Parameters.Clear();
                conection.Open();
                foreach (Producto producto in productos)
                {
                    comand.CommandText = $"INSERT INTO ProductoStock VALUES (@precio,@cantidadStock,@cantidadEstandar,@codigo,@descripcion)";
                    comand.Parameters.AddWithValue("@precio", producto.Precio);
                    comand.Parameters.AddWithValue("@cantidadStock", producto.Stock);
                    comand.Parameters.AddWithValue("@cantidadEstandar", producto.CantidadEstandar);
                    comand.Parameters.AddWithValue("@codigo", producto.Id);
                    comand.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    comand.ExecuteNonQuery();
                    comand.Parameters.Clear();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }

        public static void Guardar(Cliente cliente)
        {
            try
            {
                comand.Parameters.Clear();
                conection.Open();

                Clientedto clientedto = cliente.CrearDto();
                comand.CommandText = $"INSERT INTO Cliente VALUES (@usuario,@contraseña,@nombre,@apellido,@fechaNacimiento,@dni,@estadoFiscal)";
                comand.Parameters.AddWithValue("@estadoFiscal", clientedto.EstadoFiscal);
                comand.Parameters.AddWithValue("@usuario", clientedto.Usuario);
                comand.Parameters.AddWithValue("@contraseña", clientedto.Contraseña);
                comand.Parameters.AddWithValue("@nombre", clientedto.Nombre);
                comand.Parameters.AddWithValue("@apellido", clientedto.Apellido);
                comand.Parameters.AddWithValue("@fechaNacimiento", clientedto.FechaNacimiento);
                comand.Parameters.AddWithValue("@dni", clientedto.Dni);
                comand.ExecuteNonQuery();
                comand.Parameters.Clear();

            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }
        public static void Guardar(Empleado empleado)
        {
            try
            {
                comand.Parameters.Clear();
                conection.Open();

                EmpleadoDto empleadoDto = empleado.CrearDto();
                comand.CommandText = $"INSERT INTO Empleado VALUES (@usuario,@contraseña,@nombre,@apellido,@fechaNacimiento,@dni,@fechaContratacion,@sueldo,@cargo)";
                comand.Parameters.AddWithValue("@fechaContratacion", empleadoDto.FechaNacimiento);
                comand.Parameters.AddWithValue("@sueldo", empleadoDto.Sueldo);
                comand.Parameters.AddWithValue("@cargo", empleadoDto.CargoActual);
                comand.Parameters.AddWithValue("@usuario", empleadoDto.Usuario);
                comand.Parameters.AddWithValue("@contraseña", empleadoDto.Contraseña);
                comand.Parameters.AddWithValue("@nombre", empleadoDto.Nombre);
                comand.Parameters.AddWithValue("@apellido", empleadoDto.Apellido);
                comand.Parameters.AddWithValue("@fechaNacimiento", empleadoDto.FechaNacimiento);
                comand.Parameters.AddWithValue("@dni", empleadoDto.Dni);
                comand.ExecuteNonQuery();
                comand.Parameters.Clear();
            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }

        public static void Guardar(List<Venta> ventas)
        {
            int i = 0;
            try
            {
                comand.Parameters.Clear();
                conection.Open();
                foreach (Venta venta in ventas)
                {
                    VentaDto ventaDto = venta.CrearDto();
                    comand.CommandText = $"INSERT INTO Venta VALUES (@id,@fechaCompra,@dniComprador,@VentaRealizada)";
                    comand.Parameters.AddWithValue("@id", i);
                    comand.Parameters.AddWithValue("@fechaCompra", ventaDto.FechaCompra);
                    comand.Parameters.AddWithValue("@dniComprador", ventaDto.Comprador.Dni);
                    comand.Parameters.AddWithValue("@VentaRealizada", ventaDto.VentaRealizada);
                    comand.ExecuteNonQuery();
                    comand.Parameters.Clear();

                    foreach (Producto producto in venta.Productos)
                    {
                        comand.Parameters.Clear();
                        comand.CommandText = $"INSERT INTO ProductoVenta VALUES (@precio,@cantidadVendidos,@codigo,@descripcion,@idVenta)";
                        comand.Parameters.AddWithValue("@precio", producto.Precio);
                        comand.Parameters.AddWithValue("@cantidadVendidos", producto.CantidadVendidos);
                        comand.Parameters.AddWithValue("@codigo", producto.Id);
                        comand.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        comand.Parameters.AddWithValue("@idVenta", i);
                        comand.ExecuteNonQuery();
                    }
                    i++;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }


        public static void Guardar(Ferreteria ferreteria)
        {
            try
            {
                comand.Parameters.Clear();
      

                foreach(Cliente cliente in ferreteria.Clientes)
                {
                    Server.Guardar(cliente);
                }
                foreach (Empleado empleado in ferreteria.Empleados)
                {
                    Server.Guardar(empleado);
                }
                Server.Guardar(ferreteria.Productos);
                Server.Guardar(ferreteria.Ventas);

            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }
        public static DataTable LeerClientes()
        {
            string consulta = "SELECT [nombre],[apellido],[dni] FROM Cliente";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta,conection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable LeerEmpleados()
        {
            string consulta = "SELECT[nombre],[apellido],[dni],[FechaContratacion],[Sueldo] FROM Empleado";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, conection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable LeerVenta()
        {
            string consulta = "select fechaCompra, codigo, descripcion, cantidadVentidos,";
            consulta += "nombre +' ' + apellido as 'Comprador' ";
            consulta += "from venta inner join ProductoVenta ";
            consulta += "on id = idVenta ";
            consulta += "inner join Cliente on venta.dniComprado = Cliente.dni";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, conection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static void Clear()
        {
            try
            {
                comand.Parameters.Clear();
                conection.Open();
           
                comand.CommandText = $"DELETE FROM Cliente;";
                comand.CommandText += $"DELETE FROM Empleado;";
                comand.CommandText += $"DELETE FROM ProductoStock;";
                comand.CommandText += $"DELETE FROM ProductoVenta;";
                comand.CommandText += $"DELETE FROM Venta;";
                comand.ExecuteNonQuery();
                comand.Parameters.Clear();
            }
            catch
            {
                throw;
            }
            finally
            {
                conection.Close();
            }
        }

    }
}
