using HorousCore.Models;
using Microsoft.EntityFrameworkCore;

namespace HorousCore.AppDBContext
{
    public class HorousCoreDBContext : DbContext
    {
        public HorousCoreDBContext(DbContextOptions<HorousCoreDBContext> options) : base(options) 
        {

        }

        public DbSet<InventoryItem> InventoryItems { get; set; }
    }
}
