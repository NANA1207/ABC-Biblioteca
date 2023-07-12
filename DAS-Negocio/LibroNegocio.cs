using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAS_Datos;
using DAS_Entidades;

namespace DAS_Negocio
{
    public class LibroNegocio
    {
        public static LibroEntidad add(LibroEntidad obj)
        {
            return LibroDatos.add(obj);

        }
        public static bool edit(LibroEntidad obj)
        {
            return LibroDatos.edit(obj);

        }
        public static bool delete(LibroEntidad obj)
        {
            return LibroDatos.delete(obj);

        }
        public static async Task<List<LibroEntidad>> getAsync()
        {

            return await LibroDatos.getAsync();

        }
        public static LibroEntidad get(string id)
        {
            return LibroDatos.get(id);
        }
        public static List<LibroEntidad> buscar(string busqueda, int value)
        {
            switch (value)
            {
                case 1:
                    return LibroDatos.buscarByID(busqueda);

                case 2:
                    return LibroDatos.buscarByEditorial(busqueda);

                case 3:
                    return LibroDatos.buscarByAutor(busqueda);
                case 4:
                    return LibroDatos.buscarByTitulo(busqueda);

            }
            return null;
        }
        public static bool existe(string cedula)
        {
            return LibroDatos.exist(cedula);
        }
        public static bool updateStateDisponilbe(string IDlibro, int option)
        {
            var ejemplar = get(IDlibro);
            switch (option)
            {
                case 0:
                    ejemplar.DISPONIBILIDAD = "No";
                    break;
                case 1:
                    ejemplar.DISPONIBILIDAD = "Si";
                    break;
            }
            return edit(ejemplar);
        }
        public static List<LibroEntidad> get()
        {
            return LibroDatos.get();
        }
    }

}

