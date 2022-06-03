using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Personas
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNacimiento;
        protected int dni;
        public Persona(string nombre, string apellido, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public int EdadActual
        {
            get
            {
                return DateTime.Today.AddTicks(-this.fechaNacimiento.Ticks).Year -1;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        { 
            get 
            { 
                return this.nombre; 
            }
        }

    
        public override string ToString()
        {
            return $"{this.apellido} {this.nombre}";
        }

        public static explicit operator string(Persona persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {persona.nombre}");
            sb.AppendLine($"Apellido: {persona.apellido}");
            sb.AppendLine($"Edad: {persona.EdadActual}");
            sb.AppendLine($"DNI: {persona.dni}");

            return sb.ToString();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2); 
        }

    }
}
