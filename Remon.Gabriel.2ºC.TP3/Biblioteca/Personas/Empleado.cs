using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Personas
{
    public class Empleado : Usuarios
    {
        protected DateTime fechaContratacion;
        protected decimal sueldo;
        protected string cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, int dni,
                        string usuario, string contraseña,
                        DateTime fechaContratacion, decimal sueldo, string cargo)
            :base(nombre,apellido,fechaNacimiento,dni,usuario,contraseña)
        {
            this.fechaContratacion = fechaContratacion;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.nombre} {this.apellido}";
        }
    }
}
