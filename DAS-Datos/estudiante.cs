//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAS_Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estudiante()
        {
            this.prestamo = new HashSet<prestamo>();
        }
    
        public string CED_EST { get; set; }
        public string NOM1_EST { get; set; }
        public string NOM2_EST { get; set; }
        public string APE1_EST { get; set; }
        public string APE2_EST { get; set; }
        public Nullable<System.DateTime> FEC_NAC_EST { get; set; }
        public string SEXO_EST { get; set; }
        public string DIR_EST { get; set; }
        public string EMAIL_EST { get; set; }
        public Nullable<int> NUM_MAT_EST { get; set; }
        public string CEL_REPRESENTANTE_EST { get; set; }
        public Nullable<System.DateTime> FEC_ING_SISTEMA_EST { get; set; }
        public Nullable<int> CANT_LIBROS { get; set; }
        public string ESTADO_EST { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prestamo> prestamo { get; set; }
    }
}
