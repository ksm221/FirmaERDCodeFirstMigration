using Microsoft.EntityFrameworkCore;

namespace FirmaERDCF.Data
{
    public class DataContext : DbContext
    {
        //konstruktor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //tulemuste nägemiseks dbset
        public DbSet<Firma> Firmas => Set<Firma>();

    }
}
