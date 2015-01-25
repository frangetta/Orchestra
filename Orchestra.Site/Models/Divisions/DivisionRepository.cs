using System.Collections.Generic;
using System.Linq;
using Orchestra.DataLayer;

namespace Orchestra.Site.Models.Divisions
{
    public class DivisionRepository : IDivisionRepository
    {
        private readonly IDatabaseContext databaseContext;

        public DivisionRepository(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IList<Division> GetMenuDivisions()
        {
            return databaseContext.GetTable<Division>()
                .Where(e => e.Publish && e.ShowMenu)
                .OrderBy(e => e.Priority)
                .ToArray();
        }

        public Division FindDivisionByPath(string path)
        {
            return databaseContext.GetTable<Division>()
                .FirstOrDefault(e => e.Path == path && e.Publish);
        }
    }
}