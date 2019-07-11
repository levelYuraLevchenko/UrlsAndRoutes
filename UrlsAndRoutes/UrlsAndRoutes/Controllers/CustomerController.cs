using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        [Route("Users/Add/{user}/{id}")]

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}