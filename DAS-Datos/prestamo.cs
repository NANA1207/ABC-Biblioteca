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
    
    public partial class prestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prestamo()
        {
            this.detalle_prestamos = new HashSet<detalle_prestamos>();
        }
    
        public int ID_PRES { get; set; }
        public string USU_PRES { get; set; }
        public string EST_PRES { get; set; }
        public string FEC_PRES { get; set; }
        public string ESTADO_PRES { get; set; }
        public string OBS_PRES { get; set; }
        public Nullable<int> NUM_LIB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_prestamos> detalle_prestamos { get; set; }
        public virtual estudiante estudiante { get; set; }
        public virtual usuarios_sistema usuarios_sistema { get; set; }
    }
}
