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
    
    public partial class libro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public libro()
        {
            this.detalle_prestamos = new HashSet<detalle_prestamos>();
        }
    
        public string ID_LIB { get; set; }
        public string TITULO_LIB { get; set; }
        public string AUTOR_LIB { get; set; }
        public string EDITORIAL_LIB { get; set; }
        public Nullable<System.DateTime> FECHA_EDI_LIB { get; set; }
        public Nullable<int> NUM_EDI_LIB { get; set; }
        public string DISPONIBILIDAD { get; set; }
        public Nullable<System.DateTime> FEC_ING_SIS { get; set; }
        public string ESTANTERIA { get; set; }
        public string FILA { get; set; }
        public string USU_ING_LIBRO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_prestamos> detalle_prestamos { get; set; }
        public virtual usuarios_sistema usuarios_sistema { get; set; }
    }
}