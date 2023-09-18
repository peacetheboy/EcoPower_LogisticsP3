using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoPower_Logistics.Controllers
{
    public class DeviceController : Controller
    {
        // GET: DeviceController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeviceController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeviceController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceController1/Create
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

        // GET: DeviceController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeviceController1/Edit/5
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

        // GET: DeviceController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeviceController1/Delete/5
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
