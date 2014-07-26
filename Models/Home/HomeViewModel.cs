using Orchestra.Models.Layout;

namespace Orchestra.Models.Home
{
    public class HomeViewModel : ILayoutModelContainer
    {
        public HomeViewModel(LayoutModel layoutModel)
        {
            LayoutModel = layoutModel;
        }

        public LayoutModel LayoutModel { get; private set; }
    }
}