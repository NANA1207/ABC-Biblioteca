using DAS_Entidades;
using DAS_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPrestamo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioPrestamo.svc o ServicioPrestamo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioPrestamo : IServicioPrestamo
    {
        public PrestamoEntidad add(PrestamoEntidad obj)
        {
            return PrestamoNegocio.add(obj);
        }
        public bool edit(PrestamoEntidad obj)
        {
            return PrestamoNegocio.edit(obj);
        }
        public bool delete(PrestamoEntidad obj)
        {
            return PrestamoNegocio.delete(obj);

        }
        //public async Task<List<PrestamoEntidad>> getAsync()
        //{

        //    return await PrestamoNegocio.getAsync();

        //}
        public PrestamoEntidad obtenerPrestamoID(int id)
        {
            return PrestamoNegocio.get(id);
        }
        public async Task<List<PrestamoEntidad>> getPendiente()
        {
            return await PrestamoNegocio.getPendiente();
        }
        public List<PrestamoEntidad> getPendientePersona(string id)
        {
            return PrestamoNegocio.getPendientePersona(id);
        }
        public List<PrestamoEntidad> buscar(string busqueda, int value)
        {
            return PrestamoNegocio.buscar(busqueda, value);
        }
        public void updateState(PrestamoEntidad prestamo)
        {
            if (prestamo.Equals(""))
            {
                prestamo.ESTADO_PRES = "ENTREGADO";
            }
            edit(prestamo);
        }
        public List<PrestamoEntidad> getByDateRange(DateTime initDate, DateTime endDate, int option)
        {
            return PrestamoNegocio.getByDateRange(initDate, endDate, option);
        }
        public async Task<List<PrestamoEntidad>> getPrestamos30Async()
        {
            return await PrestamoNegocio.getPrestamos30Async();
        }
        public List<PrestamoEntidad> obtenerPrestamos()
        {
            return PrestamoNegocio.get();
        }
    }
}
