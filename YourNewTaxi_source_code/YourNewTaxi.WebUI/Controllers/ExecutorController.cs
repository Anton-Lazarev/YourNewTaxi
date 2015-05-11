using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourNewTaxi.Domain.Abstract;
using YourNewTaxi.Domain.Entities;

namespace YourNewTaxi.WebUI.Controllers
{
    public class ExecutorController : Controller
    {
        //
        // GET: /Executor/

        public ActionResult Index()
        {
            return View();
        }

    }
}
