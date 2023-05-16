namespace EComManufactures
{
    public interface IComputersRepository
    {
        Task<IEnumerable<Computer>> GetComputers(string sTerm = "", int CategoryID = 0, string ComputerSeries = "");
        Task<IEnumerable<Catagory>> Catagories();
        Task<Computer> GetComputerById(int computerId);
        Task<IEnumerable<Computer>> GetComputersBySeries(string sTerm = "", int CategoryID = 0, string computerSeries = "");
    }
}

