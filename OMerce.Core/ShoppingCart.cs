using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Core
{
    public class ShoppingCart:BaseEntity
    {
        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}
