using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourNewTaxi.Domain.Abstract;
using YourNewTaxi.Domain.Entities;

namespace YourNewTaxi.WebUI.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                order.AddOrder(order);
                return View("Success", order);
            }
            else
            {
                return View();
            }
        }


    }
}
