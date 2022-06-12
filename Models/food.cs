using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodStockChecker.Models
{
    public class food
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        [DataType(DataType.Date)]
        public  DateTime ExpireDate { get; set; }

    }
}
