//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SI2
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntregasFranqueado
    {
        public int efid { get; set; }
        public Nullable<int> fid { get; set; }
        public Nullable<int> codigo_produto { get; set; }
        public Nullable<int> quantidade { get; set; }
        public Nullable<System.DateTime> data { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual Franqueado Franqueado { get; set; }
    }
}
