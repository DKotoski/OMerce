using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Core
{
    public enum CartStatus
    {
        New=0,
        Paid=1,
        Canceled = 3
    }
    public class ShoppingCart:BaseEntity
    {
        public List<Product> Products { get; set; }
        public CartStatus Status { get; private set; }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void Pay()
        {
            Status = CartStatus.Paid;
        }

        public void Cancel()
        {
            Status = CartStatus.Canceled;
        }
    }
}
