using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Töötaja
    {
        [Key]
        public Guid TöötajaId { get; set; }
        public string Eesnimi { get; set; }
        public string Perenimi { get; set; }
        public int Isikukood { get; set; }
        public string KontaktAadress { get; set; }
        public int KontaktTel { get; set; }

        public string KontaktEmail { get; set; }
        public DateTime TöölAl { get; set; }
        public DateTime? TöölKuni { get; set; }

        public string? Kommentaar { get; set; }


        // Foreign key properties to reference with Branch Office
        public Harukontor Harukontori { get; set; }
        public Guid HarukontoriId { get; set; }

        // Navigation property to represent the relationship with Job Titles
        public ICollection<Ametinimetused> Ametinimetuse { get; set; } = new List<Ametinimetused>();

        // Navigation property to represent the relationship with Children
        public ICollection<Lapsed> Lapseds { get; set; } = new List<Lapsed>();

        // Navigation property to represent the relationship with Vacations
        public ICollection<Puhkused> Puhkuseds { get; set; } = new List<Puhkused>();

        // Navigation property to represent the relationship with SickLeaves
        public ICollection<Haiguslehed> Haigusleheds { get; set; } = new List<Haiguslehed>();

        // Navigation property to represent the relationship with AccessPermissions
        public ICollection<Ligipääsuload> Ligipääsuloads { get; set; } = new List<Ligipääsuload>();

        // Navigation property to represent the relationship with HealthInspection
        public ICollection<Tervisekontroll> Tervisekontrolls { get; set; } = new List<Tervisekontroll>();

        // Navigation property to represent the relationship with Rental
        public ICollection<Laenutus> Laenutus { get; set; } = new List<Laenutus>();


    }

}