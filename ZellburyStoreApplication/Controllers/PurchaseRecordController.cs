using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZellburyStoreApplication.Controllers
{
    public class PurchaseRecordController : Controller
    {
        // GET: PurchaseRecordController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PurchaseRecordController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PurchaseRecordController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseRecordController/Create
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

        // GET: PurchaseRecordController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseRecordController/Edit/5
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

        // GET: PurchaseRecordController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseRecordController/Delete/5
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
