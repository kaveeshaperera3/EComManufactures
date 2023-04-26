namespace EComManufactures.Repository
{
    public interface ICartReposotory
    {
        Task<int> AddItem(int ComputerId, int Quantity);
        Task<int> RemoveItem(int ComputerId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task <bool> DoCheckout();
    }
}
