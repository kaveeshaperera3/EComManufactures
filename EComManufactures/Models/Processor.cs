using System.ComponentModel.DataAnnotations.Schema;

namespace EComManufactures.Models
{
    [Table("Processor")]
    public class Processor
    {
        public int Id { get; set; }
        public string ProcessorTitle { get; set; }
        public string ProcessorDescription { get; set; }
        public double ProcessorPrice { get; set; }

        //public List<Computer> Computer { get; set; }
        public List<OrderDetail> orderDetail { get; set; }
    }
}