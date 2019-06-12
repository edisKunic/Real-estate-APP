using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealestateApplication.Data;

namespace RealestateApplication.Controllers
{
    public class HomeAdController : Controller
    {
        private ApplicationDbContext _ctx;
        // GET: HomeAd
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeAd/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeAd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeAd/Create
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

        // GET: HomeAd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeAd/Edit/5
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

        // GET: HomeAd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeAd/Delete/5
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