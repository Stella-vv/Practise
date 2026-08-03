using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_IBuyable.Interface
{
    public interface IBuyable
    {
        public decimal GetFinalPrice(decimal discount, decimal price);
    }
}
