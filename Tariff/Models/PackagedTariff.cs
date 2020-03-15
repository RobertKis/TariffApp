using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TariffApp.Models
{
    public static class PackagedTariff
    {
        public static int PackagedTariffId;
        public static string Name { get; }
        public static int Limit { get; } = 4000;
        public static decimal Rate { get; } = 30;
        public static TariffTypes Type { get; } = TariffTypes.PackagedTariff;
        public static ProductTypes Resource { get; } = ProductTypes.Electricity;

        public static decimal CalculateCost(decimal amount)
        {
            if(amount < Limit)
            {
                return 800;
            }
            else
            {
                return 800 + ((amount - 4000) * Rate);
            }
        }
    }
}
