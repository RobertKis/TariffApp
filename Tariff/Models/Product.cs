using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TariffApp.Models
{
    public class Product : IProduct
    {
        public int ProductId { get; set; }
        public decimal AnnualCost { get; set; }
        public decimal Consumption { get; set; }
        public TariffTypes Type { get; set; }
        public ProductTypes Resource { get; set; }
    }
}
