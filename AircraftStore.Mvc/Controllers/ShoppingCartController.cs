using System.Linq;
using System.Web.Mvc;
using AircraftStore.Dal.Context;
using AircraftStore.Mvc.Models;
using AircraftStore.Mvc.ViewModels;

namespace AircraftStore.Mvc.Controllers
{
    public class ShoppingCartController : Controller
    {
        readonly AirplaneStoreContext _db = new AirplaneStoreContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(HttpContext);

            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            return View(viewModel);
        }

        public ActionResult AddToCart(int id)
        {
            // Retrieve the aircraft from the database
            var addedAircraft = _db.Aircraft
                .Single(aircraft => aircraft.Id == id);

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(HttpContext);
            cart.AddToCart(addedAircraft);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }
        //
        // AJAX: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = ShoppingCart.GetCart(HttpContext);

            // Get the name of the album to display confirmation
            string aircraftName = _db.Carts
                .Single(item => item.RecordId == id).Aircraft.Name;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(aircraftName) +
                    " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }
        //
        // GET: /ShoppingCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}
