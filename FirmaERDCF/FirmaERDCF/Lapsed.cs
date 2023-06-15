using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{

    public class Lapsed
    {

        [Key]
        public Guid LapseId { get; set; }
        public string LapseEesnimi { get; set; }
        public string LapsePerenimi { get; set; }
        public DateTime LapseSünniaeg { get; set; }
        public int LapseVanus { get; set; }
        public string? Kommentaar { get; set; }

        //Foreign key properties to reference Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}