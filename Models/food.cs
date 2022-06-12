using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStockChecker.Models
{
    public class food
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double Wage { get; set; }
        public  DateTime ExpireDate { get; set; }

    }
}
