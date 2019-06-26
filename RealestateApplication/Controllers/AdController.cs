using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealestateApplication.Data;
using RealestateApplication.Models;

namespace RealestateApplication.Controllers
{
    public class AdController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _ctx;
        
        public AdController(UserManager<ApplicationUser> userManager, ApplicationDbContext ctx)
        {
            _userManager = userManager;
            _ctx = ctx;

        }
        public IActionResult GetAds()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                var List = _ctx.Ads.Where(p => p.UserId == user.Id);

                return View(List);
            }
        }
        // GET: Ad
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ad/Details/5
        public IActionResult ViewAd(int id)
        {
            var ad = _ctx.Ads.Find(id);
            return View(ad);
        }

        // GET: Ad/Create
        [HttpGet]
        public ActionResult AdCreate()
        {
            return View(new Ad());
        }

        // POST: Ad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdCreate(Ad ad)
        {
            try
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                ad.UserId = user.Id;
                ad.CreateDate = DateTime.Now;
                _ctx.Ads.Add(ad);
                await _ctx.SaveChangesAsync();
                return View("~/Views/Member/AdCreateMessage.cshtml");
            }
            catch
            {
                return RedirectToAction("Login","Account");
            }
        }

        // GET: Ad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ad/Edit/5
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

        // GET: Ad/Delete/5
        public ActionResult Delete(Ad ad)
        {
            _ctx.Ads.Remove(ad);
            return View();
        }

        // POST: Ad/Delete/5
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