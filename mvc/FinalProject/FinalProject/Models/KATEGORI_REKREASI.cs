//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KATEGORI_REKREASI
    {
        public KATEGORI_REKREASI()
        {
            this.REKREASIs = new HashSet<REKREASI>();
        }
    
        public int ID_Kategori_Rekreasi { get; set; }
        public string Kategori_Rekreasi1 { get; set; }
    
        public virtual ICollection<REKREASI> REKREASIs { get; set; }
    }
}
