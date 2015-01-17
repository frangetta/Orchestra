using Orchestra.Site.Models.Layout;

namespace Orchestra.Site.Models.Divisions
{
    public class DivisionViewModelBuilder : IDivisionViewModelBuilder
    {
        private readonly IDivisionValidator divisionValidator;
        private readonly ILayoutModelBuilder layoutModelBuilder;

        public DivisionViewModelBuilder(IDivisionValidator divisionValidator, ILayoutModelBuilder layoutModelBuilder)
        {
            this.divisionValidator = divisionValidator;
            this.layoutModelBuilder = layoutModelBuilder;
        }

        public DivisionViewModel Build(string path)
        {
            var division = divisionValidator.Validate(path);
            var layoutModel = layoutModelBuilder.Build();

            return new DivisionViewModel(layoutModel, division);
        }
    }
}