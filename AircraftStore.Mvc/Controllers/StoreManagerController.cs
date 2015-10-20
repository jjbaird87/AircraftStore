using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Models;

namespace AircraftStore.Mvc.Controllers
{
    [Authorize (Roles="Admin")]
    public class StoreManagerController : Controller
    {
        private readonly AirplaneStoreContext _db = new AirplaneStoreContext();

        // GET: StoreManager
        public ActionResult Index()
        {
            var aircraft = _db.Aircraft.Include(a => a.Manufacturer).Include(a => a.Type);
            return View(aircraft);
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var aircraft = _db.Aircraft.Find(id);
            if (aircraft == null)
            {
                return HttpNotFound();
            }
            return View(aircraft);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.TypeId = new SelectList(_db.AircraftTypes, "Id", "Name");
            ViewBag.ManufacturerId = new SelectList(_db.AircraftManufacturers, "Id", "Name");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _db.Aircraft.Add(aircraft);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TypeId = new SelectList(_db.AircraftTypes, "Id", "Name", aircraft.TypeId);
            ViewBag.ManufacturerId = new SelectList(_db.AircraftManufacturers, "Id", "Name", aircraft.ManufacturerId);

            return View(aircraft);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var aircraft = _db.Aircraft.Find(id);
            if (aircraft == null)
            {
                return HttpNotFound();
            }
            ViewBag.TypeId = new SelectList(_db.AircraftTypes, "Id", "Name", aircraft.TypeId);
            ViewBag.ManufacturerId = new SelectList(_db.AircraftManufacturers, "Id", "Name", aircraft.ManufacturerId);
            return View(aircraft);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,Name,CountryOfOrigin,Pax,Range,CruisingSpeed,Zfw,Engines,PhotoUrl,Price,MoreInfoUrl"
                )] Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(aircraft).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TypeId = new SelectList(_db.AircraftTypes, "Id", "Name", aircraft.TypeId);
            ViewBag.ManufacturerId = new SelectList(_db.AircraftManufacturers, "Id", "Name", aircraft.ManufacturerId);
            return View(aircraft);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var aircraft = _db.Aircraft.Find(id);
            if (aircraft == null)
            {
                return HttpNotFound();
            }
            return View(aircraft);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var aircraft = _db.Aircraft.Find(id);
            _db.Aircraft.Remove(aircraft);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
