using EMovieTickets.Data.Cart;
using EMovieTickets.Data.Services;
using EMovieTickets.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EMovieTickets.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMoviesService _movieService;
        private readonly ShoppingCart _shoppingCart;
        public OrdersController(IMoviesService movieService, ShoppingCart shoppingCart)
        {
            _movieService = movieService;
            _shoppingCart = shoppingCart;
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
    }
}
