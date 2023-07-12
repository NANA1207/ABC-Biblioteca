using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAS_Datos;
using DAS_Entidades;

namespace DAS_Negocio
{
    public static class DetallePrestamoNegocio
    {
        public static DetallePrestamoEntidad add(DetallePrestamoEntidad obj)
        {
            return DetallePrestamoDatos.add(obj);

        }
        public static bool edit(DetallePrestamoEntidad obj)
        {
            return DetallePrestamoDatos.edit(obj);

        }
        public static bool delete(DetallePrestamoEntidad obj)
        {
            return DetallePrestamoDatos.delete(obj);

        }
        public static async Task<List<DetallePrestamoEntidad>> getAsync()
        {

            return await DetallePrestamoDatos.getAsync();

        }
        public static DetallePrestamoEntidad get(int id)
        {
            return DetallePrestamoDatos.get(id);
        }
        public static List<DetallePrestamoEntidad> detallePorPrestamo(int id)
        {
            return DetallePrestamoDatos.buscarByIdPrestamo(id);
        }

        public static List<DetallePrestamoEntidad> buscar(string busqueda, int value)
        {
            int bus = Int32.Parse(busqueda);
            switch (value)
            {
                case 1:
                    return DetallePrestamoDatos.buscarByEstadoEjemplar(busqueda);

                case 2:
                    return DetallePrestamoDatos.buscarByIdEjemplar(busqueda);

                case 3:
                    return DetallePrestamoDatos.buscarByIdPrestamo(bus);

            }
            return null;
        }
        public static List<DetallePrestamoEntidad> buscarPendientesIdPrestamo(int value)
        {
            return DetallePrestamoDatos.buscarByIdPrestamoPendientes(value);
        }

        public static List<DetallePrestamoEntidad> buscarByIdPrestamoAll(int prestamo)
        {
            return DetallePrestamoDatos.buscarByIdPrestamoAll(prestamo);
        }
    }
}
