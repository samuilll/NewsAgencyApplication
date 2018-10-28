using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using New.Models;
using News.App.Models;
using News.Repository;

namespace News.App.Controllers
{
    public class AccountController : BaseController
    {
        private UserManager<User> userManager;

        public AccountController()
        {
            this.userManager = new UserManager<User>(new UserStore<User>(this.Context));
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }
            User user = new User()
            {
                UserName = model.Username,
                PasswordHash = model.Password
            };
            var result = this.userManager.CreateAsync(user, user.PasswordHash );
            return View();
        }
    }
}