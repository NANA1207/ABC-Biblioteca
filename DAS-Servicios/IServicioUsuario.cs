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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        UsuarioEntidad add(UsuarioEntidad obj);
        [OperationContract]
        bool edit(UsuarioEntidad obj);
        [OperationContract]
        bool delete(UsuarioEntidad obj);
        [OperationContract]
        UsuarioEntidad obtenerUsuarioID(string id);
        [OperationContract]
        List<UsuarioEntidad> buscar(string busqueda, int value);
        [OperationContract]
        UsuarioEntidad login(string user, string pass);
        [OperationContract]
        List<UsuarioEntidad> obtenerUsuarios();
    }
}
