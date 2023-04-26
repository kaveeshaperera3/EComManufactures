using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EComManufactures.Models
{
    [Table("Catagory")]
    public class Catagory
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CatagoryName { get; set; }
        public List<Computer> Computers { get; set; }
        //public List<DestopComputer> DestopComputer { get; set; }

    }
}