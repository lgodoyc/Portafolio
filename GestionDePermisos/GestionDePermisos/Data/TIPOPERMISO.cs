//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDePermisos.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOPERMISO
    {
        public TIPOPERMISO()
        {
            this.MOTIVO = new HashSet<MOTIVO>();
            this.SOLICITUD = new HashSet<SOLICITUD>();
        }
    
        public decimal IDTIPOPERMISO { get; set; }
        public string NOMBRETIPOPERMISO { get; set; }
        public Nullable<decimal> IDESTADO { get; set; }
    
        public virtual ESTADO ESTADO { get; set; }
        public virtual ICollection<MOTIVO> MOTIVO { get; set; }
        public virtual ICollection<SOLICITUD> SOLICITUD { get; set; }
    }
}