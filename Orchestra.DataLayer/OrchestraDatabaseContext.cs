using System.Data.Entity;

namespace Orchestra.DataLayer
{
    public class OrchestraDatabaseContext : DbContext
    {
        public DbSet<Division> Divisions { get; set; }
    }
}