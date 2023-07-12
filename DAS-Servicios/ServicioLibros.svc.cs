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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioLibros" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioLibros.svc o ServicioLibros.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioLibros : IServicioLibros
    {
        public LibroEntidad add(LibroEntidad obj)
        {
            return LibroNegocio.add(obj);
        }

        public List<LibroEntidad> buscar(string busqueda, int value)
        {
            return LibroNegocio.buscar(busqueda, value);
        }

        public bool delete(LibroEntidad obj)
        {
            return LibroNegocio.delete(obj);
        }

        public bool edit(LibroEntidad obj)
        {
            return LibroNegocio.edit(obj);
        }

        public bool existe(string cedula)
        {
            return LibroNegocio.existe(cedula);
        }

        public LibroEntidad ObtenerLibroID(string id)
        {
            return LibroNegocio.get(id);
        }

        public List<LibroEntidad> ObtenerLibros()
        {
            return LibroNegocio.get();
        }

        //public Task<List<LibroEntidad>> getAsync()
        //{
        //    return LibroNegocio.getAsync();
        //}

        public bool updateStateDisponilbe(string IDlibro, int option)
        {
            return LibroNegocio.updateStateDisponilbe(IDlibro, option);
        }
    }
}
