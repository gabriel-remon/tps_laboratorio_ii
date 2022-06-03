using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Personas
{
    public class Cliente:Usuarios
    {
        public enum SituacionFiscal
        {
            Monotributista,
            ResponsableInscripto,
            ConsumidorFinal,
            Otros
        }
        protected SituacionFiscal estadoFiscal;
        protected Dictionary<DateTime,List<Productos.producto>> compras;

        public Cliente(string nombre,string apellido,DateTime fechaNacimiento,int dni,
                        string usuiario, string contraseña, SituacionFiscal estadoFiscal)
            :base(nombre,apellido,fechaNacimiento,dni,usuiario,contraseña)
        {
            this.compras = new Dictionary<DateTime,List<Productos.producto>>(); 
            this.estadoFiscal = estadoFiscal;
        }
        public override string Mostrar()
        {
            decimal aux=0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine($"Estado Fiscal");

            foreach(var unaCompra in this.compras)
            {
                sb.AppendLine($"fecha de la comra: {unaCompra.Key.ToString("d")}");
                sb.AppendLine($"Codigo     Descripcion       valor unitario       sub total");
                foreach(Productos.producto producto in unaCompra.Value)
                {
                    sb.AppendLine(producto.MostrarVenta());
                    aux += producto.SubTotal;
                }
                sb.AppendLine($"Total de la compra : {aux}$");
                sb.AppendLine();
            }


            return sb.ToString();
        }

        public static bool operator +(Cliente cliente, List<Productos.producto> compra)
        {
            if(compra is not null && cliente is not null)
            {
                cliente.compras.Add(DateTime.Today, compra);
                return true;
            }
            return false;
        }
    }
}
