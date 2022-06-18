using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Personas;
using Biblioteca.DTO;

namespace Biblioteca.DAO
{
    public class ClienteDao
    {
        public static Cliente CrearOriginal(Clientedto clienteDto)
        {
            Cliente cliente = new Cliente(nombre: clienteDto.Nombre
                                         ,apellido: clienteDto.Apellido
                                         ,fechaNacimiento: clienteDto.FechaNacimiento
                                         , dni: clienteDto.Dni
                                         , contraseña: clienteDto.Contraseña
                                         , estadoFiscal: clienteDto.EstadoFiscal) ;

            return cliente;
        }

        public static List<Usuarios> CrearOriginal(List<Clientedto> clientesdto)
        {
            List<Usuarios> clienteList = new List<Usuarios>();

            foreach(Clientedto item in clientesdto)
            {
                clienteList.Add(ClienteDao.CrearOriginal(item));
            }

            return clienteList;
        }
    }
}
