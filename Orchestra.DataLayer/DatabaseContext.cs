using System.Linq;

namespace Orchestra.DataLayer
{
    public class DatabaseContext : IDatabaseContext
    {
        private readonly OrchestraDatabaseContext databaseContext;

        public DatabaseContext(OrchestraDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IQueryable<T> GetTable<T>() where T : class
        {
            return databaseContext.Set<T>();
        }

        public T Insert<T>(T entity) where T : class
        {
            return databaseContext.Set<T>().Add(entity);
        }
    }
}