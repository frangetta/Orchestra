using System.Web.Mvc;
using Orchestra.Site.Models.Home;
using Orchestra.Site.Models.Utilities;

namespace Orchestra.Site.Controllers
{
    public class HomeController : StandardContoller
    {
        private readonly IHomeViewModelBuilder homeViewModelBuilder;

        public HomeController(IHomeViewModelBuilder homeViewModelBuilder)
        {
            this.homeViewModelBuilder = homeViewModelBuilder;
        }

        public ActionResult Index()
        {
            var model = homeViewModelBuilder.Build();
            return View(model);
        }


	}
}