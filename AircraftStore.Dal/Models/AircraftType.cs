using System.Collections.Generic;

namespace AircraftStore.Dal.Models
{
    public class AircraftType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Aircraft> Aircraft { get; set; } 
    }
}
