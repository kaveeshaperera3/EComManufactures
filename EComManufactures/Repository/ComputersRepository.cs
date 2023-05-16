using EComManufactures.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EComManufactures.Repository
{
    public class ComputersRepository : IComputersRepository
    {
        private readonly ApplicationDbContext _db;

        public ComputersRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Catagory>> Catagories()
        {
            return await _db.Catagories.ToListAsync();
        }

        public async Task<IEnumerable<Computer>> GetComputers(string sTerm = "", int CategoryID = 0, string ComputerSeries = "")
        {
            sTerm = sTerm.ToLower();
            IQueryable<Computer> computers = from c in _db.Computers
                                             join cat in _db.Catagories
                                             on c.CatagoryID equals cat.Id
                                             where string.IsNullOrWhiteSpace(sTerm) || c.ComputerTitle.ToLower().StartsWith(sTerm)
                                             select new Computer
                                             {
                                                 ComputerId = c.ComputerId,
                                                 ComputerImgUrl3 = c.ComputerImgUrl3,
                                                 ComputerRam = c.ComputerRam,
                                                 ComputerPrice = c.ComputerPrice,
                                                 CatagoryID = c.Catagory.Id,
                                                 ComputerTitle = c.ComputerTitle,
                                                 CatagoryName = cat.CatagoryName
                                             };
            if (CategoryID > 0)
            {
                computers = computers.Where(c => c.CatagoryID == CategoryID);
            }
            if (!string.IsNullOrWhiteSpace(ComputerSeries))
            {
                computers = computers.Where(c => c.ComputerSeries.ToLower() == ComputerSeries.ToLower());
            }

            return await computers.ToListAsync();
        }

        public async Task<IEnumerable<Computer>> GetComputersBySeries(string sTerm = "", int CategoryID = 0, string ComputerSeries = "")
        {
            return await GetComputers(sTerm, CategoryID, ComputerSeries);
        }

        public async Task<Computer> GetComputerById(int computerId)
        {
            return await _db.Computers.FindAsync(computerId);
        }
    }
}

