using System.Web.Mvc;

namespace Orchestra.Site.Models.Utilities
{
    public class StandardContoller : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled || !(filterContext.Exception is ResourceNotFoundException))
            {
                return;
            }

            filterContext.ExceptionHandled = true;
            filterContext.Result = HttpNotFound();
        }
    }
}