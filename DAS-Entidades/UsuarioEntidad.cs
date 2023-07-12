using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Entidades
{
    public class UsuarioEntidad
    {
        public string CED_USU { get; set; }
        public string NOM_USU { get; set; }
        public string APE_USU { get; set; }
        public string SEXO_USU { get; set; }
        public string EMAIL_USU { get; set; }
        public string TEL_USU { get; set; }
        public string TIPO_USU { get; set; }
        public string CONTRA_USU { get; set; }
        public DateTime FEC_ING_SIS { get; set; }
        public string ESTADO_USU { get; set; }

        public UsuarioEntidad()
        {
        }

        public UsuarioEntidad(string cedula, string nombre, string apellido, string sexo, string email, string telefono,
             string tipo, string clave, DateTime fecha_Ing, string estado)
        {
            CED_USU = cedula;
            NOM_USU = nombre;
            APE_USU = apellido;
            SEXO_USU = sexo;
            EMAIL_USU = email;
            TEL_USU = telefono;
            TIPO_USU = tipo;
            CONTRA_USU = clave;
            FEC_ING_SIS = fecha_Ing;
            ESTADO_USU = estado;
        }
    }
}
