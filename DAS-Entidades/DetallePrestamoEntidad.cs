using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Entidades
{
//h
    public class DetallePrestamoEntidad
    {
        public int ID_DET { get; set; }
        public string ID_LIBRO { get; set; }
        public int ID_PRES { get; set; }
        public string ESTADO_I_EJE { get; set; }
        public string ESTADO_F_EJE { get; set; }
        public string FEC_DEV_DET { get; set; }
        public string USU_REC_DET { get; set; }
        public string OBS_DET { get; set; }
        public string ESTADO_EJE_DET { get; set; }


        public DetallePrestamoEntidad()
        {
        }

        public DetallePrestamoEntidad(int id_Det, string id_Lib, int id_Pres, string estado_I, string estado_F,string fec_Dev, 
            string usuario, string observacion, string estado)
        {
            ID_DET = id_Det;
            ID_LIBRO = id_Lib;
            ID_PRES = id_Pres;
            ESTADO_I_EJE = estado_I;
            ESTADO_F_EJE = estado_F;
            FEC_DEV_DET = fec_Dev;
            USU_REC_DET = usuario;
            OBS_DET = observacion;
            ESTADO_EJE_DET= estado;
        }
    }
}
