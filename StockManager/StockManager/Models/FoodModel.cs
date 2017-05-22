using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StockManager.Models
{
    public class FoodModel 
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Location { get; set; }
    }   
}