//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emlak_Sitesi_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ilan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ilan()
        {
            this.yorums = new HashSet<yorum>();
        }
    
        public int ilanID { get; set; }
        public string ilanBaslik { get; set; }
        public double ilanFiyat { get; set; }
        public System.DateTime tarih { get; set; }
        public int kategoriID { get; set; }
        public int islemID { get; set; }
        public int kullaniciID { get; set; }
        public string ilanAdres { get; set; }
        public string ilanAciklama { get; set; }
        public Nullable<int> ilanOdaSayisi { get; set; }
        public Nullable<double> ilanBinaYasi { get; set; }
        public Nullable<int> ilanBinaKat { get; set; }
        public Nullable<int> ilanBinaKacinciKat { get; set; }
        public string ilanBinaisitma { get; set; }
        public string ilanBinaEsyaliMi { get; set; }
    
        public virtual islem islem { get; set; }
        public virtual kategori kategori { get; set; }
        public virtual kullanici kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yorum> yorums { get; set; }
    }
}