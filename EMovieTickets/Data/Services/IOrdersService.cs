using EMovieTickets.Models;

namespace EMovieTickets.Data.Services
{
    public interface IOrdersServices
    {
        Task StoreOrderAsync(List<ShoppingCartItem> shoppingCartItems, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
