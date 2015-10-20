using System.Data.Entity;
using AircraftStore.Dal.Models;

namespace AircraftStore.Dal.Context
{
    public class AirplaneStoreContext : DbContext
    {
        public AirplaneStoreContext() : base("name=AirplaneStoreContext")
        {            
        }

        public DbSet<AircraftManufacturer> AircraftManufacturers { get; set; }
        public DbSet<AircraftType> AircraftTypes { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
