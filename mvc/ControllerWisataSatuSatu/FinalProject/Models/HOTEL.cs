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
    
    public partial class HOTEL
    {
        public int ID_Hotel { get; set; }
        public string Nama_Hotel { get; set; }
        public string Alamat_Hotel { get; set; }
        public string Telpon_Hotel { get; set; }
        public byte[] Foto_Hotel { get; set; }
        public string Website_Hotel { get; set; }
        public Nullable<int> Bintang_Hotel { get; set; }
        public string Latitude_Hotel { get; set; }
        public string Longitude_Hotel { get; set; }
    }
}
