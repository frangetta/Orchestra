using System.Web.Mvc;
using Orchestra.DataLayer;
using Orchestra.Site.Models.Divisions;
using Orchestra.Site.Models.Layout;
using Orchestra.Site.Models.Utilities;

namespace Orchestra.Site.Controllers
{
    public class DivisionController : StandardContoller
    {
        private readonly IDivisionViewModelBuilder divisionViewModelBuilder;
        public DivisionController()
        {
            var divisionRepository = new DivisionRepository(new OrchestraDatabaseContext());
            divisionViewModelBuilder = new DivisionViewModelBuilder(new DivisionValidator(divisionRepository), new LayoutModelBuilder(divisionRepository));
        }

        public ActionResult Item(string path)
        {
            var model = divisionViewModelBuilder.Build(path);
            return View(model);
        }
    }
}