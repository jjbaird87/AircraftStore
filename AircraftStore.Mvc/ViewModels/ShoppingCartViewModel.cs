using System.Collections.Generic;
using AircraftStore.Dal.Models;

namespace AircraftStore.Mvc.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
