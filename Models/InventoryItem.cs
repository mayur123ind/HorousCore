using System.ComponentModel.DataAnnotations;

namespace HorousCore.Models
{
    public class InventoryItem
    {
        [Key]
        public int InventoryId { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
