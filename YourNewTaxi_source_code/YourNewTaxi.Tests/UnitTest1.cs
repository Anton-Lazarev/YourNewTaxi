using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YourNewTaxi.Domain.Entities;

namespace YourNewTaxi.Tests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}


//namespace UnitTestProject1
//{

// Order order1;
// order1.AdressFinish="ул. Гумилева 15 4 подъезд";
// order1.AdressStart="ул. Б. Покровская 8"
// order1.Date="14.04.2015";
// order1.ExecutorID=0;
// order1.FIO="Иванов Иван Иванович";
// order1.ID=0;
// order1.Price=600;
// order1.Status="waiting executor";
// order1.Time="12.12";

// Order order2;
// order2.AdressFinish="ул. Гумилева 15 4 подъезд";
// order2.AdressStart="ул. М. Покровская 8"
// order2.Date="14.04.2015";
// order2.ExecutorID=1;
// order2.FIO="Иванов Иван Иванович";
// order2.ID=1;
// order2.Price=600;
// order2.Status="runing";
// order2.Time="12.12";

//Executor Executor1;
//Executor1.AvtoInfo="черный вольво гос номер И152СУ";
//Executor1.FIO="Иванов Иван Иванович";
//Executor1.ID=0;
//Executor1.PhoneNuber "+79110000000";
//Executor1.Status= "ofline";

//    Executor Executor2;
//Executor2.AvtoInfo="серобуромалиновый пежо";
//Executor2.FIO="Джон Доу";
//Executor2.ID=1;
//Executor2.PhoneNuber "+79110000000";
//Executor2.Status= "online";

//    [TestClass]
//    public class RepositoryTest1 // orderrepository
//    {
//        [TestMethod]
//        public void SaveOrderTest()
//        {
//         EFOrderRepository OrderRepository1 =EFOrderRepository();

//         OrderRepository1.SaveOrder(Order1);
//            Assert.Inconclusive("проверте создание объекта в базе данных для подтверждения");
//        }

//        [TestMethod]
//        public void EditOrderTest()
//        {
//         EFOrderRepository OrderRepository1 =EFOrderRepository();

//         OrderRepository1.Update(Order2);
//            Assert.Inconclusive("проверте изменени объекта в базе данных для подтверждения");
//        }

//        [TestMethod]
//        public void DeleteOrderTest()
//        {
//         EFOrderRepository OrderRepository1 =EFOrderRepository();
//         OrderRepository1.DeleteOrder(1);
//          Assert.Inconclusive("проверте удаление объекта в базе данных для подтверждения");
//        }
//    }

//     [TestClass]
//    public class RepositoryTest2 // executorrepository
//    {
//        [TestMethod]
//        public void SaveExecutorTest()
//        {
//         EFExecutorRepository OrderRepository1 =EFExecutorRepository();
//         ExecutorRepository1.SaveExecutor(Order1);
//            Assert.Inconclusive("проверте создание объекта в базе данных для подтверждения");
//        }
//        [TestMethod]
//        public void EditExecutorTest()
//        {
//         EFExecutorRepository ExecutorRepository1 =EFExecutorRepository();
//         ExecutorRepository1.Update(Order2);
//            Assert.Inconclusive("проверте изменени объекта в базе данных для подтверждения");
//        }

//        [TestMethod]
//        public void DeleteExecutorTest()
//        {
//         EFExecutorRepository ExecutorRepository1 =EFExecutorRepository();
//         ExecutorRepository1.DeleteExecutor(1);
//          Assert.Inconclusive("проверте удаление объекта в базе данных для подтверждения");
//        }
//    }

// [TestClass]
//    public class mangertest // mangertests
//    {
//        [TestMethod]
//        public void corectlogin()
//        {
//            managerconroler Controler1;
//            bool test=Controler1.LogIn("God","admin");
//            Assert.IsFalse(test,"аунтификация не прошла успешно");
//        }
//     [TestMethod]
//        public void incorectlogin()
//        {
//            managerconroler Controler1;
//            bool test=Controler1.LogIn("God","admen");
//            Assert.IsTrue(test,"аунтификация проходит несмотря на неверные данные");
//        }
//        [TestMethod]
//        public void CreateExecutorcorectlogin()
//        {
//            managerconroler Controler1;
//            bool test=Controler1.LogIn("God","admin");
//            Controler1.AddExecutor("");
//            Assert.Inconclusive("проверте создание объекта в базе данных для подтверждения");
//        }

//     [TestMethod]
//        public void CreateExecutorincorectlogin()
//        {
//            managerconroler Controler1;
//            Controler1.AddExecutor("");
//            Assert.Inconclusive("проверте отсутствие изменений в базе данных для подтверждения");
//        }
// }


//}
