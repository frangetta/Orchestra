using Orchestra.Site.Models.Layout;

namespace Orchestra.Site.Models.Home
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