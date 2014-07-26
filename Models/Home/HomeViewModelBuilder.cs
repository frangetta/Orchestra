using Orchestra.Models.Layout;

namespace Orchestra.Models.Home
{
    public class HomeViewModelBuilder : IHomeViewModelBuilder
    {
        private readonly ILayoutModelBuilder layoutModelBuilder;

        public HomeViewModelBuilder(ILayoutModelBuilder layoutModelBuilder)
        {
            this.layoutModelBuilder = layoutModelBuilder;
        }

        public HomeViewModel Build()
        {
            var layoutModel = layoutModelBuilder.Build();
            return new HomeViewModel(layoutModel);
        }
    }
}