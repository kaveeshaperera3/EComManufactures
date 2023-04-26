using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EComManufactures.Models
{
    [Table("OrdersStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required]
        public int StatusID { get; set; }
        [MaxLength(20)]
        [Required]
        public string? StatusName { get; set; }
    }
}