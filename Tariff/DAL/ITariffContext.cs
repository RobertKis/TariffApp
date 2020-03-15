using TariffApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TariffApp.DAL
{
    public interface ITariffContext
    {
        DbSet<Product> Products { get; set; }
    }
}