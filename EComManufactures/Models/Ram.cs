using System.ComponentModel.DataAnnotations.Schema;

namespace EComManufactures.Models
{
    [Table("Ram")]
    public class Ram
    {
        public int Id { get; set; }
        public string RamTitle { get; set; }
        public string RamDescription { get; set; }
        
        public double RamPrice { get; set; }

        //public List<Computer> Computer { get; set; }
        public List<OrderDetail> orderDetail { get; set; }

    }
}