using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Personas
{
    public abstract class Usuarios:Persona
    {
        protected string usuario;
        protected string contraseña;

        public Usuarios(string nombre, string apellido, DateTime fechaNacimiento, int dni,
                        string contraseña)
            :base(nombre,apellido,fechaNacimiento,dni)
        {
            this.usuario = dni.ToString();
            this.contraseña = contraseña;
        }

        public string Usuario
        {
            get
            {
                return this.usuario; 
            }
        }

        public abstract string Mostrar();

        public bool Logear(string contraseñaActual, string usuario)
        {
            if(contraseñaActual == this.contraseña && usuario== this.usuario)
            {
                return true;
            }

            return false;
        }
        public static bool Logear(string contraseñaActual, string usuario,List<Persona> listaUsuarios)
        {
            foreach(Usuarios unUsuario in listaUsuarios)
            {
                if(unUsuario.Logear(contraseñaActual,usuario))
                {
                    return true;
                }
            }

            return false;
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


        public static bool operator == (Usuarios c1, Usuarios c2)
        {
            return c1.usuario == c2.usuario;
        }

        public static bool operator !=(Usuarios c1, Usuarios c2)
        {
            return !(c1==c2);
        }

    }
}
