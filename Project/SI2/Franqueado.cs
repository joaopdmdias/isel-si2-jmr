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
    
    public partial class Franqueado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Franqueado()
        {
            this.EntregasFranqueados = new HashSet<EntregasFranqueado>();
            this.HistoricoVendas = new HashSet<HistoricoVenda>();
            this.PedidosFranqueados = new HashSet<PedidosFranqueado>();
            this.Stocks = new HashSet<Stock>();
            this.Vendas = new HashSet<Venda>();
        }
    
        public int fid { get; set; }
        public Nullable<int> nif { get; set; }
        public string nome { get; set; }
        public string morada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregasFranqueado> EntregasFranqueados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoVenda> HistoricoVendas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidosFranqueado> PedidosFranqueados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
