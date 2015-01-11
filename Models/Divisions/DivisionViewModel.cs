using Orchestra.DataLayer;
using Orchestra.Models.Layout;

namespace Orchestra.Models.Divisions
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