namespace AircraftStore.Dal.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        
        public virtual Order Order { get; set; }
    }
}
