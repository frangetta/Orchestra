using System.Data.Entity;

namespace Orchestra.DataLayer
{
    public class OrchestraDatabaseContext : DbContext
    {
        public OrchestraDatabaseContext() : base("name=OrchestraConnectionString")
        {
        }

        public DbSet<Division> Divisions { get; set; }
    }
}