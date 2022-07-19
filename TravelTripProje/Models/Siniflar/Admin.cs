using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string Kullanici { get; set; }
        public string SİFRE { get; set; }
    }
}