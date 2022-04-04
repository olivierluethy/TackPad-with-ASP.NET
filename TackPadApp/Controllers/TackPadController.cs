using Microsoft.AspNetCore.Mvc;
using TackPadApp.Data;
using TackPadApp.Models;

namespace TackPadApp.Controllers
{
    public class TackPadController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TackPadController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<TackPad> objTackPadList = _db.TackPad;
            return View(objTackPadList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TackPad obj)
        {
            _db.TackPad.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var tackpadFromDb = _db.TackPad.Find(id);

            if(tackpadFromDb == null)
            {
                return NotFound();
            }

            return View(tackpadFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TackPad obj)
        {
            if (ModelState.IsValid)
            {
                _db.TackPad.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var tackpadFromDb = _db.TackPad.Find(id);

            if(tackpadFromDb == null)
            {
                return NotFound();
            }
            return View(tackpadFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(TackPad obj)
        {
            if (ModelState.IsValid)
            {
                _db.TackPad.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
