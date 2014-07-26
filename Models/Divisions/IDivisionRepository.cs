using System.Collections.Generic;
using Orchestra.DataLayer;

namespace Orchestra.Models.Divisions
{
    public interface IDivisionRepository
    {
        IList<Division> GetMenuDivisions();
    }
}