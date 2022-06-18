using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca.Personas
{
    [XmlInclude(typeof(Empleado))]
    [XmlInclude(typeof(Cliente))]
    public abstract class Usuarios
    {
        protected string usuario;
        protected string contraseña;
        protected string nombre;
        protected string apellido;
        protected DateTime fechaNacimiento;
        protected int dni;

        public Usuarios(string nombre, string apellido, DateTime fechaNacimiento, int dni,
                        string contraseña)
            
        {
            this.usuario = dni.ToString();
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        #region Propiedades
        //encapsular solo set
        public string Usuario
        {
            get
            {
                return this.usuario; 
            }

        }

        //encapsular solo set
        public int Dni
        {
            get
            {
                return this.dni;
            }

        }
      

        
        //encapsular solo set
        public string Apellido
        {
            get
            {
                return this.apellido;
            }

        }
        //encapsular solo set
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

        }


        public int EdadActual
        {
            get
            {
                return (int)Math.Floor((DateTime.Now - fechaNacimiento).TotalDays / 365);
            }
        }
        #endregion

        public abstract string Mostrar();

        public static explicit operator string(Usuarios usuario)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {usuario.nombre}");
            sb.AppendLine($"Apellido: {usuario.apellido}");
            sb.AppendLine($"Edad: {usuario.EdadActual}");
            sb.AppendLine($"DNI: {usuario.dni}");
            sb.AppendLine("-------------------");

            return sb.ToString();
        }

        public bool Logear(string contraseñaActual, string usuario)
        {
            if(contraseñaActual == this.contraseña && usuario== this.usuario)
            {
                return true;
            }

            return false;
        }
        public static Usuarios Logear(string contraseñaActual, string usuario,List<Usuarios> listaUsuarios)
        {
            foreach(Usuarios unUsuario in listaUsuarios)
            {
                if(unUsuario.Logear(contraseñaActual,usuario))
                {
                    return unUsuario;
                }
            }

            throw new Exception("Usuario no encontrado");
        }

        public bool CambiarContraseña(string contraseñaActual,string contraseñaNueva)
        {
            if(contraseñaActual == this.contraseña)
            {
                this.contraseña = contraseñaNueva;
                return true;
            }
            return false;
        }

        #region SobrecargaOperadores
        public static bool operator == (Usuarios c1, Usuarios c2)
        {
            return c1.usuario == c2.usuario || c1.dni == c2.dni;
        }

        public static bool operator !=(Usuarios c1, Usuarios c2)
        {
            return !(c1==c2);
        }
        #endregion
    }
}
