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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstudiante" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioEstudiante.svc o ServicioEstudiante.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioEstudiante : IServicioEstudiante
    {
        public EstudianteEntidad add(EstudianteEntidad obj)
        {
            return EstudianteNegocio.add(obj);
        }

        public List<EstudianteEntidad> buscar(string busqueda, int value)
        {
            return EstudianteNegocio.buscar(busqueda, value);
        }

        public bool delete(EstudianteEntidad obj)
        {
            return EstudianteNegocio.delete(obj);
        }

        public bool edit(EstudianteEntidad obj)
        {
            return EstudianteNegocio.edit(obj);
        }

        public bool existe(string cedula)
        {
            return EstudianteNegocio.existe(cedula);
        }

        public EstudianteEntidad ObtenerEstudianteID(string id)
        {
            return EstudianteNegocio.get(id);
        }

        public List<EstudianteEntidad> ObtenerEstudiantes()
        {
            return EstudianteNegocio.get();
        }

        //public Task<List<EstudianteEntidad>> getAsync()
        //{
        //    return EstudianteNegocio.getAsync();
        //}

        public bool updateState(EstudianteEntidad estudiante)
        {
            return EstudianteNegocio.updateState(estudiante);
        }
    }
}
