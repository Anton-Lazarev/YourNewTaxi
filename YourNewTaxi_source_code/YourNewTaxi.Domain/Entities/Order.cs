using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNewTaxi.Domain.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string AddressFinish { get; set; }
        public string AddressStart { get; set; }
        public string Date { get; set; }
        public int ExecutorID { get; set; }
        public string FIO { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }

    }
}
