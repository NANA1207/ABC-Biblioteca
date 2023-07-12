using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using DAS_Entidades;
using DAS_Negocio;

namespace DAS_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEstudiante" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEstudiante
    {
        [OperationContract]
        EstudianteEntidad add(EstudianteEntidad obj);
        [OperationContract]
        bool edit(EstudianteEntidad obj);
        [OperationContract]
        bool delete(EstudianteEntidad obj);

        //[OperationContract]
        ////[WebGet(UriTemplate = "getAsync", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        //Task<List<EstudianteEntidad>> getAsync();

        [OperationContract]
        //[WebGet(UriTemplate = "get?id={id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EstudianteEntidad ObtenerEstudianteID(string id);

        [OperationContract]
        //[WebGet(UriTemplate = "buscar?busqueda={busqueda}&value={value}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<EstudianteEntidad> buscar(string busqueda, int value);

        [OperationContract]
        //[WebGet(UriTemplate = "existe?cedula={cedula}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool existe(string cedula);

        [OperationContract]
        //[WebInvoke(Method ="POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool updateState(EstudianteEntidad estudiante);

        [OperationContract]
        //[WebGet(UriTemplate = "ObtenerListaEstudiantes", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<EstudianteEntidad> ObtenerEstudiantes();

    }
}
