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
    
    public partial class Siniflar
    {
        public Siniflar()
        {
            this.Ogrenciler = new HashSet<Ogrenciler>();
        }
    
        public int ID { get; set; }
        public string SinifAd { get; set; }
        public System.DateTime ATarihi { get; set; }
        public System.DateTime KTarihi { get; set; }
        public int OgretmenID { get; set; }
        public string Aciklama { get; set; }
    
        public virtual ICollection<Ogrenciler> Ogrenciler { get; set; }
        public virtual Ogretmenler Ogretmenler { get; set; }
    }
}
