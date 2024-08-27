using HorousCore.AppDBContext;
using HorousCore.Models;
using HorousCore.Services.Interface;

namespace HorousCore.Services.Service
{
    public class InventoryService : IInventoryService
    {
        private readonly HorousCoreDBContext _context;

        public InventoryService(HorousCoreDBContext context)
        {
            _context = context;
        }
        public List<InventoryItem> GetAllItems()
        {
            return _context.InventoryItems.ToList();
        }
    }
}
