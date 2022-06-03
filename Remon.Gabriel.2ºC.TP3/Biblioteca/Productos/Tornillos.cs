using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Productos
{
    public class Tornillos : producto
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

        public Tornillos(int codigo,int precio , int cantidadStock,
                        Paso paso, TipoTornillo tipoTornillo)
            :base(codigo,$"Tornillo {tipoTornillo} metrica: {paso}",precio,cantidadStock)
        {
            this.paso = paso;
            this.tipoTornillo = tipoTornillo;
        }
    }
}
