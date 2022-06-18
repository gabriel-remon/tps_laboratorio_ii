using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DTO;
using Biblioteca.Personas;

namespace Biblioteca.DAO
{
    public class EmpleadoDao
    {
        public static Empleado CrearOriginal(EmpleadoDto empleadoDto)
        {
            Empleado cliente = new Empleado(nombre: empleadoDto.Nombre
                                         , apellido: empleadoDto.Apellido
                                         , fechaNacimiento: empleadoDto.FechaNacimiento
                                         , dni: empleadoDto.Dni
                                         , contraseña: empleadoDto.Contraseña
                                         ,fechaContratacion: empleadoDto.FechaContratacion
                                         , sueldo: empleadoDto.Sueldo
                                         , cargo: empleadoDto.CargoActual);

            return cliente;
        }

        public static List<Usuarios> CrearOriginal(List<EmpleadoDto> empleadosDto)
        {
            List<Usuarios> EmpleadosList = new List<Usuarios>();

            foreach (EmpleadoDto item in empleadosDto)
            {
                EmpleadosList.Add(EmpleadoDao.CrearOriginal(item));
            }

            return EmpleadosList;
        }
    }
}
