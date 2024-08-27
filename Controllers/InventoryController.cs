using HorousCore.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HorousCore.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public IActionResult Index()
        {
            var items = _inventoryService.GetAllItems();
            return View(items);
        }
    }
}
