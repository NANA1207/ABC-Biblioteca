using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Entidades
{
    public class LibroEntidad
    {
        
        public string ID_LIB { get; set; }
        public string TITULO_LIB { get; set; }
        public string AUTOR_LIB { get; set; }
        public string EDITORIAL_LIB { get; set; }
        public DateTime FECHA_EDI_LIB { get; set; }
        public int NUM_EDI_LIB { get; set; }
        public string DISPONIBILIDAD { get; set; }
        public DateTime FEC_ING_SIS { get; set; }
        public string ESTANTERIA { get; set; }
        public string FILA { get; set; }
        public string USU_ING_LIBRO { get; set; }

        public LibroEntidad()
        {
        }

        public LibroEntidad(string id, string titulo, string autor, string editorial, DateTime fecha_Edi, int num_Edi, string disponibilidad,
            DateTime fecha_Ingeso , string estanteria, string fila, string usuario)
        {
            ID_LIB = id;
            TITULO_LIB = titulo;
            AUTOR_LIB = autor;
            EDITORIAL_LIB = editorial;
            FECHA_EDI_LIB = fecha_Edi;
            NUM_EDI_LIB = num_Edi;
            DISPONIBILIDAD = disponibilidad;
            FEC_ING_SIS = fecha_Ingeso;
            ESTANTERIA = estanteria;
            FILA = fila;
            USU_ING_LIBRO = usuario;
        }
    }
}
