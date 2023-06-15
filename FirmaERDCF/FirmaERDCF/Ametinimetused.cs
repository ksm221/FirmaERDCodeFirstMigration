using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Ametinimetused
    {
        [Key]
        public Guid AmetinimetuseId { get; set; }
        public string Ametinimetus { get; set; }
        public DateTime AmetisAl { get; set; }
        public DateTime? AmetisKuni { get; set; }
        public string Osakond { get; set; }
        public string OtseseÜlemuseEesnimi { get; set; }
        public string OtseseÜlemusePerenimi { get; set; }
        public int OtseseÜlemuseKontakttel { get; set; }
        public string OtsesÜlemuseEpost { get; set; }
        public string? Kommentaar { get; set; }

        // Foreign key properties to reference Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}