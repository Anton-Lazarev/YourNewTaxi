using System.ComponentModel.DataAnnotations;

namespace YourNewTaxi.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Please enter finish address")]
        public string AddressFinish { get; set; }

        [Required(ErrorMessage = "Please enter start address")]
        public string AddressStart { get; set; }

        [RegularExpression("[0-9]{4}-(0[1-9]|1[012])-(0[1-9]|1[0-9]|2[0-9]|3[01])",
            ErrorMessage = "Please enter a valid date")]
        public string Date { get; set; }

        public int ExecutorID { get; set; }
        public string FIO { get; set; }
        public int ID { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

        [RegularExpression("[0-9]{0,24}:[0-9]{0,60}",
            ErrorMessage = "Please enter a valid time")]
        public string Time { get; set; }

        /*[RegularExpression((?:8|\+7)? ?\(?(\d{3})\)? ?(\d{3})[ -]?(\d{2})[ -]?(\d{2}),
          ErrorMessage = "Please enter a valid telephone number")]*/
        public string ClientPhone { get; set; }

        public void AddOrder(Order order)
        {
            //Делаем запись в БД
        }
    }
}