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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioUsuario.svc o ServicioUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioUsuario : IServicioUsuario
    {
        public UsuarioEntidad add(UsuarioEntidad obj)
        {
            return UsuarioNegocio.add(obj);
        }
        public bool edit(UsuarioEntidad obj)
        {
            return UsuarioNegocio.edit(obj);
        }
        public bool delete(UsuarioEntidad obj)
        {
            return UsuarioNegocio.delete(obj);
        }
        public UsuarioEntidad obtenerUsuarioID(string id)
        {
            return UsuarioNegocio.get(id);
        }
        public List<UsuarioEntidad> buscar(string busqueda, int value)
        {
            return UsuarioNegocio.buscar(busqueda, value);
        }
        public UsuarioEntidad login(string user, string pass)
        {
            return UsuarioNegocio.login(user, pass);
        }
        public List<UsuarioEntidad> obtenerUsuarios()
        {
            return UsuarioNegocio.get();
        }
    }
}
