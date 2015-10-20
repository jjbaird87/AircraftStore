using System;
using System.ComponentModel.DataAnnotations;

namespace AircraftStore.Dal.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }

        public string CartId { get; set; }

        public int AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }
        
    }
}
