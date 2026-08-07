using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_PaintProduct.Models;

namespace ConsoleApp_Order.Models
{
    public class Order
    {
        public readonly DateTime CreatedAt = DateTime.Now;
        public PaintProduct[] Products;
        public int Quantity { get; set; }
        public decimal TotalPrice;

        public Order(PaintProduct[] products, int quantity)
        {
            Products = products;
            Quantity = quantity;
            //TotalPrice = Products.Price * Quantity;
        }

        public void DisPlay()
        {
            Console.WriteLine($"Create Time: {CreatedAt}, Quantity: {Quantity} for each, Total price: {TotalPrice}");
            Console.WriteLine($"product name:");
            foreach (PaintProduct product in Products)
            {
                Console.WriteLine(product.Name);
            }
            //Console.WriteLine($"Product name: {Products.Name}, TotalPrice: {TotalPrice}, Create Time: {CreatedAt}, Quantity: {Quantity}");
        }

        public void GetTotalPrice()
        {
            Console.WriteLine($"TotalPrice: {TotalPrice}");
        }

        public void GetTotalOrderPrice()
        {
            decimal totalOrderPrice = 0;
            foreach (PaintProduct product in Products)
            {
                totalOrderPrice += product.Price * Quantity;
            }
            TotalPrice = totalOrderPrice;
        }

    }
}