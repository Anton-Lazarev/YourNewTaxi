using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourNewTaxi.WebUI.Infrastructure.Abstract;
using YourNewTaxi.WebUI.Models;

namespace YourNewTaxi.WebUI.Controllers
{
    public class AccountController : Controller
    {
        IAuthenticate iAuthenticate;

        public AccountController(IAuthenticate auth)
        {
            iAuthenticate = auth;
        }

        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (iAuthenticate.Authenticate(model.UserName, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Executor"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }



    }
}
