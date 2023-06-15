using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FirmaERDCF
{
    public class Harukontor
    {
        [Key]
        public Guid HaruKontoriId { get; set; }
        public int HarukontoriRegNr { get; set; }
        public string Nimi { get; set; }
        public string Lühinimi { get; set; }
        public string Koduleht { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public int KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
        public string? Kommentaar { get; set; }

        // Foreign key property to reference the associated company
        public Guid FirmaId { get; set; }
        public Firma Firma { get; set; }

        // Navigation property to represent the relationship with employees
        public ICollection<Töötaja> Töötajas { get; set; } = new List<Töötaja>();
    }
}