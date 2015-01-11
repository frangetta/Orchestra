using Orchestra.DataLayer;

namespace Orchestra.Models.Divisions
{
    public interface IDivisionValidator
    {
        Division Validate(string path);
    }
}