namespace TariffApp.Models
{
    public interface IProduct
    {
        decimal AnnualCost { get; set; }
        decimal Consumption { get; set; }
        int ProductId { get; set; }
        ProductTypes Resource { get; set; }
        TariffTypes Type { get; set; }
    }
}