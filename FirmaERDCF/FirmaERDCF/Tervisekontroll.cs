using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Tervisekontroll
    {
        [Key]
        public Guid TerviseKontrolliId { get; set; }
        public bool TerviseKontrolliVajadus { get; set; }
        public DateTime? EelmiseTerviseKontrolliKp { get; set; }
        public DateTime? UueTerviseKontrolliKp { get; set; }
        public string? Kommentaar { get; set; }

        // Foreign key properties to reference Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}