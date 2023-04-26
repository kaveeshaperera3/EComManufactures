using System.ComponentModel.DataAnnotations.Schema;

namespace EComManufactures.Models
{
    [Table("VirusGuard")]
    public class VirusGuard
    {
        public int Id { get; set; }
        public string VirusTitle { get; set; }
        public string Description { get; set; }
        public double VirusPrice { get; set; }

        public List<Computer> Computer { get; set; }
        public List<OrderDetail> orderDetail { get; set; }
       
    }
}
