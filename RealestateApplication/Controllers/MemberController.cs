using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealestateApplication.Models;

namespace RealestateApplication.Controllers
{
    public class MemberController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        
        public MemberController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            
        }

        public ActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId==null)
            {
                return RedirectToAction("Login","Account");
            }
            else {
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                return View(user);
            }
        }
        public ActionResult List()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                return View(user);
            }

        }
        
    }
}