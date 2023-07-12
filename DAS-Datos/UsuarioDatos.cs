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
    public static class UsuarioDatos
    {
      public static UsuarioEntidad add(UsuarioEntidad obj)
        {
            usuarios_sistema dato = new usuarios_sistema();
            //
            dato.CED_USU = obj.CED_USU;
            dato.NOM_USU = obj.NOM_USU;
            dato.APE_USU = obj.APE_USU;
            dato.TIPO_USU = obj.TIPO_USU;
            dato.EMAIL_USU = obj.EMAIL_USU;
            dato.TELF_USU = obj.TEL_USU;
            dato.SEXO_USU = obj.SEXO_USU;
            dato.CONTRA_USU = obj.CONTRA_USU;
            dato.FEC_ING_SIS = obj.FEC_ING_SIS;
            dato.ESTADO_USU = obj.ESTADO_USU;
            
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    dato = ctx.usuarios_sistema.Add(dato);
                    ctx.SaveChanges();
                    obj.CED_USU = dato.CED_USU;
                    
                }
                return obj;
            }
            catch (DbUpdateConcurrencyException)
            {
                return obj;
            }

        }

        public static bool edit(UsuarioEntidad obj)
        {
            usuarios_sistema dato = new usuarios_sistema();
            //
            dato.CED_USU = obj.CED_USU;
            dato.NOM_USU = obj.NOM_USU;
            dato.APE_USU = obj.APE_USU;
            dato.TIPO_USU = obj.TIPO_USU;
            dato.EMAIL_USU = obj.EMAIL_USU;
            dato.TELF_USU = obj.TEL_USU;
            dato.SEXO_USU = obj.SEXO_USU;
            dato.CONTRA_USU = obj.CONTRA_USU;
            dato.ESTADO_USU = obj.ESTADO_USU;

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

        public static List<UsuarioEntidad> get()
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls =  ctx.usuarios_sistema.Where(x => x.ESTADO_USU == "ACTIVO").OrderByDescending(x => x.CED_USU).ToList();

                    foreach (var obj in ls)
                    {
                        UsuarioEntidad dato = new UsuarioEntidad();
                        //
                        dato.CED_USU = obj.CED_USU;
                        dato.NOM_USU = obj.NOM_USU;
                        dato.APE_USU = obj.APE_USU;
                        dato.TIPO_USU = obj.TIPO_USU;
                        dato.EMAIL_USU = obj.EMAIL_USU;
                        dato.TEL_USU = obj.TELF_USU;
                        dato.SEXO_USU = obj.SEXO_USU;
                        dato.CONTRA_USU = obj.CONTRA_USU;
                        dato.FEC_ING_SIS =(DateTime) obj.FEC_ING_SIS;
                        dato.ESTADO_USU = obj.ESTADO_USU;
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

        public static UsuarioEntidad login(string user, string pass)
        {
            UsuarioEntidad dato = new UsuarioEntidad();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var obj = ctx.usuarios_sistema.Where(x => x.CED_USU  == user && x.CONTRA_USU==pass && x.ESTADO_USU=="ACTIVO").FirstOrDefault();
                    if (obj != null)
                    {
                        //
                        dato.CED_USU = obj.CED_USU;
                        dato.NOM_USU = obj.NOM_USU;
                        dato.APE_USU = obj.APE_USU;
                        dato.TIPO_USU = obj.TIPO_USU;
                        dato.EMAIL_USU = obj.EMAIL_USU;
                        dato.TEL_USU = obj.TELF_USU;
                        dato.SEXO_USU = obj.SEXO_USU;
                        dato.CONTRA_USU = obj.CONTRA_USU;
                        dato.FEC_ING_SIS = (DateTime)obj.FEC_ING_SIS;
                        dato.ESTADO_USU = obj.ESTADO_USU;

                    }
                    

                }
                return dato;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }

        public static async Task<List<UsuarioEntidad>> getAsync()
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = await ctx.usuarios_sistema.Where(x=> x.ESTADO_USU == "ACTIVO").OrderByDescending(x => x.CED_USU).Take(50).ToListAsync();

                    foreach (var obj in ls)
                    {
                        UsuarioEntidad dato = new UsuarioEntidad();
                        //
                        dato.CED_USU = obj.CED_USU;
                        dato.NOM_USU = obj.NOM_USU;
                        dato.APE_USU = obj.APE_USU;
                        dato.TIPO_USU = obj.TIPO_USU;
                        dato.EMAIL_USU = obj.EMAIL_USU;
                        dato.TEL_USU = obj.TELF_USU;
                        dato.SEXO_USU = obj.SEXO_USU;
                        dato.CONTRA_USU = obj.CONTRA_USU;
                        dato.FEC_ING_SIS = (DateTime)obj.FEC_ING_SIS;
                        dato.ESTADO_USU = obj.ESTADO_USU;

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

        public static UsuarioEntidad get(string id)
        {
            UsuarioEntidad dato = new UsuarioEntidad();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var obj = ctx.usuarios_sistema.Where(x => x.CED_USU == id && x.ESTADO_USU=="ACTIVO").FirstOrDefault();
                    //
                    dato.CED_USU = obj.CED_USU;
                    dato.NOM_USU = obj.NOM_USU;
                    dato.APE_USU = obj.APE_USU;
                    dato.TIPO_USU = obj.TIPO_USU;
                    dato.EMAIL_USU = obj.EMAIL_USU;
                    dato.TEL_USU = obj.TELF_USU;
                    dato.SEXO_USU = obj.SEXO_USU;
                    dato.CONTRA_USU = obj.CONTRA_USU;
                    dato.ESTADO_USU = obj.ESTADO_USU;

                }
                return dato;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }
        public static bool delete(UsuarioEntidad obj)
        {

            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var item = ctx.usuarios_sistema.Find(obj.CED_USU);
                    ctx.usuarios_sistema.Remove(item);
                    ctx.SaveChanges();
                    return true;
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public static List<UsuarioEntidad> buscarByNombre(String value)
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from usuarios_sistema in ctx.usuarios_sistema
                              where usuarios_sistema.NOM_USU.Contains(value)
                              select usuarios_sistema
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        UsuarioEntidad dato = new UsuarioEntidad();
                        //
                        dato.CED_USU = obj.CED_USU;
                        dato.NOM_USU = obj.NOM_USU;
                        dato.APE_USU = obj.APE_USU;
                        dato.TIPO_USU = obj.TIPO_USU;
                        dato.EMAIL_USU = obj.EMAIL_USU;
                        dato.TEL_USU = obj.TELF_USU;
                        dato.SEXO_USU = obj.SEXO_USU;
                        dato.CONTRA_USU = obj.CONTRA_USU;
                        dato.ESTADO_USU = obj.ESTADO_USU;
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
        public static List<UsuarioEntidad> buscarByCorreo(String value)
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from usuarios_sistema in ctx.usuarios_sistema
                              where usuarios_sistema.EMAIL_USU.Contains(value)
                              select usuarios_sistema
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        UsuarioEntidad dato = new UsuarioEntidad();
                        //
                        dato.CED_USU = obj.CED_USU;
                        dato.NOM_USU = obj.NOM_USU;
                        dato.APE_USU = obj.APE_USU;
                        dato.TIPO_USU = obj.TIPO_USU;
                        dato.EMAIL_USU = obj.EMAIL_USU;
                        dato.TEL_USU = obj.TELF_USU;
                        dato.SEXO_USU = obj.SEXO_USU;
                        dato.CONTRA_USU = obj.CONTRA_USU;
                        dato.ESTADO_USU = obj.ESTADO_USU;
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

        public static List<UsuarioEntidad> buscarByCedula(String value)
        {
            List<UsuarioEntidad> lista = new List<UsuarioEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from usuarios_sistema in ctx.usuarios_sistema
                              where usuarios_sistema.CED_USU.Contains(value)
                              select usuarios_sistema
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        UsuarioEntidad dato = new UsuarioEntidad();
                        //
                        dato.CED_USU = obj.CED_USU;
                        dato.NOM_USU = obj.NOM_USU;
                        dato.APE_USU = obj.APE_USU;
                        dato.TIPO_USU = obj.TIPO_USU;
                        dato.EMAIL_USU = obj.EMAIL_USU;
                        dato.TEL_USU = obj.TELF_USU;
                        dato.SEXO_USU = obj.SEXO_USU;
                        dato.CONTRA_USU = obj.CONTRA_USU;
                        dato.ESTADO_USU = obj.ESTADO_USU;
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

