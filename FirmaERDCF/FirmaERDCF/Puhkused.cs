using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Puhkused
    {

        [Key]
        public Guid PuhkuseId { get; set; }
        public int PuhkusePäevi { get; set; }
        public DateTime PuhkuseAlgus { get; set; }
        public DateTime PuhkuseLõpp { get; set; }
        public int KasutatudPäevad { get; set; }
        public int AllesolevadPäevad { get; set; }
        public int AegunudPuhkusePäevad { get; set; }
        public string? Kommentaar { get; set; }

        //Foreign key relationships with Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}