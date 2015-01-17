using Orchestra.DataLayer;
using Orchestra.Site.Models.Layout;

namespace Orchestra.Site.Models.Divisions
{
    public class DivisionViewModel : ILayoutModelContainer
    {
        public DivisionViewModel(LayoutModel layoutModel, Division division)
        {
            LayoutModel = layoutModel;
            Division = division;
        }

        public LayoutModel LayoutModel { get; private set; }
        public Division Division { get; private set; }
    }
}