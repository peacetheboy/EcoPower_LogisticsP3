using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoPower_Logistics.Controllers
{
    public class ZoneController : Controller
    {
        // GET: ZoneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ZoneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZoneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZoneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZoneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZoneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZoneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZoneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
