using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Enum;
using ConsoleApp_PaintSpecification.Models;
using ConsoleApp_IBuyable.Interface;
using ConsoleApp_Brand.Models;

namespace ConsoleApp_PaintProduct.Models
{
    public class PaintProduct : IBuyable
    {
        public readonly decimal TaxRate;
        public const decimal DefaultDiscount = 0.05m;
        public string Name { get; set; }
        public PaintType Type { get; set; }
        public PaintSpecification Specification { get; set; }
        public decimal Price { get; set; }
        public Brand Brand { get; set; }

        public PaintProduct(string name, PaintType type, PaintSpecification specification, decimal price, Brand brand)
        {
            Name = name;
            Type = type;
            Specification = specification;
            Price = price;
            TaxRate = 0.10m;
            Brand = brand;
        }

        public decimal GetFinalPrice(decimal discount, decimal price)
        {
            return (1 - discount) * price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Price : {Price}, Brand: {Brand.Name}");
            Specification.DisplaySpecification();
        }

        public decimal GetMaxDiscount(int rate, bool isOverridable)
        {
            if (isOverridable == true)
            {
                if (rate > 0 && rate < 100)
                {
                    return rate / 100m;
                }
                else
                {
                    throw new Exception("Discount rate must be between 0 and 100.");
                }
                
            }
            else {
                return DefaultDiscount;
            }
        }
    }


}
