using System.Collections.Generic;
using Orchestra.DataLayer;

namespace Orchestra.Site.Models.Divisions
{
    public interface IDivisionRepository
    {
        IList<Division> GetMenuDivisions();
        Division FindDivisionByPath(string path);
    }
}