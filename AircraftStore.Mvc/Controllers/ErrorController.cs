using System.Web.Mvc;

namespace AircraftStore.Mvc.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
            return View();
        }
    }
}