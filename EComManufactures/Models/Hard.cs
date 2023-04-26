using System.ComponentModel.DataAnnotations.Schema;

namespace EComManufactures.Models
{
    [Table("HardDisk")]
    public class Hard
    {
        public int Id { get; set; }
        public string HardTitle { get; set; }
        public string HardDescription { get; set; }
        public double HardPrice { get; set; }

        //public List<Computer> Computer { get; set; }
        public List<OrderDetail> orderDetail { get; set; }
    }
}