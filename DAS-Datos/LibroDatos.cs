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
    public static class LibroDatos
    {
        public static LibroEntidad add(LibroEntidad obj)
        {
            libro dato = new libro();

            //
            dato.ID_LIB = obj.ID_LIB;
            dato.TITULO_LIB = obj.TITULO_LIB;
            dato.AUTOR_LIB = obj.AUTOR_LIB;
            //
            dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
            dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
            //
            dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
            dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
            //
            dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
            dato.ESTANTERIA = obj.ESTANTERIA;
            dato.FILA = obj.FILA;
            //
            //
            //
            dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
            //
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    dato = ctx.libro.Add(dato);
                    ctx.SaveChanges();
                    obj.ID_LIB = dato.ID_LIB;

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
                var ls = ctx.libro.Where(x => x.ID_LIB == value).FirstOrDefault();

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

        public static List<LibroEntidad> get()
        {
            List<LibroEntidad> lista = new List<LibroEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = ctx.libro.OrderByDescending(x => x.ID_LIB).ToList();

                    foreach (var obj in ls)
                    {
                        LibroEntidad dato = new LibroEntidad();
                        //
                        dato.ID_LIB = obj.ID_LIB;
                        dato.TITULO_LIB = obj.TITULO_LIB;
                        dato.AUTOR_LIB = obj.AUTOR_LIB;
                        dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                        dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
                        //
                        //
                        dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                        dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                        //
                        dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
                        dato.ESTANTERIA = obj.ESTANTERIA;
                        dato.FILA = obj.FILA;
                        
                        
                        
                        dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                        //
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

        public static bool edit(LibroEntidad obj)
        {
            libro dato = new libro();
            //
            dato.ID_LIB = obj.ID_LIB;
            dato.TITULO_LIB = obj.TITULO_LIB;
            dato.AUTOR_LIB = obj.AUTOR_LIB;
            dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
            dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
            //
            dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
            dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
            //
            //
            dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
            dato.ESTANTERIA = obj.ESTANTERIA;
            dato.FILA = obj.FILA;
            //
            //
            //
            dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
            //

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

        public static async Task<List<LibroEntidad>> getAsync()
        {
            List<LibroEntidad> lista = new List<LibroEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = await ctx.libro.OrderByDescending(x => x.ID_LIB).Take(50).ToListAsync();

                    foreach (var obj in ls)
                    {
                        LibroEntidad dato = new LibroEntidad();
                        //
                        dato.ID_LIB = obj.ID_LIB;
                        dato.TITULO_LIB = obj.TITULO_LIB;
                        dato.AUTOR_LIB = obj.AUTOR_LIB;
                        dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                        dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
                        //
                        dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                        //
                        dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                        //
                        dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
                        dato.ESTANTERIA = obj.ESTANTERIA;
                        dato.FILA = obj.FILA;
                        //
                        //
                        //
                        dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                        //
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

        public static LibroEntidad get(string id)
        {
            LibroEntidad dato = new LibroEntidad();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var obj = ctx.libro.Where(x => x.ID_LIB == id).FirstOrDefault();
                    //
                    dato.ID_LIB = obj.ID_LIB;
                    dato.TITULO_LIB = obj.TITULO_LIB;
                    dato.AUTOR_LIB = obj.AUTOR_LIB;
                    dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                    //
                    dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
                    //
                    dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                    dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                    //
                    dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
                    dato.ESTANTERIA = obj.ESTANTERIA;
                    dato.FILA = obj.FILA;
                    //
                    //
                    //
                    dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                    //

                }
                return dato;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }
        public static bool delete(LibroEntidad obj)
        {

            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var item = ctx.libro.Find(obj.ID_LIB);
                    ctx.libro.Remove(item);
                    ctx.SaveChanges();
                    return true;
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }
        public static List<LibroEntidad> buscarByID(String value)
        {
            List<LibroEntidad> lista = new List<LibroEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from libro in ctx.libro
                              where libro.ID_LIB.Contains(value)
                              select libro
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        LibroEntidad dato = new LibroEntidad();
                        //
                        dato.ID_LIB = obj.ID_LIB;
                        //
                        dato.TITULO_LIB = obj.TITULO_LIB;
                        dato.AUTOR_LIB = obj.AUTOR_LIB;
                        dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                        dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
                        //
                        dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                        dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                        //
                        dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
                        dato.ESTANTERIA = obj.ESTANTERIA;
                        dato.FILA = obj.FILA;
                        //
                        //
                        //
                        dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                        //
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
        public static List<LibroEntidad> buscarByEditorial(String value)
        {
            List<LibroEntidad> lista = new List<LibroEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from libro in ctx.libro
                              where libro.EDITORIAL_LIB.Contains(value)
                              select libro
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        LibroEntidad dato = new LibroEntidad();
                        //
                        dato.ID_LIB = obj.ID_LIB;
                        dato.TITULO_LIB = obj.TITULO_LIB;
                        dato.AUTOR_LIB = obj.AUTOR_LIB;
                        dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                        dato.NUM_EDI_LIB = (int) obj.NUM_EDI_LIB;
                        //
                        //
                        dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                        dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                        //
                        dato.FEC_ING_SIS = (DateTime) obj.FEC_ING_SIS;
                        dato.ESTANTERIA = obj.ESTANTERIA;
                        dato.FILA = obj.FILA;
                        //
                        //
                        //
                        dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                        //
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
        public static List<LibroEntidad> buscarByTitulo(String value)
        {
            List<LibroEntidad> lista = new List<LibroEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from libro in ctx.libro
                              where libro.TITULO_LIB.Contains(value)
                              select libro
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        LibroEntidad dato = new LibroEntidad();
                        //
                        dato.ID_LIB = obj.ID_LIB;
                        dato.TITULO_LIB = obj.TITULO_LIB;
                        dato.AUTOR_LIB = obj.AUTOR_LIB;
                        dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                        dato.NUM_EDI_LIB = (int)obj.NUM_EDI_LIB;
                        //
                        //
                        dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                        dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                        //
                        dato.FEC_ING_SIS = (DateTime)obj.FEC_ING_SIS;
                        dato.ESTANTERIA = obj.ESTANTERIA;
                        dato.FILA = obj.FILA;
                        //
                        //
                        //
                        dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                        //
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
        public static List<LibroEntidad> buscarByAutor(String value)
        {
            List<LibroEntidad> lista = new List<LibroEntidad>();
            try
            {
                using (EntitiesABCF ctx = new EntitiesABCF())
                {
                    var ls = (from libro in ctx.libro
                              where libro.AUTOR_LIB.Contains(value)
                              select libro
                             ).Distinct().Take(20).ToList();

                    foreach (var obj in ls)
                    {
                        LibroEntidad dato = new LibroEntidad();
                        //
                        dato.ID_LIB = obj.ID_LIB;
                        dato.TITULO_LIB = obj.TITULO_LIB;
                        dato.AUTOR_LIB = obj.AUTOR_LIB;
                        dato.EDITORIAL_LIB = obj.EDITORIAL_LIB;
                        dato.NUM_EDI_LIB = (int)obj.NUM_EDI_LIB;
                        //
                        //
                        dato.FECHA_EDI_LIB = (DateTime)obj.FECHA_EDI_LIB;
                        dato.DISPONIBILIDAD = obj.DISPONIBILIDAD;
                        //
                        dato.FEC_ING_SIS = (DateTime)obj.FEC_ING_SIS;
                        dato.ESTANTERIA = obj.ESTANTERIA;
                        dato.FILA = obj.FILA;
                        //
                        //
                        //
                        dato.USU_ING_LIBRO = obj.USU_ING_LIBRO;
                        //
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