using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Text;

using DAS_Entidades;

namespace DAS_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioLibros" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioLibros
    {
        [OperationContract]
        LibroEntidad add(LibroEntidad obj);
        [OperationContract]
        bool edit(LibroEntidad obj);
        [OperationContract]
        bool delete(LibroEntidad obj);
        //[OperationContract]
        //Task<List<LibroEntidad>> getAsync();
        [OperationContract]
        LibroEntidad ObtenerLibroID(string id);
        [OperationContract]
        List<LibroEntidad> buscar(string busqueda, int value);
        [OperationContract]
        bool existe(string cedula);
        [OperationContract]
        bool updateStateDisponilbe(string IDlibro, int option);
        [OperationContract]
        List<LibroEntidad> ObtenerLibros();
    }
}
