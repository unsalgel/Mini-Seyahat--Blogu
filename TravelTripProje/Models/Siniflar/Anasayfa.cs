using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int AnasayfaID { get; set; }
        [StringLength(200)]
        public string AnasayfaBaslik { get; set; }
        [StringLength(500)]
        public string AnasayfaAciklama { get; set; }
    }
}