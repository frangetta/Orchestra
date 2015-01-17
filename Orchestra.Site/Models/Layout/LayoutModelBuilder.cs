using Orchestra.Site.Models.Divisions;

namespace Orchestra.Site.Models.Layout
{
    public class LayoutModelBuilder : ILayoutModelBuilder
    {
        private readonly IDivisionRepository divisionRepository;

        public LayoutModelBuilder(IDivisionRepository divisionRepository)
        {
            this.divisionRepository = divisionRepository;
        }

        public LayoutModel Build()
        {
            var menuDivisions = divisionRepository.GetMenuDivisions();
            return new LayoutModel(menuDivisions);
        }
    }
}