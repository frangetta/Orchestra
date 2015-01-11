namespace Orchestra.Models.Divisions
{
    public interface IDivisionViewModelBuilder
    {
        DivisionViewModel Build(string path);
    }
}