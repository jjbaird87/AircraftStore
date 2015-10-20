using System.Linq;
using System.Web.Mvc;
using AircraftStore.Dal.Context;

namespace AircraftStore.Mvc.Controllers
{
    public class StoreController : Controller
    {
        private readonly AirplaneStoreContext _db = new AirplaneStoreContext();

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            var aircraft = _db.Aircraft.Find(id);
            return View(aircraft);
        }

        // GET: Store/Create
        public ActionResult Browse(int id)
        {
            var aircraftType = _db.AircraftTypes.Include("Aircraft").Single(g => g.Id == id);
            return View(aircraftType);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult TypeMenu()
        {
            var types = _db.AircraftTypes.ToList();
            return PartialView(types);
        }
    }
}
