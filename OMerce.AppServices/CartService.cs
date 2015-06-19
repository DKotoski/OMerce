using OMerce.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.AppServices
{
    public class CartService
    {

        private IProductRepository productRepo;
        private ICartRepository cartRepo;


        public CartService(IProductRepository productRepo, ICartRepository cartRepo)
        {
            this.productRepo = productRepo;
            this.cartRepo = cartRepo;
        }

        public void AddProductToCart(int productID, int cartID)
        {
            var cart = cartRepo.GetById(cartID);
            var product = productRepo.GetById(productID);

            cart.AddProduct(product);

            cartRepo.Save(cart);
        }

        public void PayCart(int cartID)
        {
            var cart = cartRepo.GetById(cartID);

            cart.Pay();

            cartRepo.Save(cart);
        }

        public void CancelCart(int cartID)
        {
            var cart = cartRepo.GetById(cartID);

            cart.Cancel();

            cartRepo.Save(cart);
        }
    }
}
