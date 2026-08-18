using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_PaintProduct.Models;

namespace ConsoleApp_Order.Models
{
    public class Order
    {
        public readonly DateTime CreatedAt = DateTime.Now;
        public List <PaintProduct> Products;
        public int Quantity { get; set; }
        public decimal TotalPrice;

        public Order(List<PaintProduct> products, int quantity)
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

        public void RemoveProduct(int productId)
        {
            PaintProduct?product = Products.FirstOrDefault( p => p.ProductId == productId);

            if(product != null)
            {
                Products.Remove(product);
            }
        }

        public void GetMostExpensiveProduct()
        {
            PaintProduct?product = Products.OrderByDescending(p => p.Price).FirstOrDefault();

            if(product != null)
            {
                Console.WriteLine($"this is the most expensive one:{product.Name}, Price: {product.Price}");
            }
        }

        public void FindProduct(int minimum, int maximum)
        {
            var products = Products.Where(p => p.Price>minimum&&p.Price<maximum);
            foreach(PaintProduct product in products)
                {
                    Console.WriteLine($"The price within range {minimum} and {maximum} is:{product.Name}, Price: {product.Price}");
                }
        }

        public void TypeTotalPrice()
        {
            var products = Products.GroupBy(p => p.Type);
            foreach (var group in products)
            {
                decimal typeTotalPrice = group.Sum(p => p.Price);
                Console.WriteLine($"Paint Type:{group.Key}, total price is {typeTotalPrice}");
            }
        }

    }
}