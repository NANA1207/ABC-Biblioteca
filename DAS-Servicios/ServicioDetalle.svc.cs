using DAS_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using DAS_Negocio;
using System.Threading.Tasks;

namespace DAS_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDetalle" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioDetalle.svc o ServicioDetalle.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioDetalle : IServicioDetalle
    {
        public DetallePrestamoEntidad add(DetallePrestamoEntidad obj)
        {
            return DetallePrestamoNegocio.add(obj);

        }
        public bool edit(DetallePrestamoEntidad obj)
        {
            return DetallePrestamoNegocio.edit(obj);

        }
        public bool delete(DetallePrestamoEntidad obj)
        {
            return DetallePrestamoNegocio.delete(obj);

        }
        //public async Task<List<DetallePrestamoEntidad>> getAsync()
        //{

        //    return await DetallePrestamoNegocio.getAsync();

        //}
        public DetallePrestamoEntidad traerDetalle(int id)
        {
            return DetallePrestamoNegocio.get(id);
        }
        public List<DetallePrestamoEntidad> detallePorPrestamo(int id)
        {
            return DetallePrestamoNegocio.detallePorPrestamo(id);
        }
        public List<DetallePrestamoEntidad> buscar(string busqueda, int value)
        {
            return DetallePrestamoNegocio.buscar(busqueda, value);
        }
        public List<DetallePrestamoEntidad> buscarPendientesIdPrestamo(int value)
        {
            return DetallePrestamoNegocio.buscarPendientesIdPrestamo(value);
        }
        public List<DetallePrestamoEntidad> buscarByIdPrestamoAll(int prestamo)
        {
            return DetallePrestamoNegocio.buscarByIdPrestamoAll(prestamo);
        }
    }
}
