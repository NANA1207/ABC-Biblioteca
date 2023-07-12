using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAS_Entidades;

namespace DAS_Presentacion
{
    /// <summary>
    /// Métodos que ayudan a conectar ciertos parámetros entre forms
    /// </summary>
    class MetodosPresentacion
    {
         static string titulo;
         static bool estado;
        static string id;
        static UsuarioEntidad usuario;
        /// <summary>
        /// envia un título de un form a otro
        /// </summary>
        /// <param name="t">Título del form</param>
        public static void enviarTitulo(string t)
        {
            titulo = t;
            
        }
        /// <summary>
        /// Se optiene el Título enviado previamente
        /// </summary>
        /// <returns>Título enviado</returns>
         public  static String obtenerTitulo()
        {
            return titulo;

        }
        /// <summary>
        /// Envia un estado de un form a otro, para saber si es edición o nuevo
        /// </summary>
        /// <param name="t">Estado booleano</param>
        public static void enviarEstado(bool t)
        {
            estado = t;

        }
        /// <summary>
        /// Obtiene el estado enviado
        /// </summary>
        /// <returns>Estado booleano</returns>
        public static bool obtenerEstado()
        {
            return estado;

        }
        /// <summary>
        /// Envia el id para la búsuqeda de las distintas entidades.
        /// </summary>
        /// <param name="t">Id para la búsqueda</param>
        public static void enviarId(string t)
        {
            id = t;

        }
        /// <summary>
        /// Obtiene Id enviado
        /// </summary>
        /// <returns>Id para la búsqueda</returns>
        public static string obtenerId()
        {
            return id;

        }
        /// <summary>
        /// Envia usuario de un form a otro
        /// </summary>
        /// <param name="t">UsaurioEntidad</param>
        public static void enviarUsuario(UsuarioEntidad t)
        {
            usuario = t;

        }
        /// <summary>
        /// Ontiene el usuario enviado
        /// </summary>
        /// <returns>UsuarioEntidad</returns>
        public static UsuarioEntidad obtenerUsuiario()
        {
            return usuario;

        }
      
    }
}
