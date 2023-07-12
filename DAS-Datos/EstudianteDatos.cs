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
    public static class EstudianteDatos
    {
        public static EstudianteEntidad add(EstudianteEntidad obj)
        {
            estudiante dato = new estudiante();

          
            dato.CED_EST = obj.CED_EST;
            dato.NOM1_EST = obj.NOM1_EST;
            dato.NOM2_EST = obj.NOM2_EST; 
            dato.APE1_EST = obj.APE1_EST;
            dato.APE2_EST = obj.APE2_EST;
            dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
            dato.DIR_EST = obj.DIR_EST;
            dato.EMAIL_EST = obj.EMAIL_EST;
            dato.NUM_MAT_EST = obj.NUM_MAT_EST;
            dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
            dato.CANT_LIBROS = obj.CANT_LIBROS;
            dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    dato = ctx.estudiante.Add(dato);
                    ctx.SaveChanges();
                    obj.CED_EST = dato.CED_EST;

                }
                return obj;
            }
            catch (DbUpdateConcurrencyException)
            {
                return obj;
            }

        }
        public static bool exist(String value)
        {

            using (EntitiesABCF ctx = new EntitiesABCF())
            {
                var ls = ctx.estudiante.Where(x => x.CED_EST == value).FirstOrDefault();

                if (ls != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static List<EstudianteEntidad> get()
        {
            List<EstudianteEntidad> lista = new List<EstudianteEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = ctx.estudiante.OrderByDescending(x => x.CED_EST).ToList();

                    foreach (var obj in ls)
                    {
                        EstudianteEntidad dato = new EstudianteEntidad();
                        //
                        dato.CED_EST = obj.CED_EST;
                        dato.NOM1_EST = obj.NOM1_EST;
                        dato.NOM2_EST = obj.NOM2_EST;
                        dato.APE1_EST = obj.APE1_EST;
                        dato.APE2_EST = obj.APE2_EST;
                        dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
                        dato.DIR_EST = obj.DIR_EST;
                        dato.EMAIL_EST = obj.EMAIL_EST;
                        dato.NUM_MAT_EST = obj.NUM_MAT_EST;
                        dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
                        dato.CANT_LIBROS = obj.CANT_LIBROS;
                        dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;
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
        public static bool edit(EstudianteEntidad obj)
        {
            estudiante dato = new estudiante();
            //
            dato.CED_EST = obj.CED_EST;
            dato.NOM1_EST = obj.NOM1_EST;
            dato.NOM2_EST = obj.NOM2_EST;
            dato.APE1_EST = obj.APE1_EST;
            dato.APE2_EST = obj.APE2_EST;
            dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
            dato.DIR_EST = obj.DIR_EST;
            dato.EMAIL_EST = obj.EMAIL_EST;
            dato.NUM_MAT_EST = obj.NUM_MAT_EST;
            dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
            dato.CANT_LIBROS = obj.CANT_LIBROS;
            dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;

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
        public static async Task<List<EstudianteEntidad>> getAsync()
        {
            List<EstudianteEntidad> lista = new List<EstudianteEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = await ctx.estudiante.OrderByDescending(x => x.CED_EST).Take(50).ToListAsync();

                    foreach (var obj in ls)
                    {
                        EstudianteEntidad dato = new EstudianteEntidad();
                        dato.CED_EST = obj.CED_EST;
                        dato.NOM1_EST = obj.NOM1_EST;
                        dato.NOM2_EST = obj.NOM2_EST;
                        dato.APE1_EST = obj.APE1_EST;
                        dato.APE2_EST = obj.APE2_EST;
                        dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
                        dato.DIR_EST = obj.DIR_EST;
                        dato.EMAIL_EST = obj.EMAIL_EST;
                        dato.NUM_MAT_EST = obj.NUM_MAT_EST;
                        dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
                        dato.CANT_LIBROS = obj.CANT_LIBROS;
                        dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;
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
        public static EstudianteEntidad get(string id)
        {
            EstudianteEntidad dato = new EstudianteEntidad();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var obj = ctx.estudiante.Where(x => x.CED_EST == id).FirstOrDefault();
                    //
                    dato.CED_EST = obj.CED_EST;
                    dato.NOM1_EST = obj.NOM1_EST;
                    dato.NOM2_EST = obj.NOM2_EST;
                    dato.APE1_EST = obj.APE1_EST;
                  //
                    dato.APE2_EST = obj.APE2_EST;
                   //
                    dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
                    dato.DIR_EST = obj.DIR_EST;
                   //
                    dato.EMAIL_EST = obj.EMAIL_EST;
                    dato.NUM_MAT_EST = obj.NUM_MAT_EST;
                    dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
                    dato.CANT_LIBROS = obj.CANT_LIBROS;
                    dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;

                }
                return dato;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }
        public static bool delete(EstudianteEntidad obj)
        {

            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var item = ctx.estudiante.Find(obj.CED_EST);
                    ctx.estudiante.Remove(item);
                    ctx.SaveChanges();
                    return true;
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
        public static List<EstudianteEntidad> buscarByCedula(String value)
        {
            List<EstudianteEntidad> lista = new List<EstudianteEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from estudiante in ctx.estudiante
                              where estudiante.CED_EST.Contains(value)
                              select estudiante
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        EstudianteEntidad dato = new EstudianteEntidad();
                        dato.CED_EST = obj.CED_EST;
                        dato.NOM1_EST = obj.NOM1_EST;
                        dato.NOM2_EST = obj.NOM2_EST;
                        dato.APE1_EST = obj.APE1_EST;
                        dato.APE2_EST = obj.APE2_EST;
                        dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
                        dato.DIR_EST = obj.DIR_EST;
                        dato.EMAIL_EST = obj.EMAIL_EST;
                        dato.NUM_MAT_EST = obj.NUM_MAT_EST;
                        dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
                        dato.CANT_LIBROS = obj.CANT_LIBROS;
                        dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;
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
        public static List<EstudianteEntidad> buscarByCorreo(String value)
        {
            List<EstudianteEntidad> lista = new List<EstudianteEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from estudiante in ctx.estudiante
                              where estudiante.EMAIL_EST.Contains(value)
                              select estudiante
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        EstudianteEntidad dato = new EstudianteEntidad();
                        //
                        dato.CED_EST = obj.CED_EST;
                        dato.NOM1_EST = obj.NOM1_EST;
                        dato.NOM2_EST = obj.NOM2_EST;
                        dato.APE1_EST = obj.APE1_EST;
                        dato.APE2_EST = obj.APE2_EST;
                        dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
                        dato.DIR_EST = obj.DIR_EST;
                        dato.EMAIL_EST = obj.EMAIL_EST;
                        dato.NUM_MAT_EST = obj.NUM_MAT_EST;
                        dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
                        dato.CANT_LIBROS = obj.CANT_LIBROS;
                        dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;
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
        public static List<EstudianteEntidad> buscarByApellido(String value)
        {
            List<EstudianteEntidad> lista = new List<EstudianteEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from estudiante in ctx.estudiante
                              where estudiante.APE1_EST.Contains(value)
                              select estudiante
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        EstudianteEntidad dato = new EstudianteEntidad();
                        //
                        dato.CED_EST = obj.CED_EST;
                        dato.NOM1_EST = obj.NOM1_EST;
                        dato.NOM2_EST = obj.NOM2_EST;
                        dato.APE1_EST = obj.APE1_EST;
                        dato.APE2_EST = obj.APE2_EST;
                        dato.FEC_NAC_EST = (DateTime) obj.FEC_NAC_EST;
                        dato.DIR_EST = obj.DIR_EST;
                        dato.EMAIL_EST = obj.EMAIL_EST;
                        dato.NUM_MAT_EST = obj.NUM_MAT_EST;
                        dato.CEL_REPRESENTANTE_EST = obj.CEL_REPRESENTANTE_EST;
                        dato.CANT_LIBROS = obj.CANT_LIBROS;
                        dato.FEC_ING_SISTEMA_EST = (DateTime) obj.FEC_ING_SISTEMA_EST;
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
