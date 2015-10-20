using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Models;

namespace AircraftStore.Mvc.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        readonly AirplaneStoreContext _db = new AirplaneStoreContext();

        public ActionResult Index()
        {
            // Get most popular albums
            var aircraft = GetTopSellingAircraft(6);
            return View(aircraft);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";     

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<Aircraft> GetTopSellingAircraft(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return _db.Aircraft
                .OrderByDescending(a => a.OrderDetails.Count)
                .Take(count)
                .ToList();
        }
    }
}