using DAS_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDetalle" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDetalle
    {
        [OperationContract]
        DetallePrestamoEntidad add(DetallePrestamoEntidad obj);
        [OperationContract]
        bool edit(DetallePrestamoEntidad obj);
        [OperationContract]
        bool delete(DetallePrestamoEntidad obj);
        //[OperationContract]
        //Task<List<DetallePrestamoEntidad>> getAsync();
        [OperationContract]
        DetallePrestamoEntidad traerDetalle(int id);
        [OperationContract]
        List<DetallePrestamoEntidad> detallePorPrestamo(int id);
        [OperationContract]
        List<DetallePrestamoEntidad> buscar(string busqueda, int value);
        [OperationContract]
        List<DetallePrestamoEntidad> buscarPendientesIdPrestamo(int value);
        [OperationContract]
        List<DetallePrestamoEntidad> buscarByIdPrestamoAll(int prestamo);
    }
}
