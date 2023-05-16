namespace EComManufactures.Models.DTOs
{
    public class ComputerDisplayModel
    {
        public IEnumerable<Computer> Computers { get; set; }
        public IEnumerable<Catagory> Catagories { get; set; }
        
        public string STerm { get; set; } = "";
        public int CatagoryID { get; set; } = 0;
        public string ComputerSeries { get; set; } = "";
    }
}


