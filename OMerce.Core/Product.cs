using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Core
{
    public class Product:BaseEntity
    {
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }

        public Product(string Name)
        {
            this.Name = Name;
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }

        public void ReduceQuantityBy(int requestedQuantity)
        {
            if (requestedQuantity>AvailableQuantity) throw new Exception("Out of stock");
            AvailableQuantity -= requestedQuantity;
        }
    }
}
