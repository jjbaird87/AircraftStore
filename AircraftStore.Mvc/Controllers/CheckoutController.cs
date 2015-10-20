using System;
using System.Linq;
using System.Web.Mvc;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Models;
using AircraftStore.Mvc.Models;

namespace AircraftStore.Mvc.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly AirplaneStoreContext _db = new AirplaneStoreContext();
        private const string PromoCode = "FREE";

        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }

        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                order.Username = User.Identity.Name;
                order.OrderDate = DateTime.Now;

                //Save Order
                _db.Orders.Add(order);
                _db.SaveChanges();
                //Process the order
                var cart = ShoppingCart.GetCart(HttpContext);
                cart.CreateOrder(order);

                return RedirectToAction("Complete",
                    new { id = order.OrderId });
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = _db.Orders.Any(
                o => o.OrderId == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}