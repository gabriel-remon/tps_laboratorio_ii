using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DTO;

namespace Biblioteca.Personas
{


    public class Empleado : Usuarios
    {
        public enum Cargo
        {
            Gerente,
            AtencionPublico,
            Reparto,
            Otro
        }

        private DateTime fechaContratacion;
        private decimal sueldo;
        private Cargo cargo;

        public Empleado()
            :this(string.Empty, string.Empty,DateTime.Now,0, string.Empty,DateTime.Now, 0,0)
        {

        }

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, int dni,
                        string contraseña,
                        DateTime fechaContratacion, decimal sueldo, Cargo cargo)
            :base(nombre,apellido,fechaNacimiento,dni,contraseña)
        {
            this.fechaContratacion = fechaContratacion;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }

        #region Propiedades

        

        public int Antiguedad
        {
            get
            {
                
                return (int)Math.Floor((DateTime.Now - fechaContratacion).TotalDays / 365);
            }
        }

        #endregion

        public EmpleadoDto CrearDto()
        {
            EmpleadoDto empleadoDto = new EmpleadoDto();

            empleadoDto.Dni = this.dni;
            empleadoDto.Usuario = this.usuario;
            empleadoDto.Contraseña = this.contraseña;
            empleadoDto.FechaNacimiento = this.fechaNacimiento;
            empleadoDto.Nombre = this.nombre;
            empleadoDto.Apellido = this.Apellido;
            empleadoDto.FechaContratacion = this.fechaContratacion;
            empleadoDto.CargoActual = this.cargo;
            empleadoDto.Sueldo = this.sueldo;


            return empleadoDto;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine($"Antiguedad: {this.Antiguedad} años");
            sb.AppendLine($"Cargo actual: {this.cargo} ");
            sb.AppendLine($"sueldo actual: {this.sueldo.ToString("C")} ");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{base.ToString()} -- Sueldo: {this.sueldo}  cargo: {this.cargo}";
        }

        
    }
}
