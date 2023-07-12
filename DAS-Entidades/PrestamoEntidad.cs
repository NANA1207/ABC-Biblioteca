using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Entidades
{
    public class PrestamoEntidad
    {
        public int ID_PRES { get; set; }
        public string USU_PRES { get; set; }
        public string EST_PRES { get; set; }
        public string FEC_PRES { get; set; }
        public string ESTADO_PRES { get; set; }
        public string OBS_PRES { get; set; }
        public int NUM_LIB { get; set; }
        public List<DetallePrestamoEntidad> detalles { get; set; }
        public EstudianteEntidad persona { get; set; }

        public PrestamoEntidad()
        {
        }

        public PrestamoEntidad(int id_Pres, string usuario, string ced_Est,string fecha_Pres, string estado, string observacion, int numLib)
        {
            ID_PRES = id_Pres;
            USU_PRES = usuario;
            ESTADO_PRES = ced_Est;
            FEC_PRES = fecha_Pres;
            ESTADO_PRES = estado;
            OBS_PRES = observacion;
            NUM_LIB = numLib;
        }
    }
}
