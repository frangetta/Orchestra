using System.Web.Mvc;
using Orchestra.DataLayer;
using Orchestra.Site.Models.Divisions;
using Orchestra.Site.Models.Home;
using Orchestra.Site.Models.Layout;
using Orchestra.Site.Models.Utilities;

namespace Orchestra.Site.Controllers
{
    public class HomeController : StandardContoller
    {
        private readonly IHomeViewModelBuilder homeViewModelBuilder;

        public HomeController()
        {
            homeViewModelBuilder = new HomeViewModelBuilder(new LayoutModelBuilder(new DivisionRepository(new OrchestraDatabaseContext())));
        }

        public ActionResult Index()
        {
            var model = homeViewModelBuilder.Build();
            return View(model);
        }


	}
}