using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComManufactures.Models

{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ComputerId { get; set; }
        // public int DestopCompterId { get; set; }
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }               
        public Computer Computer { get; set; }
        // public DestopComputer DestopComputer { get; set; }
        public Order Order { get; set; }

        //for additionals
        public int RamID { get; set; }
        public Ram Ram { get; set; }

        public int ProcessorID { get; set; }
        public Processor Processor { get; set; }

        public int HardID { get; set; }
        public Hard Hard { get; set; }

        public int VirusID { get; set; }
        public VirusGuard VirusGuard { get; set; }


    }
}