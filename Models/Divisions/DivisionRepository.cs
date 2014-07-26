using System.Collections.Generic;
using System.Linq;
using Orchestra.DataLayer;

namespace Orchestra.Models.Divisions
{
    public class DivisionRepository : IDivisionRepository
    {
        private readonly OrchestraDatabaseContext orchestraDatabaseContext;

        public DivisionRepository(OrchestraDatabaseContext orchestraDatabaseContext)
        {
            this.orchestraDatabaseContext = orchestraDatabaseContext;
        }

        public IList<Division> GetMenuDivisions()
        {
            return orchestraDatabaseContext.Divisions
                .Where(e => e.Publish && e.ShowMenu)
                .OrderBy(e => e.Priority)
                .ToArray();
        }
    }
}