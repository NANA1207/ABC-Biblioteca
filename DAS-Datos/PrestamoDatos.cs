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
    public static class PrestamoDatos
    {
         public static PrestamoEntidad add(PrestamoEntidad obj)
        {
            prestamo dato = new prestamo();
            
            dato.ID_PRES = obj.ID_PRES;
            dato.USU_PRES = obj.USU_PRES;
            dato.EST_PRES = obj.EST_PRES;
            dato.FEC_PRES =   obj.FEC_PRES;
            dato.ESTADO_PRES = obj.ESTADO_PRES;
            dato.OBS_PRES = obj.OBS_PRES;
            dato.NUM_LIB = (int) obj.NUM_LIB;
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    dato = ctx.prestamo.Add(dato);
                    ctx.SaveChanges();
                    
                    
                }
                obj.ID_PRES = dato.ID_PRES;
                return obj;
            }
            catch (DbUpdateConcurrencyException)
            {
                return obj;
            }

        }

        public static bool edit(PrestamoEntidad obj)
        {
            prestamo dato = new prestamo();
            dato.ID_PRES = obj.ID_PRES;
            dato.USU_PRES = obj.USU_PRES;
            dato.EST_PRES = obj.EST_PRES;
            dato.FEC_PRES =   obj.FEC_PRES;
            dato.ESTADO_PRES = obj.ESTADO_PRES;
            dato.OBS_PRES = obj.OBS_PRES;
            dato.NUM_LIB = (int) obj.NUM_LIB;
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

        public static async Task<List<PrestamoEntidad>> getAsync()
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = await ctx.prestamo.OrderByDescending(x => x.ID_PRES).Take(20).ToListAsync();

                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
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

        public static List<PrestamoEntidad> get()
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from prestamo in ctx.prestamo
                                   select prestamo).ToList();
                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
                     
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

        public static async Task<List<PrestamoEntidad>> getPrestamos30Async()
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = await (from prestamo in ctx.prestamo 
                                    where prestamo.FEC_PRES == DateTime.Now.ToString()
                                    select prestamo).ToListAsync();
                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
                       
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

        public static List<PrestamoEntidad> getByDateRange(DateTime initDate, DateTime endDate,int option)
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                   
                    if (option==1)
                    {
                          var ls = ctx.prestamo.Where(x => x.FEC_PRES == initDate.ToString() )
                           .OrderByDescending(x => x.ID_PRES);
                        foreach (var obj in ls)
                        {
                            PrestamoEntidad dato = new PrestamoEntidad();
                            dato.ID_PRES = obj.ID_PRES;
                            dato.USU_PRES = obj.USU_PRES;
                            dato.EST_PRES = obj.EST_PRES;
                            dato.FEC_PRES =   obj.FEC_PRES;
                            dato.ESTADO_PRES = obj.ESTADO_PRES;
                            dato.OBS_PRES = obj.OBS_PRES;
                            dato.NUM_LIB = (int) obj.NUM_LIB;
                            lista.Add(dato);
                        }

                    }
                    else
                    {
                        var ls = ctx.prestamo.Where(x=> x.FEC_PRES == endDate.ToString() )
                           .OrderByDescending(x => x.ID_PRES);
                        foreach (var obj in ls)
                        {
                            PrestamoEntidad dato = new PrestamoEntidad();
                            dato.ID_PRES = obj.ID_PRES;
                            dato.USU_PRES = obj.USU_PRES;
                            dato.EST_PRES = obj.EST_PRES;
                            dato.FEC_PRES =   obj.FEC_PRES;
                            dato.ESTADO_PRES = obj.ESTADO_PRES;
                            dato.OBS_PRES = obj.OBS_PRES;
                            dato.NUM_LIB = (int) obj.NUM_LIB;
                            lista.Add(dato);
                        }
                    }
                   

                   
                }
                return lista;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }

        public static async Task<List<PrestamoEntidad>> getPendientes()
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls =await ctx.prestamo.Where(x=>x.ESTADO_PRES == "Pendiente").Take(20).ToListAsync();
                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
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

        public static List<PrestamoEntidad> getPendientesPersona(string id)
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from prestamo in ctx.prestamo
                              where prestamo.ESTADO_PRES=="Pendiente"
                              where prestamo.EST_PRES==id
                              select prestamo
                              ).Distinct().Take(20).ToList();
                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
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

        public static PrestamoEntidad get(int id)
        {
            PrestamoEntidad dato = new PrestamoEntidad();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var obj = ctx.prestamo.Where(x => x.ID_PRES == id).FirstOrDefault();
                    dato.ID_PRES = obj.ID_PRES;
                    dato.USU_PRES = obj.USU_PRES;
                    dato.EST_PRES = obj.EST_PRES;
                    dato.FEC_PRES =   obj.FEC_PRES;
                    dato.ESTADO_PRES = obj.ESTADO_PRES;
                    dato.OBS_PRES = obj.OBS_PRES;
                    dato.NUM_LIB = (int) obj.NUM_LIB;
                }
                return dato;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }
        public static bool delete(PrestamoEntidad obj)
        {
            
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var item = ctx.prestamo.Find(obj.ID_PRES);
                    ctx.prestamo.Remove(item);
                    ctx.SaveChanges();
                    return true;
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

      

        public static List<PrestamoEntidad> buscarByIdUsuario(string value)
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from prestamo in ctx.prestamo
                              where prestamo.USU_PRES == value
                              select prestamo
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
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
        public static List<PrestamoEntidad> buscarByFecha(DateTime value)
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from prestamo in ctx.prestamo
                              where prestamo.FEC_PRES == value.ToString()
                              select prestamo
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
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
        public static List<PrestamoEntidad> buscarByEstado(String value)
        {
            List<PrestamoEntidad> lista = new List<PrestamoEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from prestamo in ctx.prestamo
                              where prestamo.ESTADO_PRES == value
                              select prestamo
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        PrestamoEntidad dato = new PrestamoEntidad();
                        dato.ID_PRES = obj.ID_PRES;
                        dato.USU_PRES = obj.USU_PRES;
                        dato.EST_PRES = obj.EST_PRES;
                        dato.FEC_PRES =   obj.FEC_PRES;
                        dato.ESTADO_PRES = obj.ESTADO_PRES;
                        dato.OBS_PRES = obj.OBS_PRES;
                        dato.NUM_LIB = (int) obj.NUM_LIB;
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
