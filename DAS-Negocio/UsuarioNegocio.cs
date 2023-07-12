using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAS_Entidades;
using DAS_Datos;

namespace DAS_Negocio
{
    public static class UsuarioNegocio
    {
        public static UsuarioEntidad add(UsuarioEntidad obj)
        {
            return UsuarioDatos.add(obj);

        }
        public static bool edit(UsuarioEntidad obj)
        {
            return UsuarioDatos.edit(obj);

        }
        public static bool delete(UsuarioEntidad obj)
        {
            return UsuarioDatos.delete(obj);

        }
        public static async Task<List<UsuarioEntidad>> getAsync()
        {

            return await UsuarioDatos.getAsync();

        }
        public static UsuarioEntidad get(string id)
        {
            return UsuarioDatos.get(id);
        }

        public static List<UsuarioEntidad> buscar(string busqueda, int value)
        {
            switch (value)
            {
                case 1:
                    return UsuarioDatos.buscarByCedula(busqueda);

                case 2:
                    return UsuarioDatos.buscarByCorreo(busqueda);

                case 3:
                    return UsuarioDatos.buscarByNombre(busqueda);

            }
            return null;
        }

        public static UsuarioEntidad login(string user, string pass)
        {
            return UsuarioDatos.login(user, pass);
        }

        public static List<UsuarioEntidad> get()
        {
            return UsuarioDatos.get();
        }
    }
}
