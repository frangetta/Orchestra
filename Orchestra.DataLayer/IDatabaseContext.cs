using System.Linq;

namespace Orchestra.DataLayer
{
    public interface IDatabaseContext
    {
        IQueryable<T> GetTable<T>() where T : class;
        T Insert<T>(T entity) where T : class;
    }
}