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
    
    public partial class MOTIVO
    {
        public decimal IDMOTIVO { get; set; }
        public string NOMBREMOTIVO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> IDTIPOPERMISO { get; set; }
    
        public virtual TIPOPERMISO TIPOPERMISO { get; set; }
    }
}
