using EComManufactures.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EComManufactures.Controllers
{
    public class ComputersController : Controller
    {
        private readonly IComputersRepository _computersRepository;
        private readonly ILogger<ComputersController> _logger;

        public ComputersController(ILogger<ComputersController> logger, IComputersRepository computersRepository)
        {
            _computersRepository = computersRepository;
            _logger = logger;
        }
                          

        public async Task<IActionResult> Index(string sTerm, int CatagoryID, string computerSeries)
        {
            var computerDisplayModel = new ComputerDisplayModel()
            {
                Computers = await _computersRepository.GetComputers(sTerm, CatagoryID, computerSeries),
                Catagories = await _computersRepository.Catagories(),
                STerm = sTerm,
                CatagoryID = CatagoryID,
                ComputerSeries = computerSeries // Add this line to pass the computerSeries to the view
            };

            return View(computerDisplayModel);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

