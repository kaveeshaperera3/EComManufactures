using EComManufactures.Models;
using EComManufactures.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Index(string sTerm = "", int catagoryID = 0, string computerSeries = "")
        {
            IEnumerable<Computer> computers = await _homeRepository.GetComputers(sTerm, catagoryID, computerSeries);
            IEnumerable<Catagory> catagories = await _homeRepository.Catagories();

            ComputerDisplayModel computerModel = new ComputerDisplayModel
            {
                Computers = computers,
                Catagories = catagories,
                STerm = sTerm,
                CatagoryID = catagoryID,
                ComputerSeries = computerSeries
            };

            return View(computerModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ComputerDetails(int id)
        {
            // Logic for computer details action
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
