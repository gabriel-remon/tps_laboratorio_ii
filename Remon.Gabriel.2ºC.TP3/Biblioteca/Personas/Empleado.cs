using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected DateTime fechaContratacion;
        protected decimal sueldo;
        protected Cargo cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, int dni,
                        string contraseña,
                        DateTime fechaContratacion, decimal sueldo, Cargo cargo)
            :base(nombre,apellido,fechaNacimiento,dni,contraseña)
        {
            this.fechaContratacion = fechaContratacion;
            this.sueldo = sueldo;
            this.cargo = cargo;
        }

        public int Antiguedad
        {
            get
            {
                
                return (int)Math.Floor((DateTime.Now - fechaContratacion).TotalDays / 365);
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine($"Antiguedad: {this.Antiguedad} años");
            sb.AppendLine($"Cargo actual: {cargo} ");
            sb.AppendLine($"sueldo actual: {sueldo.ToString("C")} ");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.nombre} {this.apellido}";
        }

        //public static bool operator ==(Empleado e1, Empleado e2)
        //{
        //    return e1.dni == e2.dni;
        //}
        //public static bool operator !=(Empleado e1, Empleado e2)
        //{
        //    return !(e1 == e2);
        //}
    }
}
