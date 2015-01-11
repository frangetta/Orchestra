using System.Web.Mvc;
using Orchestra.DataLayer;
using Orchestra.Models.Divisions;
using Orchestra.Models.Layout;

namespace Orchestra.Controllers
{
    public class DivisionController : Controller
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