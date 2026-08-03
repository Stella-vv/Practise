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
        public PaintProduct Product;
        public int Quantity { get; set; }
        public decimal TotalPrice;

        public Order( PaintProduct product, int quantity) 
        {
            Product = product;
            Quantity = quantity;
            TotalPrice = Product.Price * Quantity;
        }

        public void DisPlay()
        {
            Console.WriteLine($"Product name: {Product.Name}, TotalPrice: {TotalPrice}, Create Time: {CreatedAt}, Quantity: {Quantity}");
        }

        public void GetTotalPrice()
        {
            Console.WriteLine($"TotalPrice: {TotalPrice}");
        }

    }
}
