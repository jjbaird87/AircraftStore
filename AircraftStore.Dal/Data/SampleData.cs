using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Models;

namespace AircraftStore.Dal.Data
{
    public class SampleData : DropCreateDatabaseIfModelChanges<AirplaneStoreContext>
    {
        protected override void Seed(AirplaneStoreContext context)
        {
            var manufacturers = new List<AircraftManufacturer>
            {
                new AircraftManufacturer {Name = "ATR"},
                new AircraftManufacturer {Name = "Beech"},
                new AircraftManufacturer {Name = "Beechcraft"},
                new AircraftManufacturer {Name = "Boeing"},
                new AircraftManufacturer {Name = "Bombardier"},
                new AircraftManufacturer {Name = "Cessna"},
                new AircraftManufacturer {Name = "Pilatus"},
                new AircraftManufacturer {Name = "Piper"}
            };

            var types = new List<AircraftType>
            {
                new AircraftType {Name = "Piston Prop"},
                new AircraftType {Name = "Turbo Prop"},                
                new AircraftType {Name = "Small Business Jet"},
                new AircraftType {Name = "Medium Business Jet"},
                new AircraftType {Name = "Large Business Jet"},
                new AircraftType {Name = "Commercial Aircraft"}
            };

            new List<Aircraft>
            {
                new Aircraft
                {
                    Name = "ATR-42",
                    Description = "The ATR-42-500 is the first significantly improved version of the aircraft and features a revised interior, more powerful PW-127Es for a substantially increased cruising speed (565km/h/305kt) driving six blade propellers, a 1850km (1000nm) maximum range, the EFIS cockpit, elevators and rudders of the stretched ATR-72 (described separately), plus new brakes and landing gear and strengthened wing and fuselage for higher weights. The first ATR-42-500 delivery was in October 1995. ",
                    Type = types.Single(i => i.Name == "Turbo Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "ATR"),
                    CountryOfOrigin = "France and Italy",
                    CruisingSpeed = 243,
                    Engines = 2,
                    Pax = 42,
                    Range = 1000,
                    Price = 12.1M,
                    PhotoUrl = "https://s.graphiq.com/sites/default/files/1617/media/images/t2/ATR_42-500_306736.jpg",
                    CockpitPhotoUrl = "http://www.aviationexplorer.com/atr_42_turboprop_aircraft/Czech-Airlines-ATR-42-cockpit_photo.jpg",
                    CabinPhotoUrl = "http://www.aircraftcabinmanagement.com/uploads/features/gallery/image_41c271631f5e42f24528d28295c0a9e0ef07e37d.jpg"

                },
                new Aircraft
                {
                    Name = "60 Duke",
                    Description = "Since its appearance the Duke has been regarded as something of a hot ship, with its high performance in a relatively small package the main attraction. However, this image did not translate into anything other than modest sales because of the Duke's relatively complex systems (turbochargers and pressurisation among them) and high operating costs. ",
                    Type = types.Single(i => i.Name == "Turbo Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Beech"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 214,
                    Engines = 2,
                    Pax = 4,
                    Range = 1122,
                    Price = 0.22M,
                    PhotoUrl = "http://royalturbine.com/sites/royalturbine.com/files/banner/banner01.png",
                    CockpitPhotoUrl = "http://www.jetbrokers.com/images/BeechcraftDukeA60-P174c.jpg",
                    CabinPhotoUrl = "http://www.mullers.net/mike/duke/int-1n.jpg"
                },
                new Aircraft
                {
                    Name = "King Air 350",
                    Description = "The King Air 300 has been replaced by the 350, its major improvements being a stretched fuselage lengthened by 86cm (2ft 10in) and the addition of winglets. The latest member of the King Air family, it had its first flight in 1988, and has been in production since late 1989. The King Air 350C features a builtin airstair and a 132 x 132cm (52 x 52in) freight door. The 350 is also available in a range of special missions and military variants. ",
                    Type = types.Single(i => i.Name == "Turbo Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Beechcraft"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 307,
                    Engines = 2,
                    Pax = 15,
                    Range = 2031,
                    Price = 7.5M,
                    PhotoUrl =
                        "https://images.globalair.com/ganimages/generic/Twin%20Turbines/Beechcraft/King%20Air/350/Exterior/07_KingAir350_snFL-540_e_e.jpg",
                    CockpitPhotoUrl = "http://aas-augsburg.de/uploads/tx_templavoila/cockpit_350.jpg",
                    CabinPhotoUrl = "http://d16bsf97ryvc45.cloudfront.net/Media/2013/01/kingair_350er_interior.jpg"
                },
                new Aircraft
                {
                    Name = "737 BBJ",
                    Description = "The BBJ combines the Next Generation 737-700's airframe combined with the strengthened wing, fuselage centre section and landing gear of the larger and heavier 737-800, with three to 10 belly auxiliary fuel tanks. It features the Next Generation 737 advanced two crew six LCD screen EFIS avionics flightdeck, equipped with embedded dual GPS, TCAS, enhanced GPWS and Flight Dynamics head-up guidance system. Following their certification in September 2000, winglets became a standard option. ",
                    Type = types.Single(i => i.Name == "Large Business Jet"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Boeing"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 500,
                    Engines = 2,
                    Pax = 50,
                    Range = 4935,
                    Price = 47,
                    PhotoUrl = "https://c1.staticflickr.com/3/2668/4186375707_25b1b24458.jpg",
                    CockpitPhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Royal_Jet_Boeing_737-700_BBJ_Cockpit_Wedelstaedt.jpg",
                    CabinPhotoUrl = "http://air-ddf.kxcdn.com/wp-content/uploads/2012/03/120325-BBJ02-01.jpg"
                },
                new Aircraft
                {
                    Name = "Learjet 45",
                    Description = "Larger than the Learjet 31 and smaller than the 60, Learjet states that the 45's 1.50m (4.9ft) high and 1.55m (5.1ft) wide cabin will provide more head and shoulder room than any other aircraft in its class. The cabin is designed to accommodate double club seating, a galley and a full width aft rest room, while eight windows line each side of the cabin.\n\n" +
                                  "The flightdeck features a four screen (two primary flight displays and two multifunction displays) Honeywell Primus 1000 integrated avionics suite, while an APU is standard. ",
                    Type = types.Single(i => i.Name == "Medium Business Jet"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Bombardier"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 441,
                    Engines = 2,
                    Pax = 10,
                    Range = 2000,
                    Price = 2.7M,
                    PhotoUrl =
                        "https://s.graphiq.com/sites/default/files/1617/media/images/Bombardier_Learjet_45_XR_306716.jpg",
                    CockpitPhotoUrl = "http://www.altitudeaviation.com.au/images/lightbox/lear45/lear45_cockpit_hor_800.jpg",
                    CabinPhotoUrl = "http://www.charlestack.com/wp-content/uploads/2012/02/lear_cabin.jpg"
                },
                new Aircraft
                {
                    Name = "172",
                    Description = "Cessna re-engined the 172 with the Lycoming O-320-E as compared with the O-300 it had two less cylinders (and thus lower overhaul costs), a 200 hour greater TBO, improved fuel efficiency and more power. Even so, Cessna thought 172 production would be shortlived as the similarly powered but more modern 177 Cardinal was released at the same time. In spite of the Cardinal, the Lycoming powered 172 was a runaway success and easily outsold and outlived its intended replacement. ",
                    Type = types.Single(i => i.Name == "Piston Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Cessna"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 122,
                    Engines = 1,
                    Pax = 4,
                    Range = 575,
                    Price = 0.16M,
                    PhotoUrl = "http://www.aircraftcompare.com/aircraft_images/267.jpg",
                    CockpitPhotoUrl = "http://cdn.c.photoshelter.com/img-get2/I0000X.a_xG7punM/fit=1000x750/ccas09-a340-n628rk-8719.jpg",
                    CabinPhotoUrl = "http://www.aerosheep.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/c/e/cessna-172-cockpit-seat-cover-1996-later_1.jpg"
                },
                new Aircraft
                {
                    Name = "208 Grand Caravan",
                    Description = "The Caravan I has had a close association with US package freight specialist Federal Express (FedEx), on whose request Cessna especially developed two pure freight versions. The first of these was the 208A Cargomaster (40 delivered), the second was the stretched 208B Super Cargomaster (260 delivered). The first Super Cargomaster flew in 1986 and features a 1.22m (4ft) stretch and greater payload capacity, including an under fuselage cargo pannier. FedEx's aircraft lack cabin windows. ",
                    Type = types.Single(i => i.Name == "Turbo Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Cessna"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 184,
                    Engines = 1,
                    Pax = 9,
                    Range = 900,
                    Price = 2.2M,
                    PhotoUrl = "http://jaair.com/wp-content/uploads/2012/08/870ext.jpg",
                    CockpitPhotoUrl = "http://d16bsf97ryvc45.cloudfront.net/Media/2013/01/grand_caravan_cockpit.jpg",
                    CabinPhotoUrl = "http://www.aerosheep.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/c/e/cessna-208-cabin-seat-large-seat-cover-1996-later.jpg"
                },
                new Aircraft
                {
                    Name = "Citation X",
                    Description = "The design objectives behind the Citation X included transcontinental USA and trans Atlantic range in a mid size package that cruises faster than any other business jet available. This high speed cruise capability, which Cessna says is 105 to 210km/h (55 to 113kt) faster than other mid size corporate jet, means the X can save up to one hour's flight time on transcontinental US flights, flying from Los Angeles to New York with normal wind conditions in 4 hours 10 minutes. Because of its ability to cruise at high speed at high altitudes, Cessna also says the Citation X will consume less fuel than current jets on such a transcontinental flight. ",
                    Type = types.Single(i => i.Name == "Medium Business Jet"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Cessna"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 504,
                    Engines = 2,
                    Pax = 12,
                    Range = 3250,
                    Price = 21.5M,
                    PhotoUrl = "http://www.aircraftcompare.com/aircraft_images/1017.jpg",
                    CockpitPhotoUrl = "http://www.genav.com/filebin/images/aircraft-library/citxpan.jpg",
                    CabinPhotoUrl = "http://www.ijets.eu/wp-content/uploads/2006/10/Citation-X-Interior.jpg"
                },
                new Aircraft
                {
                    Name = "Citation II",
                    Description = "Major improvements were made to the design with the arrival of the Model S550 Citation S/II. Announced in October 1983, this improved version first flew on February 14 1984. Certification, including an exemption for single pilot operation, was granted that July. Improvements were mainly aerodynamic, including a new wing designed using supercritical technology developed for the Citation III (described separately), plus JT15D4B turbofans. The S/II initially replaced the II in production from 1984, but the II returned to the lineup from late 1985, and both variants remained in production until the introduction of the Bravo. ",
                    Type = types.Single(i => i.Name == "Small Business Jet"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Cessna"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 403,
                    Engines = 2,
                    Pax = 12,
                    Range = 1900,
                    Price = 0.7M,
                    PhotoUrl =
                        "https://s.graphiq.com/sites/default/files/1617/media/images/Cessna_Citation_CJ2_306502.jpg",
                    CockpitPhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a2/Cockpit_of_Cessna_525B_CitationJet_3.jpg",
                   CabinPhotoUrl = "http://cessna.txtav.com/~/media/images/aircraft/citation/m2/interior/collections/frost/img-citat-ext-int-m2-large-frost.ashx?h=361&la=en&w=935"
                },
                new Aircraft
                {
                    Name = "PC12",
                    Description = "Compared to the King Air 200 twin, its major competitor, the PC-12's most significant design feature is its use of a single PT6A-67B turboshaft. Internally the PC-12's cabin is also longer (by 6cm/2.4in) and wider (by 15cm/6in) than the King Air 200's, and the same height. The cockpit features EFIS displays and the PC-12 is certificated for single pilot operation while each PC-12 built features a standard cargo door in the rear fuselage. Weather radar is an option but has been fitted to all production aircraft thus far. From 1997 the increased 4.5 tonne MTOW has been standard. New, smaller winglets were introduced in 1998. ",
                    Type = types.Single(i => i.Name == "Turbo Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Pilatus"),
                    CountryOfOrigin = "Switzerland",
                    CruisingSpeed = 232,
                    Engines = 1,
                    Pax = 9,
                    Range = 2260,
                    Price = 3.6M,
                    PhotoUrl = "http://www.ainonline.com/sites/default/files/uploads/pilatusexteriorconfigurator.jpg",
                    CockpitPhotoUrl = "http://www.aopa.org/-/media/Images/AOPA/Home/News/All/2013/January/PC-12-Progress/1301pc12-avionics.jpg?w=640&h=380&as=1",
                    CabinPhotoUrl = "https://www.stratosjets.com/wordpress/wp-content/uploads/2014/08/Pilatus-PC-12-Interior.jpg"
                },
                new Aircraft
                {
                    Name = "PA-34 Seneca",
                    Description = "Handling and performance criticisms were addressed from the 1974 model year with the PA-34-200T Seneca II which introduced changes to the flight controls and, more importantly, two turbocharged Continental TSIO-360-Es. Piper originally planned that the follow-on PA-34-220T Seneca III would feature a T-tail, but these plans were dropped and the main changes introduced were counter rotating 165kW (220hp) TSIO-360s and a revised interior and instrument panel. Introduced in 1981, the Seneca III was replaced by New Piper's improved PA-34-220T Seneca IV in 1994 with aerodynamic refinements, axisymetric engine inlets and a revised interior. ",
                    Type = types.Single(i => i.Name == "Piston Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Piper"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 160,
                    Engines = 2,
                    Pax = 6,
                    Range = 700,
                    Price = 0.8M,
                    PhotoUrl = "http://www.flygfk.com/uploads/1/5/7/1/15710780/6700626_orig.jpg",
                    CockpitPhotoUrl = "http://skywayaircraft.com/wp-content/uploads/2013/10/7_34.jpg",
                    CabinPhotoUrl = "http://cdn-www.airliners.net/aviation-photos/photos/9/3/5/2159539.jpg"
                },
                new Aircraft
                {
                    Name = "PA-28 Cherokee",
                    Description = "Small numbers of Warriors, Dakotas and Archers were built in the early 1990s. The PA-28-181 Archer III, which features a new, streamlined cowling, was introduced in 1994. The 1999 models gained new paint, improved interior and a new avionics package. The PA-28-161 Warrior III features a new instrument panel and was introduced in late 1994. Since 1995 Piper has had new owners, and the brand has enjoyed a strong resurgence. ",
                    Type = types.Single(i => i.Name == "Piston Prop"),
                    Manufacturer = manufacturers.Single(i => i.Name == "Piper"),
                    CountryOfOrigin = "USA",
                    CruisingSpeed = 126,
                    Engines = 1,
                    Pax = 4,
                    Range = 522,
                    Price = 0.05M,
                    PhotoUrl = "http://www.everettaero.com/PA28.01.jpg",
                    CockpitPhotoUrl = "http://www.key.aero/central/images/gallery/466.jpg",
                    CabinPhotoUrl = "https://images.globalair.com/ganimages/generic/Singles/Piper/Cherokee/PA-28-180/Interior/64_PiperCherokee180_sn28-1619_i_i.jpg"
                }
            }.ForEach(a => context.Aircraft.Add(a));            
        }
    }
}
