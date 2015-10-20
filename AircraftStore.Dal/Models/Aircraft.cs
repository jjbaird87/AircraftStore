using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AircraftStore.Dal.Models
{
    public class Aircraft
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Aircraft name is required")]
        [DisplayName("Aircraft Name")]
        [StringLength(30)]
        [ScaffoldColumn(false)]
        public string Name { get; set; }

        [Browsable(false)]
        public int ManufacturerId { get; set; }        
        public virtual AircraftManufacturer Manufacturer { get; set; }

        [Browsable(false)]
        public int TypeId { get; set; }        
        public virtual AircraftType Type { get; set; }

        [DisplayName("Country Of Origin")]
        [StringLength(30)]
        public string CountryOfOrigin { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [DisplayName("Passengers")]
        public int Pax { get; set; }

        public int Range { get; set; }        

        [DisplayName("Passengers")]
        public double CruisingSpeed { get; set; }

        [DisplayName("Weight")]
        public double  Zfw { get; set; }

        public int Engines { get; set; }

        [StringLength(1024)]
        public string PhotoUrl { get; set; }

        [StringLength(1024)]
        public string CabinPhotoUrl { get; set; }

        [StringLength(1024)]
        public string CockpitPhotoUrl { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

        [DisplayName("More Info")]
        public string MoreInfoUrl { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
