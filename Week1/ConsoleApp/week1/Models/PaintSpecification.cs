using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp_PaintSpecification.Models
{
    public class PaintSpecification
    {
        public string Color;
        public int SizeInLiters;

        public PaintSpecification(string color,int sizeInLiters)
        {
            Color = color;
            SizeInLiters = sizeInLiters;
        }

        public void DisplaySpecification()
        {
            Console.WriteLine($"Color is : {Color}, size is : {SizeInLiters} Liters");
        }
    }
}
