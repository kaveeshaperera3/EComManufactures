namespace EComManufactures
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Catagory>> Catagories();
        Task<IEnumerable<Computer>> GetComputers(string sTerm = "", int CategoryID = 0);
    }
}