using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_test.Controllers
{
    public class GulController : Controller
    {
        // GET: GulController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GulController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GulController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GulController/Create
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

        // GET: GulController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GulController/Edit/5
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

        // GET: GulController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GulController/Delete/5
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
