using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Personas;

namespace Biblioteca.DTO
{
    public class Clientedto
    {
        public Clientedto()
        {
        }

        private Cliente.SituacionFiscal estadoFiscal;
        private string usuario;
        private string contraseña;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int dni;

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


        public Biblioteca.Personas.Cliente.SituacionFiscal EstadoFiscal { get => estadoFiscal; set => estadoFiscal = value; }

        #endregion

    }
}
