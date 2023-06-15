using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Haiguslehed
    {

        [Key]
        public Guid HaigusleheId { get; set; }
        public bool ÕigusHaiguslehele { get; set; }
        public int HaiguspäeviKokku { get; set; }
        public DateTime HaigusleheAlgus { get; set; }
        public DateTime HaigusleheLõpp { get; set; }
        public int Kasutatudhaigusepäevi { get; set; }
        public int AllesolevaidHaigusepäevi { get; set; }
        public int AegunudHaigusepäevi { get; set; }
        public string? Kommentaar { get; set; }

        //Foreign key properties to reference Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}