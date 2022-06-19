using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces
{
    public interface Ipersona
    {
        public string Nombre { get; }
        public string Apellido { get; }
            
        public int EdadActual { get; }
        public int Dni { get; }

    }
}
