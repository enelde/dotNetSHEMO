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
    
    public partial class KATEGORI_WISATA
    {
        public KATEGORI_WISATA()
        {
            this.WISATAs = new HashSet<WISATA>();
        }
    
        public int ID_Kategori_Wisata { get; set; }
        public string Kategori_Wisata1 { get; set; }
    
        public virtual ICollection<WISATA> WISATAs { get; set; }
    }
}