namespace Orchestra.Site.Models.Divisions
{
    public interface IDivisionViewModelBuilder
    {
        DivisionViewModel Build(string path);
    }
}