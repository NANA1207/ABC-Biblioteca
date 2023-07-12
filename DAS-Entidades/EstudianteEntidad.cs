using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Entidades
{
    public class EstudianteEntidad
    {
        public string CED_EST { get; set; }
        public string NOM1_EST { get; set; }
        public string NOM2_EST { get; set; }
        public string APE1_EST { get; set; }
        public string APE2_EST { get; set; }
        public DateTime FEC_NAC_EST { get; set; }
        public string SEXO_EST { get; set; }
        public string DIR_EST { get; set; }
        public string EMAIL_EST { get; set; }
        public int? NUM_MAT_EST { get; set; }
        public string CEL_REPRESENTANTE_EST { get; set; }
        public DateTime FEC_ING_SISTEMA_EST { get; set; }
        public int? CANT_LIBROS { get; set; }
        public string ESTADO { get; set; }


        public EstudianteEntidad()
        {
        }
        public EstudianteEntidad(string cedula, string nom1, string nom2, string ape1, string ape2, DateTime fec_Nac, string sexo_est,
            string correo, string direccion, int matricula, string cel, DateTime fec_Ingreso, int cant_Lib, string estado)
        {
            CED_EST = cedula;
            NOM1_EST = nom1;
            NOM2_EST = nom2;
            APE1_EST = ape1;
            APE2_EST = ape2;
            FEC_NAC_EST = fec_Nac;
            SEXO_EST = sexo_est;
            DIR_EST = direccion;
            EMAIL_EST = correo;
            NUM_MAT_EST = matricula;
            CEL_REPRESENTANTE_EST = cel;
            FEC_ING_SISTEMA_EST = fec_Ingreso;
            CANT_LIBROS = cant_Lib;
            ESTADO = estado;
        }
    }
}
