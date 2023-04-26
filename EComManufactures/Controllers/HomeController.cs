using EComManufactures.Models;
using EComManufactures.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using System.Diagnostics;
using System.IO;

namespace EComManufactures.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;
        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public async Task <IActionResult> Index(string sTerm="", int CatagoryID=0)
        {            
            IEnumerable<Computer> computer = await _homeRepository.GetComputers(sTerm, CatagoryID);
            IEnumerable<Catagory> catagories = await _homeRepository.Catagories();
            ComputerDisplayModel computerModel = new ComputerDisplayModel
            {
                Computers = computer,
                Catagories = catagories,
                STerm = sTerm,
                CatagoryID = CatagoryID
            };
            return View(computerModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ComputerDetails()
        {
            //IEnumerable<Computer> computer = await _homeRepository.GetComputers(comTitle);            
            //ComputerDisplayModel computerModel = new ComputerDisplayModel
            //{                      
            //    Computers = Computer,
            //    comTitle = comTitle
            //};
            return View();        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}