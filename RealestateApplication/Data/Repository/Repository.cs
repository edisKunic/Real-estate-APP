using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RealestateApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealestateApplication.Data
{
    public class Repository
    {/*
        private ApplicationDbContext _ctx;
        private readonly UserManager<ApplicationUser> _userManager;
        public Repository(UserManager<ApplicationUser> userManager, ApplicationDbContext ctx)
        {
            _userManager = userManager;
            _ctx = ctx;
        }
        //public Ad GetAd(int id) {
            
        //}
        //public List<Ad> GetAllPost(int id) { }
        public bool AddAd(Ad ad) {
            try
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                ad.UserId = user.Id;
                _ctx.Ads.Add(ad);
                await _ctx.SaveChangesAsync();
                return View("~/Views/Member/AdCreateMessage.cshtml");
            }
            catch
            {
                return RedirectToAction("Login", "Account");
            }
        }
       //ublic bool UpdateAd(Ad ad) { }
       //ublic bool RemoveAd(int id) { }
    }*/
    }
}
