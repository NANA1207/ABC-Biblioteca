using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DAS_Entidades;
using DAS_Negocio;

namespace DAS_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPrestamo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPrestamo
    {
        [OperationContract]
        PrestamoEntidad add(PrestamoEntidad obj);
        [OperationContract]
        bool edit(PrestamoEntidad obj);
        [OperationContract]
        bool delete(PrestamoEntidad obj);
        //[OperationContract]
        //Task<List<PrestamoEntidad>> getAsync();
        [OperationContract]
        PrestamoEntidad obtenerPrestamoID(int id);
        [OperationContract]
        Task<List<PrestamoEntidad>> getPendiente();
        [OperationContract]
        List<PrestamoEntidad> getPendientePersona(string id);
        [OperationContract]
        List<PrestamoEntidad> buscar(string busqueda, int value);
        [OperationContract]
        void updateState(PrestamoEntidad prestamo);
        [OperationContract]
        List<PrestamoEntidad> getByDateRange(DateTime initDate, DateTime endDate, int option);
        [OperationContract]
        Task<List<PrestamoEntidad>> getPrestamos30Async();
        [OperationContract]
        List<PrestamoEntidad> obtenerPrestamos();
    }
}
