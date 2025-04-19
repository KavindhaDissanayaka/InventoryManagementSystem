using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public string Supplier { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public int ReorderLevel { get; set; } = int.MinValue;
    }
}
