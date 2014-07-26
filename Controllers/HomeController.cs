using System.Web.Mvc;
using Orchestra.DataLayer;
using Orchestra.Models.Divisions;
using Orchestra.Models.Home;
using Orchestra.Models.Layout;

namespace Orchestra.Controllers
{
    public class HomeController : Controller
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