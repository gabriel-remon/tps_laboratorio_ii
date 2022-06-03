using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Productos
{
    public class Caños:producto
    {
        public enum TipoCaño
        {
            PVC,
            Polipropileno,
            polietileno,
            Tigre,
            Aguaduc,
            Fusion,
            Otros
        }

        protected float diametro;
        protected float largo;
        protected TipoCaño tipoCaño;

        public Caños(int codigo,decimal precio,int cantidadStok,
                    float diametro, float largo, TipoCaño tipoCaño)
            :base(codigo,$"{tipoCaño} diametro {diametro}",precio,cantidadStok)
        {
            this.diametro = diametro;
            this.largo = largo;
            this.tipoCaño = tipoCaño;
        }

        public Caños(int codigo, decimal precio,
                    float diametro, float largo, TipoCaño tipoCaño)
            : this(codigo,precio,0,diametro,largo,tipoCaño)
        {
        }

        public Caños(int codigo,
                    float diametro, float largo, TipoCaño tipoCaño)
            : this(codigo,0,0,diametro,largo,tipoCaño)
        {
        }

        public Caños(Caños caño, int cantidadStok)
            : this(caño.codigo,caño.precio,caño.cantidadStock,caño.diametro,caño.largo,caño.tipoCaño)
        {
        }

        public override string MostrarVenta()
        {
            return $"{codigo}  {descripcion} {largo} de largo   {precio}$ {cantidadVendidos * precio}$ ";
        }
    }
}
