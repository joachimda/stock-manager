using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StockManager.Models
{
    public class ChargerModel
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int InputVoltage { get; set; }
        public int OutputVoltage { get; set; }
        public int InputCurrent { get; set; }
        public int OutputCurrent { get; set; }
        public string CurrentType { get; set; }
        public string Comment { get; set; }
        public string Location { get; set; }
    }
}