using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaERDCF
{
    public class Ligipääsuload
    {

        [Key]
        public Guid LigipääsuloaId { get; set; }
        public bool LigipääsuÕigus { get; set; }
        public string LigipääsuTase { get; set; }
        public DateTime ligipääsuAlgus { get; set; }
        public DateTime LigipääsuLõpp { get; set; }
        public string? Kommentaar { get; set; }

        //Foreign key properties to reference Employee
        public Töötaja Töötaja { get; set; }
        public Guid TöötajaId { get; set; }
    }
}