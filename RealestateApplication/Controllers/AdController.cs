using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealestateApplication.Data;
using RealestateApplication.Models;
using RealestateApplication.Models.Images;

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
        public async Task<IActionResult> AdCreate(Ad ad, IEnumerable<IFormFile> images)
        {
            try
            {
                List<byte[]> _images = new List<byte[]>();
                foreach (var img in images)
                {
                    using (var stream = new MemoryStream())
                    {
                        await img.CopyToAsync(stream);
                        _images.Add(stream.ToArray());
                    }
                }
                
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                ad.UserId = user.Id;
                ad.CreateDate = DateTime.Now;
                _ctx.Ads.Add(ad);
                await _ctx.SaveChangesAsync();
                
                foreach (var item in _images)
                {
                    Images im = new Images();
                    im.Image = item;
                    im.IdOfCorrespondingAd = ad.Id;
                    _ctx.Images.Add(im);
                    await _ctx.SaveChangesAsync();

                }
                return RedirectToAction("GetAds", "Ad");
            }
            catch
            {
                return RedirectToAction("Login","Account");
            }
        }

        // GET: Ad/Edit/5
        public ActionResult EditF(int id)
        {
            Ad ad = _ctx.Ads.Find(id);
            return View("AdEdit", ad);
        }
        public async Task<ActionResult> Edit(Ad ad)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ad.UserId = user.Id;
            _ctx.Ads.Update(ad);
                await _ctx.SaveChangesAsync();
            return RedirectToAction("GetAds", "Ad");

        }
        
        // GET: Ad/Delete/5
        public async Task<IActionResult> Delete(Ad ad)
        {
            _ctx.Ads.Remove(ad);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("GetAds", "Ad");
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