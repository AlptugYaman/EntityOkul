//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webEntityOkul
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenciler
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string TCKNo { get; set; }
        public decimal Tutar { get; set; }
        public byte TaksitSayisi { get; set; }
        public int SinifID { get; set; }
    
        public virtual Siniflar Siniflar { get; set; }
    }
}
