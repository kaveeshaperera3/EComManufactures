using EComManufactures.Models;
using EComManufactures.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EComManufactures.Models;

using System.Linq;

namespace EComManufactures.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Catagory>> Catagories()
        {
            return await _db.Catagories.ToListAsync();
        }

        
        public async Task<IEnumerable<Computer>> GetComputers(string sTerm = "", int catagoryID = 0, string computerSeries = "")
        {
            sTerm = sTerm.ToLower();

            var query = from computer in _db.Computers
                        join catagory in _db.Catagories on computer.CatagoryID equals catagory.Id
                        where string.IsNullOrWhiteSpace(sTerm) || computer.ComputerTitle.ToLower().StartsWith(sTerm)
                        select new { Computer = computer, Catagory = catagory };

            if (catagoryID > 0)
            {
                query = query.Where(c => c.Computer.CatagoryID == catagoryID);
            }

            if (!string.IsNullOrWhiteSpace(computerSeries))
            {
                query = query.Where(c => c.Computer.ComputerSeries == computerSeries);
            }

            var computersQuery = query.Select(c => new Computer
            {
                ComputerId = c.Computer.ComputerId,
                ComputerImgUrl3 = c.Computer.ComputerImgUrl3,
                ComputerRam = c.Computer.ComputerRam,
                ComputerPrice = c.Computer.ComputerPrice,
                CatagoryID = c.Computer.CatagoryID,
                ComputerTitle = c.Computer.ComputerTitle,
                CatagoryName = c.Catagory.CatagoryName,
                ComputerSeries = c.Computer.ComputerSeries
            });

            var computers = await computersQuery.ToListAsync();

            if (catagoryID > 0 && string.IsNullOrWhiteSpace(computerSeries))
            {
                // If only category is selected, include all computers for the selected category
                var categoryComputers = await _db.Computers
                    .Where(c => c.CatagoryID == catagoryID)
                    .ToListAsync();

                computers.AddRange(categoryComputers);
            }
            else if (catagoryID == 0 && !string.IsNullOrWhiteSpace(computerSeries))
            {
                // If only series is selected, include all computers with the selected series
                var seriesComputers = await _db.Computers
                    .Where(c => c.ComputerSeries == computerSeries)
                    .ToListAsync();

                computers.AddRange(seriesComputers);
            }

            return computers;
        }






    }
}
