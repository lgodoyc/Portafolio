//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDePermisos.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDAD()
        {
            this.DEPARTAMENTO = new HashSet<DEPARTAMENTO>();
        }
    
        public decimal IDUNIDAD { get; set; }
        public string NOMBREUNIDAD { get; set; }
        public Nullable<decimal> IDMUNICIPALIDAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual MUNICIPALIDAD MUNICIPALIDAD { get; set; }
    }
}
