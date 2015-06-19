using OMerce.AppServices;
using OMerce.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
namespace OMerce.WebShop.Controllers
{
    public class CartController : Controller
    {
        private CartService cartService;

        public CartController()
        {
            string connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            var dbContext = new OMerceDbContext(connString);
            cartService = new CartService(new ProductRepository(dbContext), new CartRepository(dbContext));
        }
        [HttpPost]
        public ActionResult AddProductToCart(int productID, int cartId)
        {

            return View();
        }
    }
}