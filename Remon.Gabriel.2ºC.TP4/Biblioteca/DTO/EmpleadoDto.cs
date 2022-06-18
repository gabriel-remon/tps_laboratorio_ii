using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Personas;

namespace Biblioteca.DTO
{
    public class EmpleadoDto
    {
        protected string usuario;
        protected string contraseña;
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNacimiento;
        protected int dni;

        private DateTime fechaContratacion;
        private decimal sueldo;
        private Empleado.Cargo cargo;

        #region Propiedades

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                this.contraseña = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }



        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public DateTime FechaContratacion { get => fechaContratacion; set => fechaContratacion = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public Empleado.Cargo CargoActual { get => cargo; set => cargo = value; }
  

        #endregion
    }
}
