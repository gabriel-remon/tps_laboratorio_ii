using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Productos
{
    public class Tornillos : Producto
    {
        public enum TipoTornillo
        {
            Fix,
            Bulon,
            TiraFondo,
            Parker,
            Otros
        }

        public enum Paso
        {
            Milimetrico,
            Pulgada,
            Otro
        }

        protected Paso paso;
        protected TipoTornillo tipoTornillo;

        public Tornillos(int codigo,decimal precio , int cantidadStock,int cantidadEstandar,
                        Paso paso, TipoTornillo tipoTornillo)
            :base(codigo,$"Tornillo {tipoTornillo} metrica: {paso}",precio,cantidadStock,cantidadEstandar)
        {
            this.paso = paso;
            this.tipoTornillo = tipoTornillo;
        }
    }
}
