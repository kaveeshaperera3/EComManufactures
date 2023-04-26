
using EComManufactures.Models;
using Microsoft.EntityFrameworkCore;

namespace EComManufactures.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;
         
        public HomeRepository(ApplicationDbContext db) //ctor
        {
            _db = db;
        }
        public async Task<IEnumerable<Catagory>> Catagories()
        {
            return await _db.Catagories.ToListAsync();
        }
        public async Task<IEnumerable<Computer>> GetComputers(string sTerm="",int CategoryID = 0 )
        {
            sTerm= sTerm.ToLower();
            IEnumerable <Computer> computer = await (from Computer in _db.Computers
                            join Catagory in _db.Catagories
                            on Computer.CatagoryID equals Catagory.Id
                            where string.IsNullOrWhiteSpace(sTerm) || (Computer!=null && Computer.ComputerTitle.ToLower().StartsWith(sTerm))
                            select new Computer
                            {
                                ComputerId = Computer.ComputerId,
                                ComputerImgUrl3 = Computer.ComputerImgUrl3,
                                ComputerRam = Computer.ComputerRam,
                                ComputerPrice = Computer.ComputerPrice,
                                CatagoryID = Computer.Catagory.Id,
                                ComputerTitle = Computer.ComputerTitle,
                                CatagoryName = Catagory.CatagoryName
                            }
                            ).ToListAsync();
            if(CategoryID > 0)
            {
                computer = computer.Where(a => a.CatagoryID == CategoryID).ToList(); 
            }
                        
            return computer; 
        }

        //public async Task<IEnumerable<Computer>> GetComputers(string ComputerSeries = "", int CategoryID = 0, )
        //{
        //    ComputerSeries = ComputerSeries.ToLower();
        //    IEnumerable<Computer> computer = await (from Computer in _db.Computers
        //                                            join Catagory in _db.Catagories
        //                                            on Computer.CatagoryID equals Catagory.Id
        //                                            where string.IsNullOrWhiteSpace(ComputerSeries || (Computer != null && Computer.ComputerTitle.ToLower().StartsWith(ComputerSeries))
        //                                            select new Computer
        //                                            {
        //                                                ComputerId = Computer.ComputerId,
        //                                                ComputerImgUrl3 = Computer.ComputerImgUrl3,
        //                                                ComputerRam = Computer.ComputerRam,
        //                                                ComputerPrice = Computer.ComputerPrice,
        //                                                CatagoryID = Computer.Catagory.Id,
        //                                                ComputerTitle = Computer.ComputerTitle,
        //                                                CatagoryName = Catagory.CatagoryName
        //                                            }
        //                    ).ToListAsync();
        //    if (CategoryID > 0)
        //    {
        //        computer = computer.Where(a => a.CatagoryID == CategoryID).ToList();
        //    }

        //    return computer;
        //}
    }
}
