using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealestateApplication.Data;
using RealestateApplication.Models;

namespace RealestateApplication.Controllers
{
    public class MemberController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _ctx;
        public MemberController(UserManager<ApplicationUser> userManager, ApplicationDbContext ctx)
        {
            _userManager = userManager;
            _ctx = ctx;

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
        
    }
}