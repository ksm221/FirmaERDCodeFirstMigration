using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Laenutus
    {
        [Key]
        public Guid LaenutuseId { get; set; }
        public string EsemeNimi { get; set; }
        public DateTime LaenutuseAlgus { get; set; }
        public DateTime? LaenutuseLõpp { get; set; }
        public string? Kommentaar { get; set; }

        //Foreign key properties to reference Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}