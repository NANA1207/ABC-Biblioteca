using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAS_Entidades;
using DAS_Datos;

namespace DAS_Negocio
{
    public class EstudianteNegocio
    {
        public static EstudianteEntidad add(EstudianteEntidad obj)
        {
            return EstudianteDatos.add(obj);

        }
        public static bool edit(EstudianteEntidad obj)
        {
            return EstudianteDatos.edit(obj);

        }
        public static bool delete(EstudianteEntidad obj)
        {
            return EstudianteDatos.delete(obj);

        }
        public static async Task<List<EstudianteEntidad>> getAsync()
        {

            return await EstudianteDatos.getAsync();

        }
        public static EstudianteEntidad get(string id)
        {
            return EstudianteDatos.get(id);
        }
        public static List<EstudianteEntidad> buscar(string busqueda, int value)
        {
            switch (value)
            {
                case 1:
                    return EstudianteDatos.buscarByCedula(busqueda);

                case 2:
                    return EstudianteDatos.buscarByApellido(busqueda);

                case 3:
                    return EstudianteDatos.buscarByCorreo(busqueda);

            }
            return null;
        }
        public static bool existe(string cedula)
        {
            return EstudianteDatos.exist(cedula);
        }
        public static bool updateState(EstudianteEntidad estudiante)
        {
            switch (estudiante.CANT_LIBROS)
            {
                case 0:
                    estudiante.ESTADO = "Disponible";
                    break;
                case 1:
                    estudiante.ESTADO = "No Disponible";
                    break;
            }
            return EstudianteDatos.edit(estudiante);
        }
        public static List<EstudianteEntidad> get()
        {
            return EstudianteDatos.get();
        }
    }

}

