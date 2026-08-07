using ConsoleApp_PaintProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PaintStore.Models
{
    public class PaintStore
    {
        public PaintProduct[] Products;

        public PaintStore(PaintProduct[] products)
        {
            Products = products;
        }

        public void StoreAvailability()
        {
            Console.WriteLine($"These products are available: ");
            foreach(PaintProduct product in Products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
