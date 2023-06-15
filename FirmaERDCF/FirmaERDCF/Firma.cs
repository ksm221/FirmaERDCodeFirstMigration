using FirmaERDCF;
using System.ComponentModel.DataAnnotations;

namespace FirmaERDCF
{

    public class Firma
    {
        [Key]
        public Guid FirmaId { get; set; }
        public string FirmaRegNr { get; set; }
        public string Nimi { get; set; }
        public string Lühinimi { get; set; }
        public string Koduleht { get; set; }
        public string Aadress { get; set; }
        public string Kontaktisik { get; set; }
        public int KontaktTel { get; set; }
        public string KontaktEmail { get; set; }
        public string? Kommentaar { get; set; }

        // Navigation property to represent the relationship with branch offices
        public ICollection<Harukontor> Harukontors { get; set; } = new List<Harukontor>();

    }
}