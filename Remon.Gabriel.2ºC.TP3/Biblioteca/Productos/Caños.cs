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

        public Caños(int codigo,decimal precio,int cantidadStok,int cantidadEstandar,
                    float diametro, float largo, TipoCaño tipoCaño)
            :base(codigo,$"{tipoCaño} diametro {diametro}",precio,cantidadStok, cantidadEstandar)
        {
            this.diametro = diametro;
            this.largo = largo;
            this.tipoCaño = tipoCaño;
        }


       

        public override string MostrarVenta()
        {
            return $"{codigo}  {descripcion} {largo} de largo   {precio}$ {cantidadVendidos * precio}$ ";
        }
    }
}
