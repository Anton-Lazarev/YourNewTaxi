using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YourNewTaxi.Domain.Abstract;
using YourNewTaxi.Domain.Entities;

namespace YourNewTaxi.WebUI.Controllers
{
    public class ManagerController : Controller
    {
        private IOrderRepository repository;
        public ManagerController(IOrderRepository orderRepository)
        {
            this.repository = orderRepository;
        }

        public ViewResult ShowAllOrders()
        {
            return View(repository.Orders);
        }
    }
}
