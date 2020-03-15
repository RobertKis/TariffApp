using TariffApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TariffApp.DAL
{
    public static class TariffInitializer
    {
        public static void Initialize(TariffContext context)
        {
            var products = new List<Product>
            {
               new Product{AnnualCost = 800, Consumption=3000, Resource=ProductTypes.Electricity, Type=TariffTypes.PackagedTariff},
               new Product{AnnualCost= 830, Consumption=3500, Resource=ProductTypes.Electricity, Type=TariffTypes.BasicTariff},
            };

            products.ForEach(u => context.Products.Add(u));
            context.SaveChanges();
        }
    }
}
