using Orchestra.DataLayer;

namespace Orchestra.Site.Models.Divisions
{
    public interface IDivisionValidator
    {
        Division Validate(string path);
    }
}