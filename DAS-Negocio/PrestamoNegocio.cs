using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAS_Datos;
using DAS_Entidades;
using System.Transactions;



namespace DAS_Negocio
{
    public static class PrestamoNegocio
    {
        public static PrestamoEntidad add(PrestamoEntidad obj)

        {
            try
            {
                using (var ts = new TransactionScope())
                {
                    obj = PrestamoDatos.add(obj);
                    foreach (var det in obj.detalles)
                    {
                        det.ID_PRES = obj.ID_PRES;
                        DetallePrestamoNegocio.add(det);
                        LibroNegocio.updateStateDisponilbe(det.ID_LIBRO, 0);

                    }
                    EstudianteNegocio.updateState(obj.persona);
                    ts.Complete();
                }
                return obj;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static bool edit(PrestamoEntidad obj)
        {
            return PrestamoDatos.edit(obj);

        }
        public static bool delete(PrestamoEntidad obj)
        {
            return PrestamoDatos.delete(obj);

        }
        public static async Task<List<PrestamoEntidad>> getAsync()
        {

            return await PrestamoDatos.getAsync();

        }
        public static PrestamoEntidad get(int id)
        {
            return PrestamoDatos.get(id);
        }
        public static async Task<List<PrestamoEntidad>> getPendiente()
        {
            return await PrestamoDatos.getPendientes();
        }
        public static List<PrestamoEntidad> getPendientePersona(string id)
        {
            return PrestamoDatos.getPendientesPersona(id);
        }

        public static List<PrestamoEntidad> buscar(string busqueda, int value)
        {
            switch (value)
            {
                case 1:
                    return PrestamoDatos.buscarByEstado(busqueda);

                case 2:
                    DateTime b = DateTime.Parse(busqueda);
                    return PrestamoDatos.buscarByFecha(b);

                case 3:
                    string bus = busqueda;
                    return PrestamoDatos.buscarByIdUsuario(bus);

            }
            return null;
        }

        public static void updateState(PrestamoEntidad prestamo)
        {
            if (prestamo. Equals(""))
            {
                prestamo.ESTADO_PRES = "ENTREGADO";
            }
            edit(prestamo);
        }

        public static List<PrestamoEntidad> getByDateRange(DateTime initDate, DateTime endDate, int option)
        {
            return PrestamoDatos.getByDateRange(initDate, endDate, option);
        }

        public static async Task<List<PrestamoEntidad>> getPrestamos30Async()
        {
            return await PrestamoDatos.getPrestamos30Async();
        }

        public static List<PrestamoEntidad> get()
        {
            return PrestamoDatos.get();
        }
    }
}
