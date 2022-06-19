using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DTO;

namespace Biblioteca.Personas
{
    public class Cliente : Usuarios
    {
        public enum SituacionFiscal
        {
            Monotributista,
            ResponsableInscripto,
            ConsumidorFinal,
            Otros
        }
        private SituacionFiscal estadoFiscal;

        public Cliente(string nombre, string apellido, DateTime fechaNacimiento, int dni,
                         string contraseña, SituacionFiscal estadoFiscal)
            : base(nombre, apellido, fechaNacimiento, dni, contraseña)
        {
            this.estadoFiscal = estadoFiscal;
        }


        public override string Mostrar()
        {
        
            StringBuilder sb = new StringBuilder();

            sb.Append((string)this);
            sb.AppendLine($"Estado Fiscal = { this.estadoFiscal}");

            return sb.ToString();
        }

        public Clientedto CrearDto()
        {
            Clientedto clientedto = new Clientedto();

            clientedto.Dni = this.dni;
            clientedto.Usuario = this.usuario;
            clientedto.Contraseña = this.contraseña;
            clientedto.FechaNacimiento = this.fechaNacimiento;
            clientedto.Nombre = this.nombre;
            clientedto.Apellido = this.Apellido;
            clientedto.EstadoFiscal = this.estadoFiscal;

            return clientedto;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
