using EMovieTickets.Data.Cart;
using EMovieTickets.Data.Services;
using EMovieTickets.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EMovieTickets.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMoviesService _movieService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersServices _ordersService;
        public OrdersController(IMoviesService movieService, ShoppingCart shoppingCart, IOrdersServices ordersService)
        {
            _movieService = movieService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await _ordersService.GetOrdersByUserIdAsync(userId);

            return View(orders);
        }
        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }

        public async Task<RedirectToActionResult> AddToShoppingCart(int id) {
            var item = await _movieService.GetMovieByIdAsync(id);
            if (item != null) {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }


        public async Task<RedirectToActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _movieService.GetMovieByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmailAddress = "";

            await _ordersService.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();

            return View("OrderCompleted");
        }
    }
}
