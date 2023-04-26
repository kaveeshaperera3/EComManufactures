using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EComManufactures.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartReposotory _cartRepo;

        public CartController(ICartReposotory cartRepo)
        {
            _cartRepo = cartRepo;
        }
        public async Task<IActionResult> AddItem(int ComputerId, int Quantity=1,int redirect=0)        
        {
            var cartCount = await _cartRepo.AddItem(ComputerId, Quantity);
            if (redirect == 0)
                return Ok(cartCount);
            return RedirectToAction("GetUserCart");
        }

        public async Task<IActionResult> RemoveItem(int ComputerId)
        {
            var cartCount = await _cartRepo.RemoveItem(ComputerId);
            return RedirectToAction("GetUserCart");
        }

        public async Task<IActionResult> GetUserCart()
        {
            var cart = await _cartRepo.GetUserCart();
            return View(cart);
        }

        public async Task<IActionResult> GetTotalItemInCart()
        {
            int cartItem = await _cartRepo.GetCartItemCount();
            return Ok(cartItem);
        }
        public async Task<IActionResult> Checkout()
        {
            bool isCheckedOut = await _cartRepo.DoCheckout();
            if (!isCheckedOut)
                throw new Exception("Something happen in server side");
            return RedirectToAction("Index", "Home");
        }
    }
}
