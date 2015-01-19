using System.Web.Mvc;
using Orchestra.Site.Models.Divisions;
using Orchestra.Site.Models.Utilities;

namespace Orchestra.Site.Controllers
{
    public class DivisionController : StandardContoller
    {
        private readonly IDivisionViewModelBuilder divisionViewModelBuilder;

        public DivisionController(IDivisionViewModelBuilder divisionViewModelBuilder)
        {
            this.divisionViewModelBuilder = divisionViewModelBuilder;
        }

        public ActionResult Item(string path)
        {
            var model = divisionViewModelBuilder.Build(path);
            return View(model);
        }
    }
}