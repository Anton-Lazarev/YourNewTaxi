using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Ninject;
using YourNewTaxi.Domain.Entities;
using YourNewTaxi.Domain.Abstract;
using YourNewTaxi.WebUI.Infrastructure.Abstract;
using YourNewTaxi.WebUI.Infrastructure.Concrete;

namespace YourNewTaxi.WebUI.Infrastructure
{
    // реализация пользовательской фабрики контроллеров, 
    // наследуясь от фабрики используемой по умолчанию
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            // создание контейнера
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // получение объекта контроллера из контейнера 
            // используя его тип
            return controllerType == null
              ? null
              : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            // конфигурирование контейнера
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            mock.Setup(m => m.Orders).Returns(new List<Order>
            {
                new Order { FIO = "DemoName1", Price = 100 },
                new Order { FIO = "DemoName2", Price = 200 }
            }.AsQueryable());

            ninjectKernel.Bind<IOrderRepository>().ToConstant(mock.Object);

            //Добавляем привязку Ninject для провайдера аутентификации
            ninjectKernel.Bind<IAuthenticate>().To<IAuthenticateImplementation>();
        }
    }
}