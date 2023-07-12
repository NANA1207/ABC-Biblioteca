using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAS_Entidades;

namespace DAS_Datos
{
    public static class DetallePrestamoDatos
    {
        public static DetallePrestamoEntidad add(DetallePrestamoEntidad obj)
        {
            detalle_prestamos dato = new detalle_prestamos();

            dato.ID_DET = obj.ID_DET;
            dato.ID_LIBRO = obj.ID_LIBRO;
            dato.ID_PRES = (int)obj.ID_PRES;
            dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
            dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
            dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
            dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
            dato.USU_REC_DET = obj.USU_REC_DET;
            dato.OBS_DET = obj.OBS_DET;

            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    dato = ctx.detalle_prestamos.Add(dato);
                    ctx.SaveChanges();
                    obj.ID_DET = dato.ID_DET;

                }
                return obj;
            }
            catch (DbUpdateConcurrencyException)
            {
                return obj;
            }

        }

        public static bool edit(DetallePrestamoEntidad obj)
        {
            detalle_prestamos dato = new detalle_prestamos();
            dato.ID_DET = obj.ID_DET;
            dato.ID_LIBRO = obj.ID_LIBRO;
            dato.ID_PRES = (int)obj.ID_PRES;
            dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
            dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
            dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
            dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
            dato.USU_REC_DET = obj.USU_REC_DET;
            dato.OBS_DET = obj.OBS_DET;
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    ctx.Entry(dato).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    return true;
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }

        }

        public static async Task<List<DetallePrestamoEntidad>> getAsync()
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = await ctx.detalle_prestamos.OrderByDescending(x => x.ID_DET).Take(50).ToListAsync();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }

        public static DetallePrestamoEntidad get(int id)
        {
            DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var obj = ctx.detalle_prestamos.Where(x => x.ID_DET == id).FirstOrDefault();
                    dato.ID_DET = obj.ID_DET;
                    dato.ID_LIBRO = obj.ID_LIBRO;
                    dato.ID_PRES = (int)obj.ID_PRES;
                    dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                    dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                    dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                    dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                    dato.USU_REC_DET = obj.USU_REC_DET;
                    dato.OBS_DET = obj.OBS_DET;

                }
                return dato;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }
        public static bool delete(DetallePrestamoEntidad obj)
        {

            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var item = ctx.detalle_prestamos.Find(obj.ID_DET);
                    ctx.detalle_prestamos.Remove(item);
                    ctx.SaveChanges();
                    return true;
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }


        public static List<DetallePrestamoEntidad> buscarByEstadoEjemplar(String value)
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from detalle_prestamos in ctx.detalle_prestamos
                              where detalle_prestamos.ESTADO_EJE_DET.Contains(value)
                              select detalle_prestamos
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }
        public static List<DetallePrestamoEntidad> detallePrestamo(int value)
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from detalle_prestamos in ctx.detalle_prestamos
                              where detalle_prestamos.ESTADO_EJE_DET == "PENDIENTE"
                              where detalle_prestamos.ID_PRES == value
                              select detalle_prestamos
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }
        public static List<DetallePrestamoEntidad> buscarByIdEjemplar(string value)
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from detalle_prestamos in ctx.detalle_prestamos
                              where detalle_prestamos.ID_LIBRO == value
                              select detalle_prestamos
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }
        public static List<DetallePrestamoEntidad> buscarByIdPrestamoAll(int value)
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from detalle_prestamos in ctx.detalle_prestamos
                              where detalle_prestamos.ID_PRES == value
                              select detalle_prestamos
                             ).Distinct().Take(4).ToList();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }
        public static List<DetallePrestamoEntidad> buscarByIdPrestamo(int value)
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from detalle_prestamos in ctx.detalle_prestamos
                              where detalle_prestamos.ID_PRES == value
                              && detalle_prestamos.ESTADO_EJE_DET == "PENDIENTE"
                              select detalle_prestamos
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }

        public static List<DetallePrestamoEntidad> buscarByIdPrestamoPendientes(int value)
        {
            List<DetallePrestamoEntidad> lista = new List<DetallePrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from detalle_prestamos in ctx.detalle_prestamos
                              where detalle_prestamos.ID_PRES == value
                              where detalle_prestamos.ESTADO_EJE_DET == "PENDIENTE"
                              select detalle_prestamos
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        DetallePrestamoEntidad dato = new DetallePrestamoEntidad();
                        dato.ID_DET = obj.ID_DET;
                        dato.ID_LIBRO = obj.ID_LIBRO;
                        dato.ID_PRES = (int)obj.ID_PRES;
                        dato.ESTADO_I_EJE = obj.ESTADO_I_EJE;
                        dato.ESTADO_F_EJE = obj.ESTADO_F_EJE;
                        dato.FEC_DEV_DET =   obj.FEC_DEV_DET;
                        dato.ESTADO_EJE_DET=obj.ESTADO_EJE_DET;
                        dato.USU_REC_DET = obj.USU_REC_DET;
                        dato.OBS_DET = obj.OBS_DET;
                        lista.Add(dato);
                    }
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }
    }
}
