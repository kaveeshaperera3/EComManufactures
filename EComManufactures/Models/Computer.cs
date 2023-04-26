using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace EComManufactures.Models
{
    [Table("Computer")]
    public class Computer
    {
        public int ComputerId { get; set; }
        [Required]
        [MaxLength(40)]
        public string? ComputerTitle { get; set; }
        public string ComputerBrand { get; set; }
        //public string ComputerCategory { get; set; }
        public string ComputerSeries { get; set; }
        public string ComputerRam { get; set; }
        public string ComputerHard { get; set; }
        //public string ComputerProcessor { get; set; }
        public string ComputerGraphic { get; set; }
        //public string ComputerColour { get; set; }
        //public string ComputerAntiVirus { get; set; }
        public string ComputerWarrenty { get; set; }
        public double ComputerPrice { get; set; }
        public string? ComputerImgUrl1 { get; set; }
        public string? ComputerImgUrl2 { get; set; }
        public string? ComputerImgUrl3 { get; set; }
        public string ComputerDescription { get; set; }
        public string ComputerStatus { get; set; }

        //relationships
        public int CatagoryID { get; set; }
        public Catagory Catagory { get; set; }

        //public int RamID { get; set; }
        //public Ram Ram { get; set; }

        //public int ProcessorID { get; set; }
        //public Processor Processor { get; set; }

        //public int HardID { get; set; }
        //public Hard Hard { get; set; }

        //public int VirusID { get; set; }
        public VirusGuard VirusGuard { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]
        public string CatagoryName { get; set; }
    }
}
