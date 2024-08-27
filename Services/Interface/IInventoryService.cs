using HorousCore.Models;
namespace HorousCore.Services.Interface
{
    public interface IInventoryService
    {
        List<InventoryItem> GetAllItems();
    }
}
