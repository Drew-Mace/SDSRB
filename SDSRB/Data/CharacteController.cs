using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SDSRB.Data
{
    public class CharacteController : Controller
    {
        // GET: Characte
        public ActionResult Index()
        {
            return View();
        }

        // GET: Characte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Characte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Characte/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Characte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Characte/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Characte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Characte/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}