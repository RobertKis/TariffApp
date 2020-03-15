using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TariffApp.Models
{
    public static class BasicElectricityTariff
    {
        public static TariffTypes Type { get; } = TariffTypes.BasicTariff;
        public static ProductTypes Resource { get; } = ProductTypes.Electricity;
        public static string Name { get; } = "Basic Electricity Tariff";
        public static decimal MonthlyFee { get; } = 5;
        public static decimal ConsumptionCost { get; } = 22;

        public static decimal CalculateCost(int amount)
        {
            return (MonthlyFee * 12) + (amount * ConsumptionCost);
        }
    }
}
