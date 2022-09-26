

using Microsoft.EntityFrameworkCore;
using PenaltyCalculationPeterGeorge.Models;

namespace PenaltyCalculationPeterGeorge.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
            
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {


        }


        #region Dbset
            public virtual DbSet<Country> Countries { get; set; }        
            public virtual DbSet<CountryWeekEnds> CountryWeekEnds { get; set; }
           

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // for chain with base for Idntity 
            base.OnModelCreating(modelBuilder);
        }
    }
}
